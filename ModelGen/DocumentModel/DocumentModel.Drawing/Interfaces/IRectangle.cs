namespace DocumentModel.Drawing;

/// <summary>
/// Shape Text Rectangle.
/// </summary>
public interface IRectangle // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// Left
  /// </summary>
  public System.String? Left { get ; set; }
  
  /// <summary>
  /// Top
  /// </summary>
  public System.String? Top { get ; set; }
  
  /// <summary>
  /// Right
  /// </summary>
  public System.String? Right { get ; set; }
  
  /// <summary>
  /// Bottom Position
  /// </summary>
  public System.String? Bottom { get ; set; }
  
}
