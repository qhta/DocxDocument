namespace DocumentModel.Interop.Word;	
/// <summary>
/// Represents a matrix column. The OMathMatCol object is a member of the OMathMatCols collection.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathmatcol?view=word-pia"/>
public interface IMathMatCol : IInteropObject
{
  /// <summary>
  /// Returns the collection of arguments in the matrix column.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathmatcol.args?view=word-pia"/>
  public IMathArgs Args { get; }	
  /// <summary>
  /// Returns the index number of the matrix column.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathmatcol.colindex?view=word-pia"/>
  public int ColIndex { get; }	
  /// <summary>
  /// Returns or sets the horizontal alignment of the matrix column.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathmatcol.align?view=word-pia"/>
  public MathHorizAlignType Align { get; set; }	

  #region methods	
/// <summary>
  /// Deletes the specified matrix column.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathmatcol.delete?view=word-pia"/>
  public void Delete();	
  #endregion methods
}	
