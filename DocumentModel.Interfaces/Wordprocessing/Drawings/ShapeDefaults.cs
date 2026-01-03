using DocumentModel.Vml;
namespace DocumentModel.Wordprocessing;

/// <summary>
///   Default Properties for VML Objects in Main Document.
/// </summary>
public interface ShapeDefaults: IModelElement
{
  public DocumentModel.Vml.IShapeDefaults? ChildShapeDefaults { get; set; }
  public ShapeLayout? ShapeLayout { get; set; }
}