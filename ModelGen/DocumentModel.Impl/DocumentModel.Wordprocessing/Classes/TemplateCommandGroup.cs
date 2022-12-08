namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the TemplateCommandGroup Class.
/// </summary>
public class TemplateCommandGroupImpl: ModelElementImpl, TemplateCommandGroup
{
  public DocumentFormat.OpenXml.Office.Word.TemplateCommandGroup? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office.Word.TemplateCommandGroup?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public Collection<KeyMapCustomizations>? KeyMapCustomizationses
  {
    get;
    set;
  }
  
  public Collection<MismatchedKeyMapCustomization>? MismatchedKeyMapCustomizations
  {
    get;
    set;
  }
  
  public Toolbars? Toolbars
  {
    get;
    set;
  }
  
  public Collection<AllocatedCommands>? AllocatedCommandses
  {
    get;
    set;
  }
  
}
