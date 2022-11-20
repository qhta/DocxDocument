namespace DocumentModel.Wordprocessing;

/// <summary>
/// Remove Blank Lines from Merged Documents.
/// </summary>
public class DoNotSuppressBlankLines: IDoNotSuppressBlankLines
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
