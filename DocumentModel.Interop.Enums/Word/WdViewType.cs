namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the view type.
/// </summary>
public enum WdViewType
{
  /// <summary>
  /// A normal view.
  /// </summary>
  NormalView = unchecked((int)1),
  /// <summary>
  /// An outline view.
  /// </summary>
  OutlineView = unchecked((int)2),
  /// <summary>
  /// A print view.
  /// </summary>
  PrintView = unchecked((int)3),
  /// <summary>
  /// A print preview view.
  /// </summary>
  PrintPreview = unchecked((int)4),
  /// <summary>
  /// A master view.
  /// </summary>
  MasterView = unchecked((int)5),
  /// <summary>
  /// A Web view.
  /// </summary>
  WebView = unchecked((int)6),
  /// <summary>
  /// A reading view.
  /// </summary>
  ReadingView = unchecked((int)7),
  /// <summary>
  /// Applies to [System.Runtime.InteropServices.Guid("32FB36EF-2E57-345C-98BA-051FB07F8F6C")] public enum
  /// WdViewType ﾉ Expand table Product Versions Word primary interop assembly Latest
  /// </summary>
  ConflictView = unchecked((int)8)
}
