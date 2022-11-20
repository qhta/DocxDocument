namespace DocumentModel.Wordprocessing;

/// <summary>
/// Prevent Replacement of Styles Part.
/// </summary>
public class StyleLockStylesPart: IStyleLockStylesPart
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
