namespace DocumentModel.Presentation;

/// <summary>
/// List of controls.
/// </summary>
public interface IControlList // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public Collection<IControl>? Controls { get ; set; }
  
}
