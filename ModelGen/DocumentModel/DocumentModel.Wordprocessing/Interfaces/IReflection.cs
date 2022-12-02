namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the Reflection Class.
/// </summary>
public interface IReflection // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// blurRad, this property is only available in Office 2010 and later.
  /// </summary>
  public System.Int64? BlurRadius { get ; set; }
  
  /// <summary>
  /// stA, this property is only available in Office 2010 and later.
  /// </summary>
  public System.Int32? StartingOpacity { get ; set; }
  
  /// <summary>
  /// stPos, this property is only available in Office 2010 and later.
  /// </summary>
  public System.Int32? StartPosition { get ; set; }
  
  /// <summary>
  /// endA, this property is only available in Office 2010 and later.
  /// </summary>
  public System.Int32? EndingOpacity { get ; set; }
  
  /// <summary>
  /// endPos, this property is only available in Office 2010 and later.
  /// </summary>
  public System.Int32? EndPosition { get ; set; }
  
  /// <summary>
  /// dist, this property is only available in Office 2010 and later.
  /// </summary>
  public System.Int64? DistanceFromText { get ; set; }
  
  /// <summary>
  /// dir, this property is only available in Office 2010 and later.
  /// </summary>
  public System.Int32? DirectionAngle { get ; set; }
  
  /// <summary>
  /// fadeDir, this property is only available in Office 2010 and later.
  /// </summary>
  public System.Int32? FadeDirection { get ; set; }
  
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
  
}
