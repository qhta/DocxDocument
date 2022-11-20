namespace DocumentModel.Office2019.Excel.RichData2;

/// <summary>
/// Defines the RichFormatProperty Class.
/// </summary>
public class RichFormatProperty: IRichFormatProperty
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
  public RichFormatPropertyType? T
  {
    get;
    set;
  }
  
}
