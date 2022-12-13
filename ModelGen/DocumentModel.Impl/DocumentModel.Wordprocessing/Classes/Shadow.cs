namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the Shadow Class.
/// </summary>
public class ShadowImpl: ModelElementImpl, Shadow
{
  public DocumentFormat.OpenXml.Office2010.Word.Shadow? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2010.Word.Shadow?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public ShadowImpl(): base() {}
  
  public ShadowImpl(DocumentFormat.OpenXml.Office2010.Word.Shadow openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// blurRad, this property is only available in Office 2010 and later.
  /// </summary>
  public Int64? BlurRadius
  {
    get => (System.Int64?)OpenXmlElement?.BlurRadius?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.BlurRadius = (System.Int64?)value;
    }
  }
  
  /// <summary>
  /// dist, this property is only available in Office 2010 and later.
  /// </summary>
  public Int64? DistanceFromText
  {
    get => (System.Int64?)OpenXmlElement?.DistanceFromText?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.DistanceFromText = (System.Int64?)value;
    }
  }
  
  /// <summary>
  /// dir, this property is only available in Office 2010 and later.
  /// </summary>
  public Int32? DirectionAngle
  {
    get => (System.Int32?)OpenXmlElement?.DirectionAngle?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.DirectionAngle = (System.Int32?)value;
    }
  }
  
  /// <summary>
  /// sx, this property is only available in Office 2010 and later.
  /// </summary>
  public Int32? HorizontalScalingFactor
  {
    get => (System.Int32?)OpenXmlElement?.HorizontalScalingFactor?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.HorizontalScalingFactor = (System.Int32?)value;
    }
  }
  
  /// <summary>
  /// sy, this property is only available in Office 2010 and later.
  /// </summary>
  public Int32? VerticalScalingFactor
  {
    get => (System.Int32?)OpenXmlElement?.VerticalScalingFactor?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.VerticalScalingFactor = (System.Int32?)value;
    }
  }
  
  /// <summary>
  /// kx, this property is only available in Office 2010 and later.
  /// </summary>
  public Int32? HorizontalSkewAngle
  {
    get => (System.Int32?)OpenXmlElement?.HorizontalSkewAngle?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.HorizontalSkewAngle = (System.Int32?)value;
    }
  }
  
  /// <summary>
  /// ky, this property is only available in Office 2010 and later.
  /// </summary>
  public Int32? VerticalSkewAngle
  {
    get => (System.Int32?)OpenXmlElement?.VerticalSkewAngle?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.VerticalSkewAngle = (System.Int32?)value;
    }
  }
  
  /// <summary>
  /// algn, this property is only available in Office 2010 and later.
  /// </summary>
  public DocumentModel.Wordprocessing.RectangleAlignmentKind? Alignment
  {
    get => (DocumentModel.Wordprocessing.RectangleAlignmentKind?)OpenXmlElement?.Alignment?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Alignment = (DocumentFormat.OpenXml.Office2010.Word.RectangleAlignmentValues?)value;
    }
  }
  
  /// <summary>
  /// RgbColorModelHex.
  /// </summary>
  public DocumentModel.Wordprocessing.RgbColorModelHex? RgbColorModelHex
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// SchemeColor.
  /// </summary>
  public DocumentModel.Wordprocessing.SchemeColor? SchemeColor
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
