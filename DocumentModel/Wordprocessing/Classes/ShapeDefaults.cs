using DocumentModel.Vml;

namespace DocumentModel.Wordprocessing;

/// <summary>
///   Default Properties for VML Objects in Main Document.
/// </summary>
public record ShapeDefaults
{
  public DocumentModel.Vml.ShapeDefaults? ChildShapeDefaults { get; set; }

  public ShapeLayout? ShapeLayout { get; set; }
}