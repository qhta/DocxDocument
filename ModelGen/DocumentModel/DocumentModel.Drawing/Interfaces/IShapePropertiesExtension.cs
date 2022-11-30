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
  
  public DocumentModel.Office2010.Drawing.IHiddenFillProperties? HiddenFillProperties { get ; set; }
  
  public DocumentModel.Office2010.Drawing.IHiddenLineProperties? HiddenLineProperties { get ; set; }
  
  public DocumentModel.Office2010.Drawing.IHiddenEffectsProperties? HiddenEffectsProperties { get ; set; }
  
  public DocumentModel.Office2010.Drawing.IHiddenScene3D? HiddenScene3D { get ; set; }
  
  public DocumentModel.Office2010.Drawing.IHiddenShape3D? HiddenShape3D { get ; set; }
  
  public System.Boolean? ShadowObscured { get ; set; }
  
}
