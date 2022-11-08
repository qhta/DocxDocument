namespace DocxDocument.Model;

[JsonConverter(typeof(StringEnumConverter))]
public enum EndnotePosition
{
    SectionEnd,
    DocumentEnd,
}