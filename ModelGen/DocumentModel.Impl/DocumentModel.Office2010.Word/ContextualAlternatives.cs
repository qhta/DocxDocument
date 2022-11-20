namespace DocumentModel.Office2010.Word;

/// <summary>
/// Defines the ContextualAlternatives Class.
/// </summary>
public class ContextualAlternatives: IContextualAlternatives
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
