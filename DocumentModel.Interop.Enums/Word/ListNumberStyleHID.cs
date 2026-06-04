namespace DocumentModel.Interop.Word;

/// <summary>
/// Reserved for internal use.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.word.wdlistnumberstylehid?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType("WdListNumberStyleHID")]
public enum ListNumberStyleHID
{
  /// <summary>
  /// No description is available.
  /// </summary>
  [WordInteropEnumValue("emptyenum")]
  emptyenum = 0
}
