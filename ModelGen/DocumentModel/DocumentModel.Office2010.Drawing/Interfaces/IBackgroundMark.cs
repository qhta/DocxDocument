namespace DocumentModel.Office2010.Drawing;

/// <summary>
/// Defines the BackgroundMark Class.
/// </summary>
public interface IBackgroundMark // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// x1, this property is only available in Office 2010 and later.
  /// </summary>
  public System.Int32? FirstXCoordinate { get ; set; }
  
  /// <summary>
  /// y1, this property is only available in Office 2010 and later.
  /// </summary>
  public System.Int32? FirstYCoordinate { get ; set; }
  
  /// <summary>
  /// x2, this property is only available in Office 2010 and later.
  /// </summary>
  public System.Int32? SecondXCoordinate { get ; set; }
  
  /// <summary>
  /// y2, this property is only available in Office 2010 and later.
  /// </summary>
  public System.Int32? SecondYCoordinate { get ; set; }
  
}
