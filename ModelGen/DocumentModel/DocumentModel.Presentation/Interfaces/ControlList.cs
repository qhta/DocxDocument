namespace DocumentModel.Presentation;

/// <summary>
/// List of controls.
/// </summary>
public interface ControlList // : DocumentModel.BaseTypes.ModelElement
{
  public Collection<Control>? Controls { get ; set; }
  
}
