namespace DocumentModel.Wordprocessing;

/// <summary>
/// Default Properties for VML Objects in Header and Footer.
/// </summary>
public interface IHeaderShapeDefaults // : DocumentModel.Wordprocessing.IShapeDefaultsType
{
  public Collection<DocumentModel.Vml.IShapeDefaults>? ShapeDefaultses { get ; set; }
  
  public Collection<DocumentModel.Vml.IShapeLayout>? ShapeLayouts { get ; set; }
  
}
