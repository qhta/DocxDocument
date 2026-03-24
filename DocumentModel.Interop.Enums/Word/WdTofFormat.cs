namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the type of formatting to apply to the table of figures in the active document.
/// </summary>
public enum WdTofFormat
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
  /// Centered formatting.
  /// </summary>
  Centered = 3,
  /// <summary>
  /// Formal formatting.
  /// </summary>
  Formal = 4,
  /// <summary>
  /// Simple formatting.
  /// </summary>
  Simple = 5
}
