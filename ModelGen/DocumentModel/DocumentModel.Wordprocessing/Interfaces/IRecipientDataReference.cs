namespace DocumentModel.Wordprocessing;

/// <summary>
/// Reference to Inclusion/Exclusion Data for Data Source.
/// </summary>
public interface IRecipientDataReference // : DocumentFormat.OpenXml.Wordprocessing.RelationshipType
{
  /// <summary>
  /// Relationship to Part
  /// </summary>
  public string? Id { get ; set; }
  
}
