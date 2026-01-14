namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents a relationship to an external file in a WordprocessingML document.
/// This interface extends <see cref="RelationshipType"/> and provides a property for the file UriString, enabling advanced linking and integration of external resources such as templates, images, or data files within the document.
/// </summary>
public class ExternalFile: ModelElement
{

  /// <summary>
  /// UriString of the external file, specifying the location or filename of the linked resource.
  /// </summary>
  public string? Uri{ get; set; }
}