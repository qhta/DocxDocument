namespace DocumentModel.Interop.Word;

/// <summary>
/// Reserved for internal use.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdpagenumberstylehid?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType("WdPageNumberStyleHID")]
public enum PageNumberStyleHID
{
  /// <summary>
  /// No description is available.
  /// </summary>
  [WordInteropEnumValue("emptyenum")]
  emptyenum = 0
}
