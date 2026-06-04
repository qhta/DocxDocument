namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the view type.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdviewtype?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType(typeof(Microsoft.Office.Interop.Word.WdViewType))]
public enum ViewType
{
  /// <summary>
  /// A normal view.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdViewType.wdNormalView))]
  NormalView = 1,
  /// <summary>
  /// An outline view.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdViewType.wdOutlineView))]
  OutlineView = 2,
  /// <summary>
  /// A print view.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdViewType.wdPrintView))]
  PrintView = 3,
  /// <summary>
  /// A print preview view.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdViewType.wdPrintPreview))]
  PrintPreview = 4,
  /// <summary>
  /// A master view.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdViewType.wdMasterView))]
  MasterView = 5,
  /// <summary>
  /// A Web view.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdViewType.wdWebView))]
  WebView = 6,
  /// <summary>
  /// A reading view.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdViewType.wdReadingView))]
  ReadingView = 7,
  /// <summary>
  /// No description is available.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdViewType.wdConflictView))]
  ConflictView = 8
}
