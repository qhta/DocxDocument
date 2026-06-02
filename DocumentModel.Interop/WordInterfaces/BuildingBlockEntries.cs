namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents a collection of all BuildingBlock objects in a template.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.buildingblockentries?view=word-pia"/>
public partial interface IBuildingBlockEntries : IInteropCollection<BuildingBlock>
{
}
