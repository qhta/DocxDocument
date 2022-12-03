namespace DocumentModel.Wordprocessing;

/// <summary>
/// Default Properties for VML Objects in Main Document.
/// </summary>
public interface ShapeDefaults // : DocumentModel.BaseTypes.ModelElement
{
  public Collection<DocumentModel.Vml.ShapeDefaults>? ShapeDefaultses { get ; set; }
  
  public Collection<DocumentModel.Vml.ShapeLayout>? ShapeLayouts { get ; set; }
  
}
