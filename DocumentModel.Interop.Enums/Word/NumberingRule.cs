namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the numbering rule to apply.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdnumberingrule?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType("WdNumberingRule")]
public enum NumberingRule
{
  /// <summary>
  /// Numbers are assigned continuously.
  /// </summary>
  [WordInteropEnumValue("wdRestartContinuous")]
  Continuous = 0,
  /// <summary>
  /// Numbers are reset for each section.
  /// </summary>
  [WordInteropEnumValue("wdRestartSection")]
  Section = 1,
  /// <summary>
  /// Numbers are reset for each page.
  /// </summary>
  [WordInteropEnumValue("wdRestartPage")]
  Page = 2
}
