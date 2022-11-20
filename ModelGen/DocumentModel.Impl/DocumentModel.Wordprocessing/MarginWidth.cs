namespace DocumentModel.Wordprocessing;

/// <summary>
/// Left and Right Margin for Frame.
/// </summary>
public class MarginWidth: IMarginWidth
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
