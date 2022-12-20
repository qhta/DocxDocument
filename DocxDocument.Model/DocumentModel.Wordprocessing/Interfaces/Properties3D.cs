namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the Properties3D Class.
/// </summary>
public partial interface Properties3D
{
  /// <summary>
  /// extrusionH, this property is only available in Office 2010 and later.
  /// </summary>
  public Int64? ExtrusionHeight { get; set; }
  
  /// <summary>
  /// contourW, this property is only available in Office 2010 and later.
  /// </summary>
  public Int64? ContourWidth { get; set; }
  
  /// <summary>
  /// prstMaterial, this property is only available in Office 2010 and later.
  /// </summary>
  public DocumentModel.Wordprocessing.PresetMaterialKind? PresetMaterialType { get; set; }
  
  /// <summary>
  /// BevelTop.
  /// </summary>
  public DocumentModel.Wordprocessing.BevelType? BevelTop { get; set; }
  
  /// <summary>
  /// BevelBottom.
  /// </summary>
  public DocumentModel.Wordprocessing.BevelType? BevelBottom { get; set; }
  
  /// <summary>
  /// ExtrusionColor.
  /// </summary>
  public DocumentModel.Wordprocessing.ExtrusionColor? ExtrusionColor { get; set; }
  
  /// <summary>
  /// ContourColor.
  /// </summary>
  public DocumentModel.Wordprocessing.ContourColor? ContourColor { get; set; }
  
}
