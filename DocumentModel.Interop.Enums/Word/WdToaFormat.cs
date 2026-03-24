namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the type of formatting to apply to the table of authorities in the active document.
/// </summary>
public enum WdToaFormat
{
  /// <summary>
  /// Template formatting.
  /// </summary>
  Template = unchecked((int)0),
  /// <summary>
  /// Classic formatting.
  /// </summary>
  Classic = unchecked((int)1),
  /// <summary>
  /// Distinctive formatting.
  /// </summary>
  Distinctive = unchecked((int)2),
  /// <summary>
  /// Formal formatting.
  /// </summary>
  Formal = unchecked((int)3),
  /// <summary>
  /// Simple formatting.
  /// </summary>
  Simple = unchecked((int)4)
}
