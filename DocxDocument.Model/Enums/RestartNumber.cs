namespace DocxDocument.Model;

[JsonConverter(typeof(StringEnumConverter))]
public enum RestartNumber
{
    Continuous,
    EachSection,
    EachPage,
}