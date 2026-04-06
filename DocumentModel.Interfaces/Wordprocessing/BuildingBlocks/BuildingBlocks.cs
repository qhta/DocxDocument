namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents a collection of BuildingBlock objects for a specific building block type and category in a template.
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.buildingblocks?view=word-pia"/>
public partial interface IBuildingBlocks : IModelCollection<IBuildingBlock>
{
}
