namespace DocumentModel.Presentation;

/// <summary>
/// Placeholder Shape.
/// </summary>
public interface IPlaceholderShape // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Placeholder Type
  /// </summary>
  public DocumentModel.Presentation.PlaceholderKind? Type { get ; set; }
  
  /// <summary>
  /// Placeholder Orientation
  /// </summary>
  public DocumentModel.Presentation.DirectionKind? Orientation { get ; set; }
  
  /// <summary>
  /// Placeholder Size
  /// </summary>
  public DocumentModel.Presentation.PlaceholderSizeKind? Size { get ; set; }
  
  /// <summary>
  /// Placeholder Index
  /// </summary>
  public System.UInt32? Index { get ; set; }
  
  /// <summary>
  /// Placeholder has custom prompt
  /// </summary>
  public System.Boolean? HasCustomPrompt { get ; set; }
  
  /// <summary>
  /// ExtensionListWithModification.
  /// </summary>
  public DocumentModel.Presentation.IExtensionListWithModification? ExtensionListWithModification { get ; set; }
  
}
