namespace DocumentModel.Drawing;

/// <summary>
/// Fill To Rectangle.
/// </summary>
public interface IFillToRectangle // : DocumentFormat.OpenXml.Drawing.RelativeRectangleType
{
  /// <summary>
  /// Left Offset
  /// </summary>
  public int? Left { get ; set; }
  
  /// <summary>
  /// Top Offset
  /// </summary>
  public int? Top { get ; set; }
  
  /// <summary>
  /// Right Offset
  /// </summary>
  public int? Right { get ; set; }
  
  /// <summary>
  /// Bottom Offset
  /// </summary>
  public int? Bottom { get ; set; }
  
}
