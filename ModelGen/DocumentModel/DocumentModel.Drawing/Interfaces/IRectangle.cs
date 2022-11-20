namespace DocumentModel.Drawing;

/// <summary>
/// Shape Text Rectangle.
/// </summary>
public interface IRectangle // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// Left
  /// </summary>
  public string? Left { get ; set; }
  
  /// <summary>
  /// Top
  /// </summary>
  public string? Top { get ; set; }
  
  /// <summary>
  /// Right
  /// </summary>
  public string? Right { get ; set; }
  
  /// <summary>
  /// Bottom Position
  /// </summary>
  public string? Bottom { get ; set; }
  
}
