namespace DocxDocument.Model;

[JsonConverter(typeof(StringEnumConverter))]
public enum MultilevelType
{
  Single,
  Multi,
  Hybrid
}