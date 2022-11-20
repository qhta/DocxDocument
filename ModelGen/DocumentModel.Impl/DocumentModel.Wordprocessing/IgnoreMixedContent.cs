namespace DocumentModel.Wordprocessing;

/// <summary>
/// Ignore Mixed Content When Validating Custom XML Markup.
/// </summary>
public class IgnoreMixedContent: IIgnoreMixedContent
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
