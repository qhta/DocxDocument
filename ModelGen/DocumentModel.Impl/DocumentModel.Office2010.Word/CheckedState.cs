namespace DocumentModel.Office2010.Word;

/// <summary>
/// Defines the CheckedState Class.
/// </summary>
public class CheckedState: ICheckedState
{
  /// <summary>
  /// font, this property is only available in Office 2010 and later.
  /// </summary>
  public string? Font
  {
    get;
    set;
  }
  
  /// <summary>
  /// val, this property is only available in Office 2010 and later.
  /// </summary>
  public IHexBinaryValue? Val
  {
    get;
    set;
  }
  
}
