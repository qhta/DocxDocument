namespace DocumentModel.Presentation;

/// <summary>
/// Defines the SlideSize Class.
/// </summary>
public interface ISlideSize // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// Extent Length
  /// </summary>
  public System.Int32? Cx { get ; set; }
  
  /// <summary>
  /// Extent Width
  /// </summary>
  public System.Int32? Cy { get ; set; }
  
  /// <summary>
  /// Type of Size
  /// </summary>
  public DocumentModel.Presentation.SlideSizeKind? Type { get ; set; }
  
}
