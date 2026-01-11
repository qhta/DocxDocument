namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents a relationship to an external file in a WordprocessingML document.
/// This interface extends <see cref="RelationshipType"/> and provides a property for the file URI, enabling advanced linking and integration of external resources such as templates, images, or data files within the document.
/// </summary>
public interface ExternalFile : RelationshipType
{
  
  /// <summary>
  /// URI of the external file, specifying the location or filename of the linked resource.
  /// </summary>
  public Uri? Uri { get; set; }
}