namespace DocumentModel.Wordprocessing;
/// <summary>
///   Relationship for external file.
/// </summary>
public interface IExternalFile: IRelationshipType
{
  /// <summary>
  /// Filename
  /// </summary>
  public Uri? Uri { get;set; }
}