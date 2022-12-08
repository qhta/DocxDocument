namespace DocumentModel.Packaging;

/// <summary>
/// Defines the CustomizationPart
/// </summary>
public class CustomizationPartImpl: DocumentModel.Packaging.OpenXmlPartImpl, CustomizationPart
{
  public new DocumentFormat.OpenXml.Packaging.CustomizationPart? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Packaging.CustomizationPart?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public override String? ContentType
  {
    get;
    set;
  }
  
  public override String? RelationshipType
  {
    get;
    set;
  }
  
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  public DocumentModel.Wordprocessing.TemplateCommandGroup? TemplateCommandGroup
  {
    get;
    set;
  }
  
}
