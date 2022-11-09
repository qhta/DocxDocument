namespace DocxDocument.Model;

[JsonConverter(typeof(StringEnumConverter))]
public enum BreakAfterBefore
{
  Auto,
  Column,
  Page,
}