namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the Properties3D Class.
/// </summary>
public class Properties3DImpl: ModelElement<DocumentFormat.OpenXml.Office2010.Word.Properties3D>, Properties3D
{
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
