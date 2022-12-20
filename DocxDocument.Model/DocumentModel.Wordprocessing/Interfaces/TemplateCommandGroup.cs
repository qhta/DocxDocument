namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the TemplateCommandGroup Class.
/// </summary>
public partial interface TemplateCommandGroup
{
  /// <summary>
  /// Gets the CustomizationPart associated with this element.
  /// </summary>
  public DocumentModel.Packaging.CustomizationPart? CustomizationPart { get; set; }
  
  public Collection<DocumentModel.Wordprocessing.KeyMapCustomizations>? KeyMapCustomizationses { get; set; }
  
  public Collection<DocumentModel.Wordprocessing.MismatchedKeyMapCustomization>? MismatchedKeyMapCustomizations { get; set; }
  
  public DocumentModel.Wordprocessing.Toolbars? Toolbars { get; set; }
  
  public Collection<DocumentModel.Wordprocessing.AllocatedCommands>? AllocatedCommandses { get; set; }
  
}
