namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the Shadow Class.
/// </summary>
public interface IShadow // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// blurRad, this property is only available in Office 2010 and later.
  /// </summary>
  public System.Int64? BlurRadius { get ; set; }
  
  /// <summary>
  /// dist, this property is only available in Office 2010 and later.
  /// </summary>
  public System.Int64? DistanceFromText { get ; set; }
  
  /// <summary>
  /// dir, this property is only available in Office 2010 and later.
  /// </summary>
  public System.Int32? DirectionAngle { get ; set; }
  
  /// <summary>
  /// sx, this property is only available in Office 2010 and later.
  /// </summary>
  public System.Int32? HorizontalScalingFactor { get ; set; }
  
  /// <summary>
  /// sy, this property is only available in Office 2010 and later.
  /// </summary>
  public System.Int32? VerticalScalingFactor { get ; set; }
  
  /// <summary>
  /// kx, this property is only available in Office 2010 and later.
  /// </summary>
  public System.Int32? HorizontalSkewAngle { get ; set; }
  
  /// <summary>
  /// ky, this property is only available in Office 2010 and later.
  /// </summary>
  public System.Int32? VerticalSkewAngle { get ; set; }
  
  /// <summary>
  /// algn, this property is only available in Office 2010 and later.
  /// </summary>
  public DocumentModel.Wordprocessing.RectangleAlignmentKind? Alignment { get ; set; }
  
  /// <summary>
  /// RgbColorModelHex.
  /// </summary>
  public DocumentModel.Wordprocessing.IRgbColorModelHex? RgbColorModelHex { get ; set; }
  
  /// <summary>
  /// SchemeColor.
  /// </summary>
  public DocumentModel.Wordprocessing.ISchemeColor? SchemeColor { get ; set; }
  
}
