namespace DocumentModel.Wordprocessing;

/// <summary>
/// Header Definition File Path.
/// </summary>
public interface IHeaderSource // : DocumentFormat.OpenXml.Wordprocessing.RelationshipType
{
  /// <summary>
  /// Relationship to Part
  /// </summary>
  public string? Id { get ; set; }
  
}
