namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the type of index.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdindextype?view=office-pia` for Office interop details.
/// </remarks>
public enum IndexType
{
  /// <summary>
  /// An indented index.
  /// </summary>
  Indent = 0,
  /// <summary>
  /// A run-in index.
  /// </summary>
  Runin = 1
}
