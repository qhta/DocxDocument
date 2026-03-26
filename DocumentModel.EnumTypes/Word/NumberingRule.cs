namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the numbering rule to apply.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdnumberingrule?view=office-pia` for Office interop details.
/// </remarks>
public enum NumberingRule
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
