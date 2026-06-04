namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies how Word displays the reading order and alignment for the specified sections.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdsectiondirection?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType(typeof(Microsoft.Office.Interop.Word.WdSectionDirection))]
public enum SectionDirection
{
  /// <summary>
  /// Displays the section with right alignment and right-to-left reading order.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdSectionDirection.wdSectionDirectionRtl))]
  Rtl = 0,
  /// <summary>
  /// Displays the section with left alignment and left-to-right reading order.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdSectionDirection.wdSectionDirectionLtr))]
  Ltr = 1
}
