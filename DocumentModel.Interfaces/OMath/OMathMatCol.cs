namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents a matrix column. The OMathMatCol object is a member of the OMathMatCols collection.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathmatcol?view=word-pia"/>
public partial interface OMathMatCol : IModelObject
{
  /// <summary>
  /// Returns the collection of arguments in the matrix column.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathmatcol.args?view=word-pia"/>
  public OMathArgs Args { get; }

  /// <summary>
  /// Returns the index number of the matrix column.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathmatcol.colindex?view=word-pia"/>
  public int ColIndex { get; }

  /// <summary>
  /// Returns or sets the horizontal alignment of the matrix column.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathmatcol.align?view=word-pia"/>
  public OMathHorizAlignType Align { get; set; }
}
