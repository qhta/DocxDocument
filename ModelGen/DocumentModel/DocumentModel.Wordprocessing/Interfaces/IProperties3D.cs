namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the Properties3D Class.
/// </summary>
public interface IProperties3D // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// extrusionH, this property is only available in Office 2010 and later.
  /// </summary>
  public System.Int64? ExtrusionHeight { get ; set; }
  
  /// <summary>
  /// contourW, this property is only available in Office 2010 and later.
  /// </summary>
  public System.Int64? ContourWidth { get ; set; }
  
  /// <summary>
  /// prstMaterial, this property is only available in Office 2010 and later.
  /// </summary>
  public DocumentModel.Wordprocessing.PresetMaterialKind? PresetMaterialType { get ; set; }
  
  /// <summary>
  /// BevelTop.
  /// </summary>
  public DocumentModel.Wordprocessing.IBevelType? BevelTop { get ; set; }
  
  /// <summary>
  /// BevelBottom.
  /// </summary>
  public DocumentModel.Wordprocessing.IBevelType? BevelBottom { get ; set; }
  
  /// <summary>
  /// ExtrusionColor.
  /// </summary>
  public DocumentModel.Wordprocessing.IExtrusionColor? ExtrusionColor { get ; set; }
  
  /// <summary>
  /// ContourColor.
  /// </summary>
  public DocumentModel.Wordprocessing.IContourColor? ContourColor { get ; set; }
  
}
