namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the TemplateCommandGroup Class.
/// </summary>
public interface ITemplateCommandGroup // : DocumentModel.ITypedOpenXmlPartRootElement
{
  public System.Collections.ObjectModel.Collection<DocumentModel.Wordprocessing.IKeyMapCustomizations>? KeyMapCustomizationses { get ; set; }
  
  public System.Collections.ObjectModel.Collection<DocumentModel.Wordprocessing.IMismatchedKeyMapCustomization>? MismatchedKeyMapCustomizations { get ; set; }
  
  public DocumentModel.Wordprocessing.IToolbars? Toolbars { get ; set; }
  
  public System.Collections.ObjectModel.Collection<DocumentModel.Wordprocessing.IAllocatedCommands>? AllocatedCommandses { get ; set; }
  
}
