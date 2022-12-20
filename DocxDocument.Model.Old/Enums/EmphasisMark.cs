namespace DocxDocument.Model;

[JsonConverter(typeof(StringEnumConverter))]
public enum EmphasisMark
{
  None,
  OverSolidCircle,
  OverComma,
  OverWhiteCircle,
  UnderSolidCircle,
}