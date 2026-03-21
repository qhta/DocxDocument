namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents a collection of BuildingBlockType objects.
/// </summary>
/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.buildingblocktypes?view=word-pia"/>
public partial interface BuildingBlockTypes : InteropObject
{
  /// <summary>
  /// The count.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.buildingblocktypes.count?view=word-pia"/>
  public int Count { get; }
}
