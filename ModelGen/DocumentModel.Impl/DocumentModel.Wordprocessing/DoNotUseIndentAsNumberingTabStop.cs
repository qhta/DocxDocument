namespace DocumentModel.Wordprocessing;

/// <summary>
/// Ignore Hanging Indent When Creating Tab Stop After Numbering.
/// </summary>
public class DoNotUseIndentAsNumberingTabStop: IDoNotUseIndentAsNumberingTabStop
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
