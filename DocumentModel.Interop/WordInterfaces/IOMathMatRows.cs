namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents the collection of matrix rows.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathmatrows?view=word-pia"/>
public interface IOMathMatRows : IInteropObject, IInteropCollection<OMathMatRow>
{


  #region methods

/// <summary>
  /// Adds a matrix row to the collection.
  /// </summary>
  /// <param name="BeforeRow">Specifies the row before which the new row is inserted.</param>
  /// <returns>The added matrix row object.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathmatrows.add?view=word-pia"/>
  public OMathMatRow Add(object BeforeRow);

  #endregion methods
}
