using System.Text.Json;
using System.Text.Json.Nodes;
using System.Xml.Linq;

namespace XmlJsonAdapterApp;

public class JsonDocument
{
    public string Content { get; }

    public JsonDocument(string content)
    {
        Content = content;
    }

    public static JsonDocument Read(string json)
    {
        System.Text.Json.JsonDocument.Parse(json); 
        return new JsonDocument(json);
    }

    public string ToXml()
    {
        JsonNode? node = JsonNode.Parse(Content);
        if (node is not JsonObject root || root.Count == 0)
            throw new FormatException("JSON повинен містити об'єкт із кореневим елементом.");

        XElement rootElement;
        if (root.Count == 1)
        {
            var first = root.First();
            rootElement = CreateElement(first.Key, first.Value);
        }
        else
        {
            rootElement = new XElement("root");
            foreach (var item in root)
                rootElement.Add(CreateElement(item.Key, item.Value));
        }

        return new XDocument(new XDeclaration("1.0", "utf-8", null), rootElement)
            .ToString();
    }

    private static XElement CreateElement(string name, JsonNode? node)
    {
        if (node is JsonObject obj)
        {
            var element = new XElement(name);
            foreach (var item in obj)
            {
                if (item.Key == "#text")
                    element.Add(new XText(item.Value?.ToString() ?? string.Empty));
                else if (item.Key.StartsWith("@", StringComparison.Ordinal))
                    element.SetAttributeValue(item.Key[1..], item.Value?.ToString());
                else
                    element.Add(CreateElement(item.Key, item.Value));
            }
            return element;
        }

        if (node is JsonArray array)
        {
            var wrapper = new XElement(name);
            foreach (var item in array)
                wrapper.Add(CreateElement("item", item));
            return wrapper;
        }

        return new XElement(name, node?.ToString() ?? string.Empty);
    }
}
