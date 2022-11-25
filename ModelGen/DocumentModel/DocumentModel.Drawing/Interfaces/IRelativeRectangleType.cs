namespace DocumentModel.Drawing;

/// <summary>
/// Defines the RelativeRectangleType Class.
/// </summary>
public interface IRelativeRectangleType // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// Left Offset
  /// </summary>
  public System.Int32? Left { get ; set; }
  
  /// <summary>
  /// Top Offset
  /// </summary>
  public System.Int32? Top { get ; set; }
  
  /// <summary>
  /// Right Offset
  /// </summary>
  public System.Int32? Right { get ; set; }
  
  /// <summary>
  /// Bottom Offset
  /// </summary>
  public System.Int32? Bottom { get ; set; }
  
}
