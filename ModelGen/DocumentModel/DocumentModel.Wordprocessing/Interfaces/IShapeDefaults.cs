namespace DocumentModel.Wordprocessing;

/// <summary>
/// Default Properties for VML Objects in Main Document.
/// </summary>
public interface IShapeDefaults // : DocumentModel.Wordprocessing.IShapeDefaultsType
{
  public DocumentModel.Vml.Office.IShapeDefaults? ShapeDefaults { get ; set; }
  
  public DocumentModel.Vml.Office.IShapeLayout? ShapeLayout { get ; set; }
  
}
