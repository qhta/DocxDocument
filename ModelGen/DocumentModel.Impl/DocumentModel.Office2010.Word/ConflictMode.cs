namespace DocumentModel.Office2010.Word;

/// <summary>
/// Defines the ConflictMode Class.
/// </summary>
public class ConflictMode: IConflictMode
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
