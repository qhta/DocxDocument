namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the numbering rule to apply.
/// </summary>
public enum WdNumberingRule
{
  /// <summary>
  /// Numbers are assigned continuously.
  /// </summary>
  Continuous = 0,
  /// <summary>
  /// Numbers are reset for each section.
  /// </summary>
  Section = 1,
  /// <summary>
  /// Numbers are reset for each page.
  /// </summary>
  Page = 2
}
