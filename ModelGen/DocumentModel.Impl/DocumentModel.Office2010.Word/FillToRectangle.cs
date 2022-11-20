namespace DocumentModel.Office2010.Word;

/// <summary>
/// Defines the FillToRectangle Class.
/// </summary>
public class FillToRectangle: IFillToRectangle
{
  /// <summary>
  /// l, this property is only available in Office 2010 and later.
  /// </summary>
  public int? Left
  {
    get;
    set;
  }
  
  /// <summary>
  /// t, this property is only available in Office 2010 and later.
  /// </summary>
  public int? Top
  {
    get;
    set;
  }
  
  /// <summary>
  /// r, this property is only available in Office 2010 and later.
  /// </summary>
  public int? Right
  {
    get;
    set;
  }
  
  /// <summary>
  /// b, this property is only available in Office 2010 and later.
  /// </summary>
  public int? Bottom
  {
    get;
    set;
  }
  
}
