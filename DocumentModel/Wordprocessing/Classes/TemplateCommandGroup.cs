namespace DocumentModel.Wordprocessing;

/// <summary>
///   Defines the TemplateCommandGroup Class.
/// </summary>
public class TemplateCommandGroup
{
  public Collection<KeyMapCustomizations>? KeyMapCustomizations { get; set; }

  public Collection<MismatchedKeyMapCustomization>? MismatchedKeyMapCustomizations { get; set; }

  public Toolbars? Toolbars { get; set; }

  public Collection<AllocatedCommands>? AllocatedCommands { get; set; }
}