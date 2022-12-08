namespace DocumentModel.Wordprocessing;

/// <summary>
/// Default Properties for VML Objects in Header and Footer.
/// </summary>
public interface HeaderShapeDefaults
{
  public Collection<DocumentModel.Vml.ShapeDefaults>? ShapeDefaultses { get ; set; }
  
  public Collection<DocumentModel.Vml.ShapeLayout>? ShapeLayouts { get ; set; }
  
}
