namespace DocumentModel.Wordprocessing;

/// <summary>
/// Select Field When First or Last Character Is Selected.
/// </summary>
public class SelectFieldWithFirstOrLastChar: ISelectFieldWithFirstOrLastChar
{
  /// <summary>
  /// On/Off Value
  /// </summary>
  public bool? Val
  {
    get;
    set;
  }
  
}
