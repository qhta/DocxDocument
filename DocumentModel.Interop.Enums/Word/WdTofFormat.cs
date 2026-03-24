namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the type of formatting to apply to the table of figures in the active document.
/// </summary>
public enum WdTofFormat
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
  /// Centered formatting.
  /// </summary>
  Centered = unchecked((int)3),
  /// <summary>
  /// Formal formatting.
  /// </summary>
  Formal = unchecked((int)4),
  /// <summary>
  /// Simple formatting.
  /// </summary>
  Simple = unchecked((int)5)
}
