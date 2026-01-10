using DocumentModel.Wordprocessing;

namespace DocumentModel.Packaging;

/// <summary>
///   Defines the CustomizationPart
/// </summary>
public class CustomizationPart
{
  public String? ContentType { get; set; }

  public String? RelationshipType { get; set; }

  /// <summary>
  ///   Gets or sets the root element of this part.
  /// </summary>
  public TemplateCommandGroup? TemplateCommandGroup { get; set; }
}