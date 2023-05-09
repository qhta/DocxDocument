namespace DocumentModel.Wordprocessing;

/// <summary>
///   Relationship for external file.
/// </summary>
public class ExternalFile: RelationshipType
{
  /// <summary>
  /// Filename
  /// </summary>
  public Uri? Uri { get;set; }
}