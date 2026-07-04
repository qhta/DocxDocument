namespace DocumentModel.Wordprocessing;
/// <summary>
///   Interface for external file relationship in a WordprocessingML document, providing logic for managing and synchronizing external file URIs and relationship IDs with the Open XML package.
/// </summary>
public interface IExternalFile : IRelationshipType
{

  /// <summary>
  ///   The URI string of the relationship target (external resource).
  /// </summary>
  public string? Uri { get; set; }

}