namespace DocumentModel.Wordprocessing;

/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.buildingblock?view=word-pia"/>
public partial interface IBuildingBlock : IModelObject
{
  /// <summary>
  /// Deletes the specified building block.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.buildingblock.delete?view=word-pia"/>
  public void Delete();
}
