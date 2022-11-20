namespace DocumentModel.Wordprocessing;

/// <summary>
/// Top and Bottom Margin for Frame.
/// </summary>
public class MarginHeight: IMarginHeight
{
  /// <summary>
  /// Measurement in Pixels
  /// </summary>
  public uint? Val
  {
    get;
    set;
  }
  
}
