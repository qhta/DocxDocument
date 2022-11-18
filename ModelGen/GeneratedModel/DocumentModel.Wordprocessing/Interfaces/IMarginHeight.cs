namespace DocumentModel.Wordprocessing;

/// <summary>
/// Top and Bottom Margin for Frame.
/// </summary>
public interface IMarginHeight // : DocumentFormat.OpenXml.Wordprocessing.PixelsMeasureType
{
  /// <summary>
  /// Measurement in Pixels
  /// </summary>
  public uint? Val { get ; set; }
  
}
