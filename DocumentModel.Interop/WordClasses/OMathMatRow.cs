namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents a matrix row. The OMathMatRow is a member of the OMathMatRows collection.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathmatrow?view=word-pia"/>
public partial class OMathMatRow : InteropObject
{
  /// <summary>
  /// Returns the collection of arguments in the matrix row.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathmatrow.args?view=word-pia"/>
  public OMathArgs Args { get; set; }

  /// <summary>
  /// Returns the index number of the matrix row.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathmatrow.rowindex?view=word-pia"/>
  public int RowIndex { get; set; }


  #region methods

/// <summary>
  /// Deletes the specified matrix row.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathmatrow.delete?view=word-pia"/>
  public void Delete() { throw new NotImplementedException(); }

  #endregion methods
}
