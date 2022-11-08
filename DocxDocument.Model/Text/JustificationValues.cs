namespace DocxDocument.Model;

[JsonConverter(typeof(StringEnumConverter))]
public enum Justification
{
  /// <summary>
  /// Justify text to the left edge of the paragraph.
  /// </summary>
  Left = 0,
  /// <summary>
  /// Justify text to the midpoint betweeb right and left edge of the paragraph.
  /// </summary>
  Center,
  /// <summary>
  /// Justify text to the left right of the paragraph.
  /// </summary>
  Right,
  /// <summary>
  /// Justify text to the left and right edge of the paragraph.
  /// </summary>
  Justified,
  /// <summary>
  /// Justify text to the left edge of the paragraph for the left-to-right languages,
  /// and to the right edge for the right to left languages,
  /// </summary>
  Start,
  /// <summary>
  /// Justify text to the right edge of the paragraph for the left-to-right languages,
  /// and to the left edge for the right to left languages,
  /// </summary>
  End,
}