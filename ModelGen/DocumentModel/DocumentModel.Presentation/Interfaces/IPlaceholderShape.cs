namespace DocumentModel.Presentation;

/// <summary>
/// Placeholder Shape.
/// </summary>
public interface IPlaceholderShape // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Placeholder Type
  /// </summary>
  public PlaceholderValues? Type { get ; set; }
  
  /// <summary>
  /// Placeholder Orientation
  /// </summary>
  public DirectionValues? Orientation { get ; set; }
  
  /// <summary>
  /// Placeholder Size
  /// </summary>
  public PlaceholderSizeValues? Size { get ; set; }
  
  /// <summary>
  /// Placeholder Index
  /// </summary>
  public UInt32? Index { get ; set; }
  
  /// <summary>
  /// Placeholder has custom prompt
  /// </summary>
  public Boolean? HasCustomPrompt { get ; set; }
  
  /// <summary>
  /// ExtensionListWithModification.
  /// </summary>
  public IExtensionListWithModification? ExtensionListWithModification { get ; set; }
  
}
