using DocumentModel.Vml;

namespace DocumentModel.Wordprocessing;

/// <summary>
///   Default Properties for VML Objects in Header and Footer.
/// </summary>
public class HeaderShapeDefaults: ModelElement
{
  public DocumentModel.Vml.ShapeDefaults? ShapeDefaults { get; set; }

  public ShapeLayout? ShapeLayout { get; set; }
}