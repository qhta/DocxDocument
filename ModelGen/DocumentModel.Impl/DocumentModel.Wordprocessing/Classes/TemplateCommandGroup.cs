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
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public Collection<MismatchedKeyMapCustomization>? MismatchedKeyMapCustomizations
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public Toolbars? Toolbars
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public Collection<AllocatedCommands>? AllocatedCommandses
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
