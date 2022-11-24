namespace DocumentModel.Presentation;

/// <summary>
/// Set Time Node Behavior.
/// </summary>
public interface ISetBehavior // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Common Behavior.
  /// </summary>
  public ICommonBehavior? CommonBehavior { get ; set; }
  
  /// <summary>
  /// To.
  /// </summary>
  public IToVariantValue? ToVariantValue { get ; set; }
  
}
