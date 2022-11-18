namespace DocumentModel.Wordprocessing;

/// <summary>
/// Data Source File Path.
/// </summary>
public interface IDataSourceReference // : DocumentFormat.OpenXml.Wordprocessing.RelationshipType
{
  /// <summary>
  /// Relationship to Part
  /// </summary>
  public string? Id { get ; set; }
  
}
