namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents a collection of all BuildingBlock objects in a template.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.buildingblockentries?view=word-pia"/>
public interface IBuildingBlockEntries : IInteropCollection<IBuildingBlock>
{


  #region methods

/// <summary>
  /// Returns a building block from the collection by index or name.
  /// </summary>
  /// <param name="index">The numeric index or name of the building block.</param>
  /// <returns>The requested <see cref="IBuildingBlock"/> object.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.buildingblockentries.item?view=word-pia"/>
  public IBuildingBlock Item(object index);

  #endregion methods
}
