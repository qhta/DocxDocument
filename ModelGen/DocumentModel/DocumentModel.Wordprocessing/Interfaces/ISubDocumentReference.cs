namespace DocumentModel.Wordprocessing;

/// <summary>
/// Anchor for Subdocument Location.
/// </summary>
public interface ISubDocumentReference // : DocumentFormat.OpenXml.Wordprocessing.RelationshipType
{
  /// <summary>
  /// Relationship to Part
  /// </summary>
  public string? Id { get ; set; }
  
}
