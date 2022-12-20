namespace DocumentModel.Wordprocessing;

/// <summary>
/// Default Properties for VML Objects in Main Document.
/// </summary>
public partial interface ShapeDefaults
{
  public DocumentModel.Vml.ShapeDefaults? ChildShapeDefaults { get; set; }
  
  public DocumentModel.Vml.ShapeLayout? ShapeLayout { get; set; }
  
}
