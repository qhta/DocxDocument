namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents a matrix row. The OMathMatRow is a member of the OMathMatRows collection.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathmatrow?view=word-pia"/>
public partial interface IOMathMatRow : IInteropObject
{
  /// <summary>
  /// Returns the collection of arguments in the matrix row.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathmatrow.args?view=word-pia"/>
  public OMathArgs Args { get; }

  /// <summary>
  /// Returns the index number of the matrix row.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathmatrow.rowindex?view=word-pia"/>
  public int RowIndex { get; }
}
