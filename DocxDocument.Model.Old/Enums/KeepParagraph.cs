namespace DocxDocument.Model;

[JsonConverter(typeof(StringEnumConverter))]
public enum KeepParagraph
{
  Auto,
  Always,
}