namespace DocumentModel.Presentation;

/// <summary>
/// Defines the SlideSize Class.
/// </summary>
public interface ISlideSize // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// Extent Length
  /// </summary>
  public int? Cx { get ; set; }
  
  /// <summary>
  /// Extent Width
  /// </summary>
  public int? Cy { get ; set; }
  
  /// <summary>
  /// Type of Size
  /// </summary>
  public SlideSize? Type { get ; set; }
  
}
