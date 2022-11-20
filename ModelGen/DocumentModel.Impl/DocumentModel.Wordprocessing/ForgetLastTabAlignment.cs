namespace DocumentModel.Wordprocessing;

/// <summary>
/// Ignore Width of Last Tab Stop When Aligning Paragraph If It Is Not Left Aligned.
/// </summary>
public class ForgetLastTabAlignment: IForgetLastTabAlignment
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
