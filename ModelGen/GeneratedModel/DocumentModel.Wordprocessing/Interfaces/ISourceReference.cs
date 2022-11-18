namespace DocumentModel.Wordprocessing;

/// <summary>
/// ODSO Data Source File Path.
/// </summary>
public interface ISourceReference // : DocumentFormat.OpenXml.Wordprocessing.RelationshipType
{
  /// <summary>
  /// Relationship to Part
  /// </summary>
  public string? Id { get ; set; }
  
}
