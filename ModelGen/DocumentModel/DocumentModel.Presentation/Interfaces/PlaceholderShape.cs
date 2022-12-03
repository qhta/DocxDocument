namespace DocumentModel.Presentation;

/// <summary>
/// Placeholder Shape.
/// </summary>
public interface PlaceholderShape // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// Placeholder Type
  /// </summary>
  public PlaceholderKind? Type { get ; set; }
  
  /// <summary>
  /// Placeholder Orientation
  /// </summary>
  public DirectionKind? Orientation { get ; set; }
  
  /// <summary>
  /// Placeholder Size
  /// </summary>
  public PlaceholderSizeKind? Size { get ; set; }
  
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
  public ExtensionListWithModification? ExtensionListWithModification { get ; set; }
  
}
