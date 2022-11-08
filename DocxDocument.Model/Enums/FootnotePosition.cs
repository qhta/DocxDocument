namespace DocxDocument.Model;

[JsonConverter(typeof(StringEnumConverter))]
public enum FootnotePosition
{
    PageBottom,
    BeneathText,
    SectionEnd,
}