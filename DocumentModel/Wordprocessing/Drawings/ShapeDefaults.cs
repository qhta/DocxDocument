using DocumentModel.Vml;

namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Default Properties for VML Objects in Main Document.
/// </summary>
public class ShapeDefaults: ModelElement
{
  public DocumentModel.Vml.ShapeDefaults? ChildShapeDefaults { get; set; }

  public ShapeLayout? ShapeLayout { get; set; }
}