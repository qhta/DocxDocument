namespace DocumentModel.Wordprocessing.Drawings;

/// <summary>
/// Specifies the line cap style options for drawing lines in WordprocessingML documents.
/// This enumeration provides values for different line cap shapes, supporting advanced graphical rendering and customization of line endings in document drawings.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum LineCapKind
{

  /// <summary>
  /// Round line cap.
  /// </summary>
  Round,

  /// <summary>
  /// Square line cap.
  /// </summary>
  Square,

  /// <summary>
  /// Flat line cap.
  /// </summary>
  Flat
}