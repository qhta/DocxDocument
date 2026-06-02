namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents the collection of matrix columns.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathmatcols?view=word-pia"/>
public partial class OMathMatCols : InteropCollection<OMathMatCol>
{


  #region methods

/// <summary>
  /// Adds a matrix column to the collection.
  /// </summary>
  /// <param name="BeforeCol">Specifies the column before which the new column is inserted.</param>
  /// <returns>The added matrix column object.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathmatcols.add?view=word-pia"/>
  public OMathMatCol Add(object BeforeCol) { throw new NotImplementedException(); }

  #endregion methods
}
