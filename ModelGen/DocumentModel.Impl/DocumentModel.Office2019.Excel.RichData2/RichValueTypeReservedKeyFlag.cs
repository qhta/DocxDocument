namespace DocumentModel.Office2019.Excel.RichData2;

/// <summary>
/// Defines the RichValueTypeReservedKeyFlag Class.
/// </summary>
public class RichValueTypeReservedKeyFlag: IRichValueTypeReservedKeyFlag
{
  /// <summary>
  /// name, this property is only available in Office 2019 and later.
  /// </summary>
  public string? Name
  {
    get;
    set;
  }
  
  /// <summary>
  /// value, this property is only available in Office 2019 and later.
  /// </summary>
  public bool? Value
  {
    get;
    set;
  }
  
}
