namespace DocumentModel.Drawing.Diagrams;

/// <summary>
/// 3-D Shape Properties.
/// </summary>
public interface IShape3D // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Shape Depth
  /// </summary>
  public System.Int64? Z { get ; set; }
  
  /// <summary>
  /// Extrusion Height
  /// </summary>
  public System.Int64? ExtrusionHeight { get ; set; }
  
  /// <summary>
  /// Contour Width
  /// </summary>
  public System.Int64? ContourWidth { get ; set; }
  
  /// <summary>
  /// Preset Material Type
  /// </summary>
  public DocumentModel.Drawing.PresetMaterialKind? PresetMaterial { get ; set; }
  
  /// <summary>
  /// Top Bevel.
  /// </summary>
  public DocumentModel.Drawing.IBevelType? BevelTop { get ; set; }
  
  /// <summary>
  /// Bottom Bevel.
  /// </summary>
  public DocumentModel.Drawing.IBevelType? BevelBottom { get ; set; }
  
  /// <summary>
  /// Extrusion Color.
  /// </summary>
  public DocumentModel.Drawing.IExtrusionColor? ExtrusionColor { get ; set; }
  
  /// <summary>
  /// Contour Color.
  /// </summary>
  public DocumentModel.Drawing.IContourColor? ContourColor { get ; set; }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public DocumentModel.Drawing.IExtensionList? ExtensionList { get ; set; }
  
}
