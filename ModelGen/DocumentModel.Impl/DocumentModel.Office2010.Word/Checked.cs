namespace DocumentModel.Office2010.Word;

/// <summary>
/// Defines the Checked Class.
/// </summary>
public class Checked: IChecked
{
  /// <summary>
  /// val, this property is only available in Office 2010 and later.
  /// </summary>
  public OnOffValues? Val
  {
    get;
    set;
  }
  
}
