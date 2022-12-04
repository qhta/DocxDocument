namespace DocumentModel.Packaging;

/// <summary>
/// Defines the CustomizationPart
/// </summary>
public class CustomizationPart: DocumentModel.Packaging.OpenXmlPartContainer
{
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  public DocumentModel.Wordprocessing.TemplateCommandGroup? TemplateCommandGroup
  {
    get;
    set;
  }
  
}
