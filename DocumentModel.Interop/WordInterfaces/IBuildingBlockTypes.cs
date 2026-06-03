namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents a collection of BuildingBlockType objects.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.buildingblocktypes?view=word-pia"/>
public interface IBuildingBlockTypes : IInteropCollection<IBuildingBlockType>
{


  #region methods

/// <summary>
  /// Returns a building block type from the collection.
  /// </summary>
  /// <param name="Index">A <see cref="IBuildingBlockTypes"/> value that identifies the building block type.</param>
  /// <returns>The requested <see cref="IBuildingBlockType"/> object.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.buildingblocktypes.item?view=word-pia"/>
  public IBuildingBlockType Item(IBuildingBlockTypes Index);

  #endregion methods
}
