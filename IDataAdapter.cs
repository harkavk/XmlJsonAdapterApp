namespace XmlJsonAdapterApp;

public interface IDataAdapter
{
    string XmlToJson(string xml);
    string JsonToXml(string json);
}
