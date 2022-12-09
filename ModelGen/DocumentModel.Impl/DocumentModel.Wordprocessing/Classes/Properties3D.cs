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
    get => (Int64?)OpenXmlElement?.ExtrusionHeight?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.ExtrusionHeight = (System.Int64?)value;
    }
  }
  
  /// <summary>
  /// contourW, this property is only available in Office 2010 and later.
  /// </summary>
  public Int64? ContourWidth
  {
    get => (Int64?)OpenXmlElement?.ContourWidth?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.ContourWidth = (System.Int64?)value;
    }
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
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// BevelBottom.
  /// </summary>
  public BevelType? BevelBottom
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// ExtrusionColor.
  /// </summary>
  public ExtrusionColor? ExtrusionColor
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// ContourColor.
  /// </summary>
  public ContourColor? ContourColor
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
