namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies how Word displays the reading order and alignment for the specified sections.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdsectiondirection?view=office-pia` for Office interop details.
/// </remarks>
public enum WdSectionDirection
{
  /// <summary>
  /// Specifies how Word displays the reading order and alignment for the specified sections.
  /// </summary>
  Rtl = 0,
  /// <summary>
  /// Displays the section with left alignment and left-to-right reading order.
  /// </summary>
  Ltr = 1
}
