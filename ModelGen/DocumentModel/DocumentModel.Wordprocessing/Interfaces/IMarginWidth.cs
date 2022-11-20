namespace DocumentModel.Wordprocessing;

/// <summary>
/// Left and Right Margin for Frame.
/// </summary>
public interface IMarginWidth // : DocumentFormat.OpenXml.Wordprocessing.PixelsMeasureType
{
  /// <summary>
  /// Measurement in Pixels
  /// </summary>
  public uint? Val { get ; set; }
  
}
