namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents a collection of BuildingBlock objects for a specific building block type and category in a template.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.buildingblocks?view=word-pia"/>
public partial class BuildingBlocks : InteropCollection<BuildingBlock>
{


  #region methods

/// <summary>
  /// Returns a building block from the collection by index or name.
  /// </summary>
  /// <param name="Index">The numeric index or name of the building block.</param>
  /// <returns>The requested <see cref="BuildingBlock"/> object.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.buildingblocks.item?view=word-pia"/>
  public BuildingBlock Item(object Index) { throw new NotImplementedException(); }

  #endregion methods
}
