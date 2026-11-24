using System.Text.Json;
using System.Xml.Linq;

namespace XmlJsonAdapterApp;

public class XmlDocument
{
    public string Content { get; }

    public XmlDocument(string content)
    {
        Content = content;
    }

    public static XmlDocument Read(string xml)
    {
        XDocument.Parse(xml); 
        return new XmlDocument(xml);
    }

    public string ToJson()
    {
        XDocument document = XDocument.Parse(Content);
        if (document.Root is null)
            throw new FormatException("XML-документ не містить кореневого елемента.");

        var rootObject = new Dictionary<string, object?>
        {
            [document.Root.Name.LocalName] = ConvertElement(document.Root)
        };

        return JsonSerializer.Serialize(rootObject, new JsonSerializerOptions
        {
            WriteIndented = true
        });
    }

    private static object? ConvertElement(XElement element)
    {
        var children = element.Elements().ToList();
        var attributes = element.Attributes().ToList();

        if (children.Count == 0 && attributes.Count == 0)
            return element.Value;

        var result = new Dictionary<string, object?>();

        foreach (var attribute in attributes)
            result["@" + attribute.Name.LocalName] = attribute.Value;

        foreach (var group in children.GroupBy(x => x.Name.LocalName))
        {
            var values = group.Select(ConvertElement).ToList();
            result[group.Key] = values.Count == 1 ? values[0] : values;
        }

        if (!string.IsNullOrWhiteSpace(element.Value) && children.Count > 0)
            result["#text"] = element.Nodes().OfType<XText>().FirstOrDefault()?.Value;

        return result;
    }
}
