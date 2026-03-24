namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the formatting for indexes in a document.
/// </summary>
public enum WdIndexFormat
{
  /// <summary>
  /// From template.
  /// </summary>
  Template = unchecked((int)0),
  /// <summary>
  /// Classic.
  /// </summary>
  Classic = unchecked((int)1),
  /// <summary>
  /// Fancy.
  /// </summary>
  Fancy = unchecked((int)2),
  /// <summary>
  /// Modern.
  /// </summary>
  Modern = unchecked((int)3),
  /// <summary>
  /// Bulleted.
  /// </summary>
  Bulleted = unchecked((int)4),
  /// <summary>
  /// Formal.
  /// </summary>
  Formal = unchecked((int)5),
  /// <summary>
  /// Simple.
  /// </summary>
  Simple = unchecked((int)6)
}
