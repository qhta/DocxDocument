namespace DocumentModel.Presentation;

/// <summary>
/// List of controls.
/// </summary>
public interface IControlList // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public System.Collections.ObjectModel.Collection<DocumentModel.Presentation.IControl>? Controls { get ; set; }
  
}
