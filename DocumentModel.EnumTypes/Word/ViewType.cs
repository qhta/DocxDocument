namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the view type.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdviewtype?view=office-pia` for Office interop details.
/// </remarks>
public enum ViewType
{
  /// <summary>
  /// A normal view.
  /// </summary>
  NormalView = 1,
  /// <summary>
  /// An outline view.
  /// </summary>
  OutlineView = 2,
  /// <summary>
  /// A print view.
  /// </summary>
  PrintView = 3,
  /// <summary>
  /// A print preview view.
  /// </summary>
  PrintPreview = 4,
  /// <summary>
  /// A master view.
  /// </summary>
  MasterView = 5,
  /// <summary>
  /// A Web view.
  /// </summary>
  WebView = 6,
  /// <summary>
  /// A reading view.
  /// </summary>
  ReadingView = 7,
  /// <summary>
  /// No description is available.
  /// </summary>
  ConflictView = 8
}
