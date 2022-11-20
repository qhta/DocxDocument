namespace DocumentModel.Wordprocessing;

/// <summary>
/// Frameset Layout.
/// </summary>
public interface IFrameLayout // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// Frameset Layout Value
  /// </summary>
  public FrameLayoutValues? Val { get ; set; }
  
}
