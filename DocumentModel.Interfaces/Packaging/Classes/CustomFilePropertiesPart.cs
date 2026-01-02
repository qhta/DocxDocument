using DocumentModel;
namespace DocumentModel.Packaging;

/// <summary>
///   Defines the CustomFilePropertiesPart
/// </summary>
public class CustomFilePropertiesPart: ModelElement
{
  public string? ContentType { get; set; }
  /// <summary>
  ///   Gets or sets the root element of this part.
  /// </summary>
  public ICustomProperties? Properties { get; set; }
  public string? RelationshipType { get; set; }
}