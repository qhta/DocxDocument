namespace DocumentModel.Wordprocessing;

/// <summary>
///   Relationship Ifor external file.
/// </summary>
public class ExternalFile: RelationshipType
{
  /// <summary>
  /// Filename
  /// </summary>
  public Uri? Uri { get;set; }
}
