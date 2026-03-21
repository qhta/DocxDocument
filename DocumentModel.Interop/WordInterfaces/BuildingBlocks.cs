namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents a collection of BuildingBlock objects for a specific building block type and category in a template.
/// </summary>
/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.buildingblocks?view=word-pia"/>
public partial interface BuildingBlocks : InteropObject
{
  /// <summary>
  /// The count.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.buildingblocks.count?view=word-pia"/>
  public int Count { get; }
}
