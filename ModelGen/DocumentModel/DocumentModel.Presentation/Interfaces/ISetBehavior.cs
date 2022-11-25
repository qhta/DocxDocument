namespace DocumentModel.Presentation;

/// <summary>
/// Set Time Node Behavior.
/// </summary>
public interface ISetBehavior // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Common Behavior.
  /// </summary>
  public DocumentModel.Presentation.ICommonBehavior? CommonBehavior { get ; set; }
  
  /// <summary>
  /// To.
  /// </summary>
  public DocumentModel.Presentation.ITimeListAnimationVariantType? ToVariantValue { get ; set; }
  
}
