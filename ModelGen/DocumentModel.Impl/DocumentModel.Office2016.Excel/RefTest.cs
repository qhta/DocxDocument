namespace DocumentModel.Office2016.Excel;

/// <summary>
/// Defines the RefTest Class.
/// </summary>
public class RefTest: IRefTest
{
  /// <summary>
  /// n, this property is only available in Office 2016 and later.
  /// </summary>
  public string? N
  {
    get;
    set;
  }
  
  /// <summary>
  /// ajt, this property is only available in Office 2016 and later.
  /// </summary>
  public AdjustType? Ajt
  {
    get;
    set;
  }
  
  /// <summary>
  /// ajtx, this property is only available in Office 2016 and later.
  /// </summary>
  public AdjustTypeExt? Ajtx
  {
    get;
    set;
  }
  
  /// <summary>
  /// homeRef, this property is only available in Office 2016 and later.
  /// </summary>
  public bool? HomeRef
  {
    get;
    set;
  }
  
}
