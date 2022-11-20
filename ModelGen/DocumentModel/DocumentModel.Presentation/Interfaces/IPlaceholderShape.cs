namespace DocumentModel.Presentation;

/// <summary>
/// Placeholder Shape.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Presentation.IExtensionListWithModification))]
public interface IPlaceholderShape // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// Placeholder Type
  /// </summary>
  public PlaceholderValues? Type { get ; set; }
  
  /// <summary>
  /// Placeholder Orientation
  /// </summary>
  public DocumentModel.Presentation.DirectionValues? Orientation { get ; set; }
  
  /// <summary>
  /// Placeholder Size
  /// </summary>
  public PlaceholderSizeValues? Size { get ; set; }
  
  /// <summary>
  /// Placeholder Index
  /// </summary>
  public uint? Index { get ; set; }
  
  /// <summary>
  /// Placeholder has custom prompt
  /// </summary>
  public bool? HasCustomPrompt { get ; set; }
  
  /// <summary>
  /// ExtensionListWithModification.
  /// </summary>
  public IExtensionListWithModification? ExtensionListWithModification { get ; set; }
  
}
