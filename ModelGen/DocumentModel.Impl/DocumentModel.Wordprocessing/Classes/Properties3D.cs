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
  
  public Properties3DImpl(): base() {}
  
  public Properties3DImpl(DocumentFormat.OpenXml.Office2010.Word.Properties3D openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// extrusionH, this property is only available in Office 2010 and later.
  /// </summary>
  public Int64? ExtrusionHeight
  {
    get => (System.Int64?)OpenXmlElement?.ExtrusionHeight?.Value;
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
    get => (System.Int64?)OpenXmlElement?.ContourWidth?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.ContourWidth = (System.Int64?)value;
    }
  }
  
  /// <summary>
  /// prstMaterial, this property is only available in Office 2010 and later.
  /// </summary>
  public DocumentModel.Wordprocessing.PresetMaterialKind? PresetMaterialType
  {
    get => (DocumentModel.Wordprocessing.PresetMaterialKind?)OpenXmlElement?.PresetMaterialType?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.PresetMaterialType = (DocumentFormat.OpenXml.Office2010.Word.PresetMaterialTypeValues?)value;
    }
  }
  
  /// <summary>
  /// BevelTop.
  /// </summary>
  public DocumentModel.Wordprocessing.BevelType? BevelTop
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// BevelBottom.
  /// </summary>
  public DocumentModel.Wordprocessing.BevelType? BevelBottom
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// ExtrusionColor.
  /// </summary>
  public DocumentModel.Wordprocessing.ExtrusionColor? ExtrusionColor
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// ContourColor.
  /// </summary>
  public DocumentModel.Wordprocessing.ContourColor? ContourColor
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
