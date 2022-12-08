namespace DocumentModel.Drawings;

/// <summary>
/// Defines the ShapePropertiesExtension Class.
/// </summary>
public class ShapePropertiesExtensionImpl: ModelElementImpl, ShapePropertiesExtension
{
  public DocumentFormat.OpenXml.Drawing.ShapePropertiesExtension? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.ShapePropertiesExtension?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// URI
  /// </summary>
  public String? Uri
  {
    get;
    set;
  }
  
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
  
  public Boolean? ShadowObscured
  {
    get;
    set;
  }
  
}
