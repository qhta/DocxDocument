namespace DocumentModel.Wordprocessing;

/// <summary>
/// Default Properties for VML Objects in Main Document.
/// </summary>
public interface IShapeDefaults // : DocumentModel.Wordprocessing.IShapeDefaultsType
{
  public Collection<DocumentModel.Vml.IShapeDefaults>? ShapeDefaultses { get ; set; }
  
  public Collection<DocumentModel.Vml.IShapeLayout>? ShapeLayouts { get ; set; }
  
}
