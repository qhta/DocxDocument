namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the TemplateCommandGroup Class.
/// </summary>
public interface ITemplateCommandGroup // : DocumentModel.ITypedOpenXmlPartRootElement
{
  public Collection<IKeyMapCustomizations>? KeyMapCustomizationses { get ; set; }
  
  public Collection<IMismatchedKeyMapCustomization>? MismatchedKeyMapCustomizations { get ; set; }
  
  public IToolbars? Toolbars { get ; set; }
  
  public Collection<IAllocatedCommands>? AllocatedCommandses { get ; set; }
  
}
