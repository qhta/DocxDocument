namespace DocumentModel.Office2019.Excel.RichData;

/// <summary>
/// Defines the Key Class.
/// </summary>
public class Key: IKey
{
  /// <summary>
  /// n, this property is only available in Office 2019 and later.
  /// </summary>
  public string? N
  {
    get;
    set;
  }
  
  /// <summary>
  /// t, this property is only available in Office 2019 and later.
  /// </summary>
  public RichValueValueType? T
  {
    get;
    set;
  }
  
}
