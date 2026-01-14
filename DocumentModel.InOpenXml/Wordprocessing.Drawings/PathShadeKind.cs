namespace DocumentModel.Wordprocessing.Drawings;

/// <summary>
/// Specifies the path shading type options for graphical elements in WordprocessingML drawings.
/// This enumeration provides values for different shading paths, supporting advanced visual effects and gradient fills for shapes and graphical content within the document.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum PathShadeKind
{
  /// <summary>
  /// Shape path shading.
  /// </summary>
  Shape,

  /// <summary>
  /// Circle path shading.
  /// </summary>
  Circle,

  /// <summary>
  /// Rectangle path shading.
  /// </summary>
  Rect
}