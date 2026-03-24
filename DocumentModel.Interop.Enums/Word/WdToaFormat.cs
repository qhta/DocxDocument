namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the type of formatting to apply to the table of authorities in the active document.
/// </summary>
public enum WdToaFormat
{
  /// <summary>
  /// Template formatting.
  /// </summary>
  Template = 0,
  /// <summary>
  /// Classic formatting.
  /// </summary>
  Classic = 1,
  /// <summary>
  /// Distinctive formatting.
  /// </summary>
  Distinctive = 2,
  /// <summary>
  /// Formal formatting.
  /// </summary>
  Formal = 3,
  /// <summary>
  /// Simple formatting.
  /// </summary>
  Simple = 4
}
