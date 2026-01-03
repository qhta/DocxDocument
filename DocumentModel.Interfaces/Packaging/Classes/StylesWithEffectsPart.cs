namespace DocumentModel.Packaging;

/// <summary>
///   Defines the StylesWithEffectsPart
/// </summary>
public interface StylesWithEffectsPart: IModelElement
{
  public string? ContentType { get; set; }
  public string? RelationshipType { get; set; }
}