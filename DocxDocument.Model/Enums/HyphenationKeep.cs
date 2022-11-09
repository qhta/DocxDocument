namespace DocxDocument.Model;

[JsonConverter(typeof(StringEnumConverter))]
public enum HyphenationKeep
{
  Auto,
  Page,
}