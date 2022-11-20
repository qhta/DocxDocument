namespace DocumentModel.Office2010.Drawing;

/// <summary>
/// Defines the BackgroundMark Class.
/// </summary>
public class BackgroundMark: IBackgroundMark
{
  /// <summary>
  /// x1, this property is only available in Office 2010 and later.
  /// </summary>
  public int? FirstXCoordinate
  {
    get;
    set;
  }
  
  /// <summary>
  /// y1, this property is only available in Office 2010 and later.
  /// </summary>
  public int? FirstYCoordinate
  {
    get;
    set;
  }
  
  /// <summary>
  /// x2, this property is only available in Office 2010 and later.
  /// </summary>
  public int? SecondXCoordinate
  {
    get;
    set;
  }
  
  /// <summary>
  /// y2, this property is only available in Office 2010 and later.
  /// </summary>
  public int? SecondYCoordinate
  {
    get;
    set;
  }
  
}
