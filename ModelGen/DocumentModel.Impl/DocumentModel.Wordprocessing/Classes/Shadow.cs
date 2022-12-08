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
  
  /// <summary>
  /// blurRad, this property is only available in Office 2010 and later.
  /// </summary>
  public Int64? BlurRadius
  {
    get;
    set;
  }
  
  /// <summary>
  /// dist, this property is only available in Office 2010 and later.
  /// </summary>
  public Int64? DistanceFromText
  {
    get;
    set;
  }
  
  /// <summary>
  /// dir, this property is only available in Office 2010 and later.
  /// </summary>
  public Int32? DirectionAngle
  {
    get;
    set;
  }
  
  /// <summary>
  /// sx, this property is only available in Office 2010 and later.
  /// </summary>
  public Int32? HorizontalScalingFactor
  {
    get;
    set;
  }
  
  /// <summary>
  /// sy, this property is only available in Office 2010 and later.
  /// </summary>
  public Int32? VerticalScalingFactor
  {
    get;
    set;
  }
  
  /// <summary>
  /// kx, this property is only available in Office 2010 and later.
  /// </summary>
  public Int32? HorizontalSkewAngle
  {
    get;
    set;
  }
  
  /// <summary>
  /// ky, this property is only available in Office 2010 and later.
  /// </summary>
  public Int32? VerticalSkewAngle
  {
    get;
    set;
  }
  
  /// <summary>
  /// algn, this property is only available in Office 2010 and later.
  /// </summary>
  public RectangleAlignmentKind? Alignment
  {
    get => (RectangleAlignmentKind?)OpenXmlElement?.Alignment?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Alignment = (DocumentFormat.OpenXml.Office2010.Word.RectangleAlignmentValues?)value;
    }
  }
  
  /// <summary>
  /// RgbColorModelHex.
  /// </summary>
  public RgbColorModelHex? RgbColorModelHex
  {
    get;
    set;
  }
  
  /// <summary>
  /// SchemeColor.
  /// </summary>
  public SchemeColor? SchemeColor
  {
    get;
    set;
  }
  
}
