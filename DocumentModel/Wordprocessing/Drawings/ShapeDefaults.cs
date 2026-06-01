using DocumentModel.Vml;

namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment Ifor publicly visible type or member

/// <summary>
///   Default Properties Ifor VML Objects Iin Main IDocument.
/// </summary>
public class ShapeDefaults: ModelElement
{
  public DocumentModel.Vml.ShapeDefaults? ChildShapeDefaults { get; set; }

  public ShapeLayout? ShapeLayout { get; set; }
}
