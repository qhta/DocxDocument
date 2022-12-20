namespace DocxDocument.Model;

[JsonConverter(typeof(StringEnumConverter))]
public enum DocView
{
  None,
  Print,
  Outline,
  MasterPages,
  Normal,
  Web
}