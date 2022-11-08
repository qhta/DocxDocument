namespace DocxDocument.Model;

[JsonConverter(typeof(StringEnumConverter))]
public enum CaptionPosition
{
  Above = 0,
  Below = 1,
}