namespace XmlJsonAdapterApp;

public class XmlJsonAdapter : IDataAdapter
{
    public string XmlToJson(string xml)
    {
        XmlDocument document = XmlDocument.Read(xml);
        return document.ToJson();
    }

    public string JsonToXml(string json)
    {
        JsonDocument document = JsonDocument.Read(json);
        return document.ToXml();
    }
}
