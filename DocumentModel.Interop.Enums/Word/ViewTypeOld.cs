namespace DocumentModel.Interop.Word;

/// <summary>
/// Reserved for internal use.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdviewtypeold?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType("WdViewTypeOld")]
public enum ViewTypeOld
{
  /// <summary>
  /// No description is available.
  /// </summary>
  [WordInteropEnumValue("wdPageView")]
  PageView = 3,
  /// <summary>
  /// No description is available.
  /// </summary>
  [WordInteropEnumValue("wdOnlineView")]
  OnlineView = 6
}
