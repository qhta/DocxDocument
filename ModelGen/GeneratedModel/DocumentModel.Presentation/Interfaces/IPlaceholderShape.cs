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
  public Placeholder? Type { get ; set; }
  
  /// <summary>
  /// Placeholder Orientation
  /// </summary>
  public DocumentModel.Presentation.Direction? Orientation { get ; set; }
  
  /// <summary>
  /// Placeholder Size
  /// </summary>
  public PlaceholderSize? Size { get ; set; }
  
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
