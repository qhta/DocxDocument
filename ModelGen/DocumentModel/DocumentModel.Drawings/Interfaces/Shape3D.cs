namespace DocumentModel.Drawings;

/// <summary>
/// 3-D Shape Properties.
/// </summary>
public interface Shape3D
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
  public DocumentModel.Drawings.PresetMaterialKind? PresetMaterial { get ; set; }
  
  /// <summary>
  /// Top Bevel.
  /// </summary>
  public DocumentModel.Drawings.BevelType? BevelTop { get ; set; }
  
  /// <summary>
  /// Bottom Bevel.
  /// </summary>
  public DocumentModel.Drawings.BevelType? BevelBottom { get ; set; }
  
  /// <summary>
  /// Extrusion Color.
  /// </summary>
  public DocumentModel.Drawings.ExtrusionColor? ExtrusionColor { get ; set; }
  
  /// <summary>
  /// Contour Color.
  /// </summary>
  public DocumentModel.Drawings.ContourColor? ContourColor { get ; set; }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public DocumentModel.Drawings.ExtensionList? ExtensionList { get ; set; }
  
}
