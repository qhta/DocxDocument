namespace DocumentModel.Drawings;

/// <summary>
/// Defines the ShapePropertiesExtension Class.
/// </summary>
public class ShapePropertiesExtensionImpl: ModelElement<DocumentFormat.OpenXml.Drawing.ShapePropertiesExtension>, ShapePropertiesExtension
{
  public HiddenFillProperties? HiddenFillProperties
  {
    get;
    set;
  }
  
  public HiddenLineProperties? HiddenLineProperties
  {
    get;
    set;
  }
  
  public HiddenEffectsProperties? HiddenEffectsProperties
  {
    get;
    set;
  }
  
  public HiddenScene3D? HiddenScene3D
  {
    get;
    set;
  }
  
  public HiddenShape3D? HiddenShape3D
  {
    get;
    set;
  }
  
}
