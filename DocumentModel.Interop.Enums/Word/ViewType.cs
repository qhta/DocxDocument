namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the view type.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdviewtype?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType("WdViewType")]
public enum ViewType
{
  /// <summary>
  /// A normal view.
  /// </summary>
  [WordInteropEnumValue("wdNormalView")]
  NormalView = 1,
  /// <summary>
  /// An outline view.
  /// </summary>
  [WordInteropEnumValue("wdOutlineView")]
  OutlineView = 2,
  /// <summary>
  /// A print view.
  /// </summary>
  [WordInteropEnumValue("wdPrintView")]
  PrintView = 3,
  /// <summary>
  /// A print preview view.
  /// </summary>
  [WordInteropEnumValue("wdPrintPreview")]
  PrintPreview = 4,
  /// <summary>
  /// A master view.
  /// </summary>
  [WordInteropEnumValue("wdMasterView")]
  MasterView = 5,
  /// <summary>
  /// A Web view.
  /// </summary>
  [WordInteropEnumValue("wdWebView")]
  WebView = 6,
  /// <summary>
  /// A reading view.
  /// </summary>
  [WordInteropEnumValue("wdReadingView")]
  ReadingView = 7,
  /// <summary>
  /// No description is available.
  /// </summary>
  [WordInteropEnumValue("wdConflictView")]
  ConflictView = 8
}
