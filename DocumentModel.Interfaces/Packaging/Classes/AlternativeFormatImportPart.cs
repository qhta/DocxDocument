namespace DocumentModel.Packaging;

/// <summary>
///   Defines the AlternativeFormatImportPart
/// </summary>
public interface AlternativeFormatImportPart: IModelElement
{
  public string? RelationshipType { get; set; }
}