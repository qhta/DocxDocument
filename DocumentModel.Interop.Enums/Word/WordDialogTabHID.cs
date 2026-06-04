namespace DocumentModel.Interop.Word;

/// <summary>
/// Reserved for internal use.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.word.wdworddialogtabhid?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType("WdWordDialogTabHID")]
public enum WordDialogTabHID
{
  /// <summary>
  /// No description is available.
  /// </summary>
  [WordInteropEnumValue("wdDialogFilePageSetupTabPaperSize")]
  Size = 150001,
  /// <summary>
  /// No description is available.
  /// </summary>
  [WordInteropEnumValue("wdDialogFilePageSetupTabPaperSource")]
  Source = 150002
}
