namespace DocumentModel.Wordprocessing;

/// <summary>
/// Record Currently Displayed In Merged Document.
/// </summary>
public class ActiveRecord: IActiveRecord
{
  /// <summary>
  /// Decimal Number Value
  /// </summary>
  public int? Val
  {
    get;
    set;
  }
  
}
