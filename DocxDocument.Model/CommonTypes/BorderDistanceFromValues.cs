namespace DocxDocument.Model;

/// <summary>
/// Specifies whether a page border is measured from the edge of the page or from the text it surrounds.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum BorderDistanceFrom
{
  Text,
  PageEdge,
}