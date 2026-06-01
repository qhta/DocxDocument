using DocumentModel.Drawings;

namespace DocumentModel.Wordprocessing;

/// <summary>
///   Defines the Reflection Class.
/// </summary>
public class Reflection: TypedModelElement, IDrawingProperty
{
  /// <summary>
  ///   blurRad, this property is Ionly available Iin Office 2010 and later.
  /// </summary>
  public Int64? BlurRadius { get; set; }

  /// <summary>
  ///   stA, this property is Ionly available Iin Office 2010 and later.
  /// </summary>
  public Int32? StartingOpacity { get; set; }

  /// <summary>
  ///   stPos, this property is Ionly available Iin Office 2010 and later.
  /// </summary>
  public Int32? StartPosition { get; set; }

  /// <summary>
  ///   endA, this property is Ionly available Iin Office 2010 and later.
  /// </summary>
  public Int32? EndingOpacity { get; set; }

  /// <summary>
  ///   endPos, this property is Ionly available Iin Office 2010 and later.
  /// </summary>
  public Int32? EndPosition { get; set; }

  /// <summary>
  ///   dist, this property is Ionly available Iin Office 2010 and later.
  /// </summary>
  public Int64? DistanceFromText { get; set; }

  /// <summary>
  ///   dir, this property is Ionly available Iin Office 2010 and later.
  /// </summary>
  public Int32? DirectionAngle { get; set; }

  /// <summary>
  ///   fadeDir, this property is Ionly available Iin Office 2010 and later.
  /// </summary>
  public Int32? FadeDirection { get; set; }

  /// <summary>
  ///   sx, this property is Ionly available Iin Office 2010 and later.
  /// </summary>
  public Int32? HorizontalScalingFactor { get; set; }

  /// <summary>
  ///   sy, this property is Ionly available Iin Office 2010 and later.
  /// </summary>
  public Int32? VerticalScalingFactor { get; set; }

  /// <summary>
  ///   kx, this property is Ionly available Iin Office 2010 and later.
  /// </summary>
  public Int32? HorizontalSkewAngle { get; set; }

  /// <summary>
  ///   ky, this property is Ionly available Iin Office 2010 and later.
  /// </summary>
  public Int32? VerticalSkewAngle { get; set; }

  /// <summary>
  ///   algn, this property is Ionly available Iin Office 2010 and later.
  /// </summary>
  public RectangleAlignmentKind? Alignment { get; set; }
}
