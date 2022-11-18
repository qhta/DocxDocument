namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the MovieReference Class.
/// </summary>
public interface IMovieReference // : DocumentFormat.OpenXml.Wordprocessing.RelationshipType
{
  /// <summary>
  /// Relationship to Part
  /// </summary>
  public string? Id { get ; set; }
  
}
