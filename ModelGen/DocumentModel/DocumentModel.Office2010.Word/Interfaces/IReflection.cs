namespace DocumentModel.Office2010.Word;

/// <summary>
/// Defines the Reflection Class.
/// </summary>
public interface IReflection // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// blurRad, this property is only available in Office 2010 and later.
  /// </summary>
  public long? BlurRadius { get ; set; }
  
  /// <summary>
  /// stA, this property is only available in Office 2010 and later.
  /// </summary>
  public int? StartingOpacity { get ; set; }
  
  /// <summary>
  /// stPos, this property is only available in Office 2010 and later.
  /// </summary>
  public int? StartPosition { get ; set; }
  
  /// <summary>
  /// endA, this property is only available in Office 2010 and later.
  /// </summary>
  public int? EndingOpacity { get ; set; }
  
  /// <summary>
  /// endPos, this property is only available in Office 2010 and later.
  /// </summary>
  public int? EndPosition { get ; set; }
  
  /// <summary>
  /// dist, this property is only available in Office 2010 and later.
  /// </summary>
  public long? DistanceFromText { get ; set; }
  
  /// <summary>
  /// dir, this property is only available in Office 2010 and later.
  /// </summary>
  public int? DirectionAngle { get ; set; }
  
  /// <summary>
  /// fadeDir, this property is only available in Office 2010 and later.
  /// </summary>
  public int? FadeDirection { get ; set; }
  
  /// <summary>
  /// sx, this property is only available in Office 2010 and later.
  /// </summary>
  public int? HorizontalScalingFactor { get ; set; }
  
  /// <summary>
  /// sy, this property is only available in Office 2010 and later.
  /// </summary>
  public int? VerticalScalingFactor { get ; set; }
  
  /// <summary>
  /// kx, this property is only available in Office 2010 and later.
  /// </summary>
  public int? HorizontalSkewAngle { get ; set; }
  
  /// <summary>
  /// ky, this property is only available in Office 2010 and later.
  /// </summary>
  public int? VerticalSkewAngle { get ; set; }
  
  /// <summary>
  /// algn, this property is only available in Office 2010 and later.
  /// </summary>
  public DocumentModel.Office2010.Word.RectangleAlignmentValues? Alignment { get ; set; }
  
}
