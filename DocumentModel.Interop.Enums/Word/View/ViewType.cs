namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the view type.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdviewtype?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Interop.Word.WdViewType")]
public enum ViewType
{
  /// <summary>
  /// A normal view.
  /// </summary>
  [InteropEnumValue("wdNormalView")]
  NormalView = 1,
  /// <summary>
  /// An outline view.
  /// </summary>
  [InteropEnumValue("wdOutlineView")]
  OutlineView = 2,
  /// <summary>
  /// A print view.
  /// </summary>
  [InteropEnumValue("wdPrintView")]
  PrintView = 3,
  /// <summary>
  /// A print preview view.
  /// </summary>
  [InteropEnumValue("wdPrintPreview")]
  PrintPreview = 4,
  /// <summary>
  /// A master view.
  /// </summary>
  [InteropEnumValue("wdMasterView")]
  MasterView = 5,
  /// <summary>
  /// A Web view.
  /// </summary>
  [InteropEnumValue("wdWebView")]
  WebView = 6,
  /// <summary>
  /// A reading view.
  /// </summary>
  [InteropEnumValue("wdReadingView")]
  ReadingView = 7,
  /// <summary>
  /// No description is available.
  /// </summary>
  [InteropEnumValue("wdConflictView")]
  ConflictView = 8
}
