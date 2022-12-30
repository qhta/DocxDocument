namespace DocumentModel.Wordprocessing;

/// <summary>
/// Default Properties for VML Objects in Main Document.
/// </summary>
public partial class ShapeDefaults
{
  public DocumentModel.Vml.ShapeDefaults? ChildShapeDefaults { get; set; }
  
  public DocumentModel.Vml.ShapeLayout? ShapeLayout { get; set; }
  
}
