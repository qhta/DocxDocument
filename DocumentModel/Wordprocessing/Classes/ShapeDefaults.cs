using DocumentModel.Vml;

namespace DocumentModel.Wordprocessing;

/// <summary>
///   Default Properties for VML Objects in Main Document.
/// </summary>
public class ShapeDefaults: ModelElement
{
  public DocumentModel.Vml.ShapeDefaults? ChildShapeDefaults { get; set; }

  public ShapeLayout? ShapeLayout { get; set; }
}