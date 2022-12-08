namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the Properties3D Class.
/// </summary>
public class Properties3DImpl: ModelElementImpl, Properties3D
{
  public DocumentFormat.OpenXml.Office2010.Word.Properties3D? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2010.Word.Properties3D?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// extrusionH, this property is only available in Office 2010 and later.
  /// </summary>
  public Int64? ExtrusionHeight
  {
    get;
    set;
  }
  
  /// <summary>
  /// contourW, this property is only available in Office 2010 and later.
  /// </summary>
  public Int64? ContourWidth
  {
    get;
    set;
  }
  
  /// <summary>
  /// prstMaterial, this property is only available in Office 2010 and later.
  /// </summary>
  public PresetMaterialKind? PresetMaterialType
  {
    get => (PresetMaterialKind?)OpenXmlElement?.PresetMaterialType?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.PresetMaterialType = (DocumentFormat.OpenXml.Office2010.Word.PresetMaterialTypeValues?)value;
    }
  }
  
  /// <summary>
  /// BevelTop.
  /// </summary>
  public BevelType? BevelTop
  {
    get;
    set;
  }
  
  /// <summary>
  /// BevelBottom.
  /// </summary>
  public BevelType? BevelBottom
  {
    get;
    set;
  }
  
  /// <summary>
  /// ExtrusionColor.
  /// </summary>
  public ExtrusionColor? ExtrusionColor
  {
    get;
    set;
  }
  
  /// <summary>
  /// ContourColor.
  /// </summary>
  public ContourColor? ContourColor
  {
    get;
    set;
  }
  
}
