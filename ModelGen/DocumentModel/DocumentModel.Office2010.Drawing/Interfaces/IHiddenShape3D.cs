namespace DocumentModel.Office2010.Drawing;

/// <summary>
/// Defines the HiddenShape3D Class.
/// </summary>
public interface IHiddenShape3D // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Shape Depth
  /// </summary>
  public Int64? Z { get ; set; }
  
  /// <summary>
  /// Extrusion Height
  /// </summary>
  public Int64? ExtrusionHeight { get ; set; }
  
  /// <summary>
  /// Contour Width
  /// </summary>
  public Int64? ContourWidth { get ; set; }
  
  /// <summary>
  /// Preset Material Type
  /// </summary>
  public PresetMaterialTypeValues? PresetMaterial { get ; set; }
  
  /// <summary>
  /// Top Bevel.
  /// </summary>
  public IBevelTop? BevelTop { get ; set; }
  
  /// <summary>
  /// Bottom Bevel.
  /// </summary>
  public IBevelBottom? BevelBottom { get ; set; }
  
  /// <summary>
  /// Extrusion Color.
  /// </summary>
  public IExtrusionColor? ExtrusionColor { get ; set; }
  
  /// <summary>
  /// Contour Color.
  /// </summary>
  public IContourColor? ContourColor { get ; set; }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public IExtensionList? ExtensionList { get ; set; }
  
}
