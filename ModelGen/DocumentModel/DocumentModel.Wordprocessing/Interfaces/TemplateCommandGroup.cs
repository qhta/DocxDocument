namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the TemplateCommandGroup Class.
/// </summary>
public interface TemplateCommandGroup
{
  public Collection<KeyMapCustomizations>? KeyMapCustomizationses { get ; set; }
  
  public Collection<MismatchedKeyMapCustomization>? MismatchedKeyMapCustomizations { get ; set; }
  
  public Toolbars? Toolbars { get ; set; }
  
  public Collection<AllocatedCommands>? AllocatedCommandses { get ; set; }
  
}
