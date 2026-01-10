using DocumentModel.Drawings;
namespace DocumentModel.Wordprocessing;
/// <summary>
///   Defines the Shadow Class.
/// </summary>
public interface Shadow: TypedModelElement, DrawingProperty
{
  /// <summary>
  ///   blurRad
  /// </summary>
  public Int64? BlurRadius { get; set; }
  /// <summary>
  ///   dist
  /// </summary>
  public Int64? DistanceFromText { get; set; }
  /// <summary>
  ///   dir
  /// </summary>
  public Int32? DirectionAngle { get; set; }
  /// <summary>
  ///   sx
  /// </summary>
  public Int32? HorizontalScalingFactor { get; set; }
  /// <summary>
  ///   sy
  /// </summary>
  public Int32? VerticalScalingFactor { get; set; }
  /// <summary>
  ///   kx
  /// </summary>
  public Int32? HorizontalSkewAngle { get; set; }
  /// <summary>
  ///   ky
  /// </summary>
  public Int32? VerticalSkewAngle { get; set; }
  /// <summary>
  ///   algn
  /// </summary>
  public RectangleAlignmentKind? Alignment { get; set; }
  /// <summary>
  ///   RgbColorModelHex.
  /// </summary>
  public RgbColorModelHex? RgbColorModelHex { get; set; }
  /// <summary>
  ///   SchemeColor.
  /// </summary>
  public SchemeColor? SchemeColor { get; set; }
}