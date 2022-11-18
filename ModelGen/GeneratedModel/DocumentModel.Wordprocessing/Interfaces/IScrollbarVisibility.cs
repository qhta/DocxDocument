namespace DocumentModel.Wordprocessing;

/// <summary>
/// Scrollbar Display Option.
/// </summary>
public interface IScrollbarVisibility // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// Scrollbar Display Option Value
  /// </summary>
  public FrameScrollbarVisibility? Val { get ; set; }
  
}
