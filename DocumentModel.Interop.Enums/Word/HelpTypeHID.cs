namespace DocumentModel.Interop.Word;

/// <summary>
/// Reserved for internal use.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdhelptypehid?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType("WdHelpTypeHID")]
public enum HelpTypeHID
{
  /// <summary>
  /// No description is available.
  /// </summary>
  [WordInteropEnumValue("emptyenum")]
  emptyenum = 0
}
