namespace DocumentModel.Office2010.Word;

/// <summary>
/// Defines the Properties3D Class.
/// </summary>
public interface IProperties3D // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// extrusionH, this property is only available in Office 2010 and later.
  /// </summary>
  public Int64? ExtrusionHeight { get ; set; }
  
  /// <summary>
  /// contourW, this property is only available in Office 2010 and later.
  /// </summary>
  public Int64? ContourWidth { get ; set; }
  
  /// <summary>
  /// prstMaterial, this property is only available in Office 2010 and later.
  /// </summary>
  public PresetMaterialTypeValues? PresetMaterialType { get ; set; }
  
  /// <summary>
  /// BevelTop.
  /// </summary>
  public IBevelTop? BevelTop { get ; set; }
  
  /// <summary>
  /// BevelBottom.
  /// </summary>
  public IBevelBottom? BevelBottom { get ; set; }
  
  /// <summary>
  /// ExtrusionColor.
  /// </summary>
  public IExtrusionColor? ExtrusionColor { get ; set; }
  
  /// <summary>
  /// ContourColor.
  /// </summary>
  public IContourColor? ContourColor { get ; set; }
  
}
