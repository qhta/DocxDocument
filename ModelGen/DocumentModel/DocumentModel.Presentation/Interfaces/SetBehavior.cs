namespace DocumentModel.Presentation;

/// <summary>
/// Set Time Node Behavior.
/// </summary>
public interface SetBehavior // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// Common Behavior.
  /// </summary>
  public CommonBehavior? CommonBehavior { get ; set; }
  
  /// <summary>
  /// To.
  /// </summary>
  public ToVariantValue? ToVariantValue { get ; set; }
  
}
