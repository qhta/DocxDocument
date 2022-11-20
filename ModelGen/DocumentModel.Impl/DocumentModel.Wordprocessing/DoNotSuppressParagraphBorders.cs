namespace DocumentModel.Wordprocessing;

/// <summary>
/// Do Not Suppress Paragraph Borders Next To Frames.
/// </summary>
public class DoNotSuppressParagraphBorders: IDoNotSuppressParagraphBorders
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
