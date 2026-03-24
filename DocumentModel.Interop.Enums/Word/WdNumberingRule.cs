namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the numbering rule to apply.
/// </summary>
public enum WdNumberingRule
{
  /// <summary>
  /// Numbers are assigned continuously.
  /// </summary>
  Continuous = unchecked((int)0),
  /// <summary>
  /// Numbers are reset for each section.
  /// </summary>
  Section = unchecked((int)1),
  /// <summary>
  /// Numbers are reset for each page.
  /// </summary>
  Page = unchecked((int)2)
}
