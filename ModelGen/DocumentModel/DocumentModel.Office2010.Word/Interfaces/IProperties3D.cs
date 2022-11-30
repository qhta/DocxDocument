namespace DocumentModel.Office2010.Word;

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
  public DocumentModel.Office2010.Word.PresetMaterialKind? PresetMaterialType { get ; set; }
  
  /// <summary>
  /// BevelTop.
  /// </summary>
  public DocumentModel.Office2010.Word.IBevelType? BevelTop { get ; set; }
  
  /// <summary>
  /// BevelBottom.
  /// </summary>
  public DocumentModel.Office2010.Word.IBevelType? BevelBottom { get ; set; }
  
  /// <summary>
  /// ExtrusionColor.
  /// </summary>
  public DocumentModel.Office2010.Word.IExtrusionColor? ExtrusionColor { get ; set; }
  
  /// <summary>
  /// ContourColor.
  /// </summary>
  public DocumentModel.Office2010.Word.IContourColor? ContourColor { get ; set; }
  
}
