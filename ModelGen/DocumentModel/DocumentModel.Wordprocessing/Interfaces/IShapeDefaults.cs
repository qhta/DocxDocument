namespace DocumentModel.Wordprocessing;

/// <summary>
/// Default Properties for VML Objects in Main Document.
/// </summary>
public interface IShapeDefaults // : DocumentModel.Wordprocessing.IShapeDefaultsType
{
  public DocumentModel.Vml.IShapeDefaults? ShapeDefaults { get ; set; }
  
  public DocumentModel.Vml.IShapeLayout? ShapeLayout { get ; set; }
  
}
