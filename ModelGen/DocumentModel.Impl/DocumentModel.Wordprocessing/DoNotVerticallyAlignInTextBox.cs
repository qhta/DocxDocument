namespace DocumentModel.Wordprocessing;

/// <summary>
/// Ignore Vertical Alignment in Textboxes.
/// </summary>
public class DoNotVerticallyAlignInTextBox: IDoNotVerticallyAlignInTextBox
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
