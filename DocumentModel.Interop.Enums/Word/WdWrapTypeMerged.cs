namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies how Microsoft Word wraps text around pictures.
/// </summary>
public enum WdWrapTypeMerged
{
  /// <summary>
  /// In line with text.
  /// </summary>
  Inline = 0,
  /// <summary>
  /// Square.
  /// </summary>
  Square = 1,
  /// <summary>
  /// Tight.
  /// </summary>
  Tight = 2,
  /// <summary>
  /// Behind text.
  /// </summary>
  Behind = 3,
  /// <summary>
  /// In front of text.
  /// </summary>
  Front = 4,
  /// <summary>
  /// Through.
  /// </summary>
  Through = 5,
  /// <summary>
  /// Top and bottom.
  /// </summary>
  TopBottom = 6
}
