namespace DocumentModel.Office2010.Word;

/// <summary>
/// Defines the Shadow Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2010.Word.ISchemeColor))]
[ChildElementInfo(typeof(DocumentModel.Office2010.Word.IRgbColorModelHex))]
public class Shadow: IShadow
{
  /// <summary>
  /// blurRad, this property is only available in Office 2010 and later.
  /// </summary>
  public long? BlurRadius
  {
    get;
    set;
  }
  
  /// <summary>
  /// dist, this property is only available in Office 2010 and later.
  /// </summary>
  public long? DistanceFromText
  {
    get;
    set;
  }
  
  /// <summary>
  /// dir, this property is only available in Office 2010 and later.
  /// </summary>
  public int? DirectionAngle
  {
    get;
    set;
  }
  
  /// <summary>
  /// sx, this property is only available in Office 2010 and later.
  /// </summary>
  public int? HorizontalScalingFactor
  {
    get;
    set;
  }
  
  /// <summary>
  /// sy, this property is only available in Office 2010 and later.
  /// </summary>
  public int? VerticalScalingFactor
  {
    get;
    set;
  }
  
  /// <summary>
  /// kx, this property is only available in Office 2010 and later.
  /// </summary>
  public int? HorizontalSkewAngle
  {
    get;
    set;
  }
  
  /// <summary>
  /// ky, this property is only available in Office 2010 and later.
  /// </summary>
  public int? VerticalSkewAngle
  {
    get;
    set;
  }
  
  /// <summary>
  /// algn, this property is only available in Office 2010 and later.
  /// </summary>
  public DocumentModel.Office2010.Word.RectangleAlignmentValues? Alignment
  {
    get;
    set;
  }
  
  /// <summary>
  /// RgbColorModelHex.
  /// </summary>
  public DocumentModel.Office2010.Word.IRgbColorModelHex? RgbColorModelHex
  {
    get;
    set;
  }
  
  /// <summary>
  /// SchemeColor.
  /// </summary>
  public DocumentModel.Office2010.Word.ISchemeColor? SchemeColor
  {
    get;
    set;
  }
  
}
