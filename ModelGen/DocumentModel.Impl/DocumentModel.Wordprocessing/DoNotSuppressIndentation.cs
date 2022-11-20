namespace DocumentModel.Wordprocessing;

/// <summary>
/// Do Not Ignore Floating Objects When Calculating Paragraph Indentation.
/// </summary>
public class DoNotSuppressIndentation: IDoNotSuppressIndentation
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
