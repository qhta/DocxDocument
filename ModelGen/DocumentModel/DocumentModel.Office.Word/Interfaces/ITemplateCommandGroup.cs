namespace DocumentModel.Office.Word;

/// <summary>
/// Defines the TemplateCommandGroup Class.
/// </summary>
public interface ITemplateCommandGroup // : DocumentModel.ITypedOpenXmlPartRootElement
{
  public System.Collections.ObjectModel.Collection<DocumentModel.Office.Word.IKeyMapCustomizations>? KeyMapCustomizationses { get ; set; }
  
  public System.Collections.ObjectModel.Collection<DocumentModel.Office.Word.IMismatchedKeyMapCustomization>? MismatchedKeyMapCustomizations { get ; set; }
  
  public DocumentModel.Office.Word.IToolbars? Toolbars { get ; set; }
  
  public System.Collections.ObjectModel.Collection<DocumentModel.Office.Word.IAllocatedCommands>? AllocatedCommandses { get ; set; }
  
}
