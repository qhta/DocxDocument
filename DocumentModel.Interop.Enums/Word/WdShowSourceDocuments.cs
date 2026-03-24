namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies how to display source documents when two documents are compared using the Word Compare functions.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdshowsourcedocuments?view=office-pia` for Office interop details.
/// </remarks>
public enum WdShowSourceDocuments
{
  /// <summary>
  /// Specifies how to display source documents when two documents are compared using the Word Compare functions.
  /// </summary>
  None = 0,
  /// <summary>
  /// Specifies how to display source documents when two documents are compared using the Word Compare functions.
  /// </summary>
  Original = 1,
  /// <summary>
  /// Specifies how to display source documents when two documents are compared using the Word Compare functions.
  /// </summary>
  Revised = 2,
  /// <summary>
  /// Specifies how to display source documents when two documents are compared using the Word Compare functions.
  /// </summary>
  Both = 3
}
