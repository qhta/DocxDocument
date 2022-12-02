namespace DocumentModel.Drawing;

/// <summary>
/// Defines the ShapePropertiesExtension Class.
/// </summary>
public interface IShapePropertiesExtension // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// URI
  /// </summary>
  public String? Uri { get ; set; }
  
  public IHiddenFillProperties? HiddenFillProperties { get ; set; }
  
  public IHiddenLineProperties? HiddenLineProperties { get ; set; }
  
  public IHiddenEffectsProperties? HiddenEffectsProperties { get ; set; }
  
  public IHiddenScene3D? HiddenScene3D { get ; set; }
  
  public IHiddenShape3D? HiddenShape3D { get ; set; }
  
  public Boolean? ShadowObscured { get ; set; }
  
}
