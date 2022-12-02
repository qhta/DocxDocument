namespace DocumentModel.Wordprocessing;

/// <summary>
/// Default Properties for VML Objects in Header and Footer.
/// </summary>
public interface IHeaderShapeDefaults // : DocumentModel.Wordprocessing.IShapeDefaultsType
{
  public DocumentModel.Vml.IShapeDefaults? ShapeDefaults { get ; set; }
  
  public DocumentModel.Vml.IShapeLayout? ShapeLayout { get ; set; }
  
}
