namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the numbering rule to apply.
/// </summary>
public enum WdNumberingRule
{
  /// <summary>
  /// Numbers are assigned continuously.
  /// </summary>
  wdRestartContinuous = unchecked((int)0),
  /// <summary>
  /// Numbers are reset for each section.
  /// </summary>
  wdRestartSection = unchecked((int)1),
  /// <summary>
  /// Numbers are reset for each page.
  /// </summary>
  wdRestartPage = unchecked((int)2)
}
