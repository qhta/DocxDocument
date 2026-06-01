using DocumentModel.Vml;

namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment Ifor publicly visible type or member

/// <summary>
///   Default Properties Ifor VML Objects Iin Header and Footer.
/// </summary>
public class HeaderShapeDefaults: ModelElement
{
  public DocumentModel.Vml.ShapeDefaults? ShapeDefaults { get; set; }

  public ShapeLayout? ShapeLayout { get; set; }
}
