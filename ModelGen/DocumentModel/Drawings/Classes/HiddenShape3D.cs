namespace DocumentModel.Drawings;


/// <summary>
///   Defines the HiddenShape3D Class.
/// </summary>
public partial class HiddenShape3D
{
  
  /// <summary>
  ///   Shape Depth
  /// </summary>
  [SchemaAttr("z")]
  public Int64? Z { get; set; }
  
  
  /// <summary>
  ///   Extrusion Height
  /// </summary>
  [SchemaAttr("extrusionH")]
  public Int64? ExtrusionHeight { get; set; }
  
  
  /// <summary>
  ///   Contour Width
  /// </summary>
  [SchemaAttr("contourW")]
  public Int64? ContourWidth { get; set; }
  
  
  /// <summary>
  ///   Preset Material Type
  /// </summary>
  [SchemaAttr("prstMaterial")]
  public DocumentModel.Drawings.PresetMaterialTypeValues? PresetMaterial { get; set; }
  
  
  /// <summary>
  ///   Top Bevel.
  /// </summary>
  public DocumentModel.Drawings.BevelType? BevelTop { get; set; }
  
  
  /// <summary>
  ///   Bottom Bevel.
  /// </summary>
  public DocumentModel.Drawings.BevelType? BevelBottom { get; set; }
  
  
  /// <summary>
  ///   Extrusion Color.
  /// </summary>
  public DocumentModel.Drawings.ExtrusionColor? ExtrusionColor { get; set; }
  
  
  /// <summary>
  ///   Contour Color.
  /// </summary>
  public DocumentModel.Drawings.ContourColor? ContourColor { get; set; }
  
  
  /// <summary>
  ///   ExtensionList.
  /// </summary>
  public DocumentModel.Drawings.ExtensionList? ExtensionList { get; set; }
  
}
