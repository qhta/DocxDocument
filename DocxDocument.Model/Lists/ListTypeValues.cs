namespace DocxDocument.Model;

[JsonConverter(typeof(StringEnumConverter))]
public enum ListType
{
  None,
  Bulleted,
  Numbered,
}