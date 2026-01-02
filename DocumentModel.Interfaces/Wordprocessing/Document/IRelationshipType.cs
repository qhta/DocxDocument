namespace DocumentModel.Wordprocessing;
/// <summary>
///   Identified relationship type
/// </summary>
public interface IRelationshipType: IModelElement
{
  /// <summary>
  ///   Relationship to Part
  /// </summary>
  public string? Id { get; set; }
}