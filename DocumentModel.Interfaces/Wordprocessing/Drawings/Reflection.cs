using DocumentModel.Drawings;
namespace DocumentModel.Wordprocessing;
/// <summary>
///   Defines the Reflection Class.
/// </summary>
public interface Reflection: ITypedModelElement, DrawingProperty
{
  /// <summary>
  ///   blurRad
  /// </summary>
  public Int64? BlurRadius { get; set; }
  /// <summary>
  ///   stA
  /// </summary>
  public Int32? StartingOpacity { get; set; }
  /// <summary>
  ///   stPos
  /// </summary>
  public Int32? StartPosition { get; set; }
  /// <summary>
  ///   endA
  /// </summary>
  public Int32? EndingOpacity { get; set; }
  /// <summary>
  ///   endPos
  /// </summary>
  public Int32? EndPosition { get; set; }
  /// <summary>
  ///   dist
  /// </summary>
  public Int64? DistanceFromText { get; set; }
  /// <summary>
  ///   dir
  /// </summary>
  public Int32? DirectionAngle { get; set; }
  /// <summary>
  ///   fadeDir
  /// </summary>
  public Int32? FadeDirection { get; set; }
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
}