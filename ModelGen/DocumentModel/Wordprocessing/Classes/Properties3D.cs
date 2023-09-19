namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies the 3-D properties of text, including bevel, extrusion, contour, and material. By default, text does not have 3-D properties.
/// </summary>
public partial class Properties3D
{
  
  /// <summary>
  ///   extrusionH, this property is only available in Office 2010 and later.
  /// </summary>
  [SchemaAttr("w14:extrusionH")]
  public Int64? ExtrusionHeight { get; set; }
  
  
  /// <summary>
  ///   contourW, this property is only available in Office 2010 and later.
  /// </summary>
  [SchemaAttr("w14:contourW")]
  public Int64? ContourWidth { get; set; }
  
  
  /// <summary>
  ///   prstMaterial, this property is only available in Office 2010 and later.
  /// </summary>
  [SchemaAttr("w14:prstMaterial")]
  public DocumentModel.Wordprocessing.PresetMaterialTypeValues? PresetMaterialType { get; set; }
  
  
  /// <summary>
  ///   BevelTop.
  /// </summary>
  public DocumentModel.Wordprocessing.BevelType? BevelTop { get; set; }
  
  
  /// <summary>
  ///   BevelBottom.
  /// </summary>
  public DocumentModel.Wordprocessing.BevelType? BevelBottom { get; set; }
  
  
  /// <summary>
  ///   ExtrusionColor.
  /// </summary>
  public DocumentModel.Wordprocessing.ExtrusionColor? ExtrusionColor { get; set; }
  
  
  /// <summary>
  ///   ContourColor.
  /// </summary>
  public DocumentModel.Wordprocessing.ContourColor? ContourColor { get; set; }
  
}
