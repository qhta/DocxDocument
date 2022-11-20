namespace DocumentModel.Wordprocessing;

/// <summary>
/// Attached Document Template.
/// </summary>
public interface IAttachedTemplate // : DocumentFormat.OpenXml.Wordprocessing.RelationshipType
{
  /// <summary>
  /// Relationship to Part
  /// </summary>
  public string? Id { get ; set; }
  
}
