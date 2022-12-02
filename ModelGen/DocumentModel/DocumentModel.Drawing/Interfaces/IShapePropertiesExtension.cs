namespace DocumentModel.Drawing;

/// <summary>
/// Defines the ShapePropertiesExtension Class.
/// </summary>
public interface IShapePropertiesExtension // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// URI
  /// </summary>
  public System.String? Uri { get ; set; }
  
  public DocumentModel.Drawing.IHiddenFillProperties? HiddenFillProperties { get ; set; }
  
  public DocumentModel.Drawing.IHiddenLineProperties? HiddenLineProperties { get ; set; }
  
  public DocumentModel.Drawing.IHiddenEffectsProperties? HiddenEffectsProperties { get ; set; }
  
  public DocumentModel.Drawing.IHiddenScene3D? HiddenScene3D { get ; set; }
  
  public DocumentModel.Drawing.IHiddenShape3D? HiddenShape3D { get ; set; }
  
  public System.Boolean? ShadowObscured { get ; set; }
  
}
