namespace DocxDocument.Model;

[JsonConverter(typeof(StringEnumConverter))]
public enum StyleType
{
  Paragraph = 1,
  Character = 2,
  Table = 3,
  List = 4,
  ParagraphOnly = 5,
  Linked = 6,
}