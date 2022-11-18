namespace DocumentModel.Office2010.Word;

/// <summary>
/// Defines the Properties3D Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2010.Word.IBevelTop))]
[ChildElementInfo(typeof(DocumentModel.Office2010.Word.IBevelBottom))]
[ChildElementInfo(typeof(DocumentModel.Office2010.Word.IExtrusionColor))]
[ChildElementInfo(typeof(DocumentModel.Office2010.Word.IContourColor))]
public interface IProperties3D // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// extrusionH, this property is only available in Office 2010 and later.
  /// </summary>
  public long? ExtrusionHeight { get ; set; }
  
  /// <summary>
  /// contourW, this property is only available in Office 2010 and later.
  /// </summary>
  public long? ContourWidth { get ; set; }
  
  /// <summary>
  /// prstMaterial, this property is only available in Office 2010 and later.
  /// </summary>
  public DocumentModel.Office2010.Word.PresetMaterialType? PresetMaterialType { get ; set; }
  
  /// <summary>
  /// BevelTop.
  /// </summary>
  public DocumentModel.Office2010.Word.IBevelTop? BevelTop { get ; set; }
  
  /// <summary>
  /// BevelBottom.
  /// </summary>
  public DocumentModel.Office2010.Word.IBevelBottom? BevelBottom { get ; set; }
  
  /// <summary>
  /// ExtrusionColor.
  /// </summary>
  public DocumentModel.Office2010.Word.IExtrusionColor? ExtrusionColor { get ; set; }
  
  /// <summary>
  /// ContourColor.
  /// </summary>
  public DocumentModel.Office2010.Word.IContourColor? ContourColor { get ; set; }
  
}
