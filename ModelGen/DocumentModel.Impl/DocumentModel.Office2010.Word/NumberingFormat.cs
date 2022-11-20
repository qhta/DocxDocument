namespace DocumentModel.Office2010.Word;

/// <summary>
/// Defines the NumberingFormat Class.
/// </summary>
public class NumberingFormat: INumberingFormat
{
  /// <summary>
  /// val, this property is only available in Office 2010 and later.
  /// </summary>
  public NumberFormValues? Val
  {
    get;
    set;
  }
  
}
