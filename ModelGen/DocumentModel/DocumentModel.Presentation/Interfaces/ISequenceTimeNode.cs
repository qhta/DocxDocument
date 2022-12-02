namespace DocumentModel.Presentation;

/// <summary>
/// Sequence Time Node.
/// </summary>
public interface ISequenceTimeNode // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Concurrent
  /// </summary>
  public Boolean? Concurrent { get ; set; }
  
  /// <summary>
  /// Previous Action
  /// </summary>
  public PreviousActionKind? PreviousAction { get ; set; }
  
  /// <summary>
  /// Next Action
  /// </summary>
  public NextActionKind? NextAction { get ; set; }
  
  /// <summary>
  /// Common TimeNode Properties.
  /// </summary>
  public ICommonTimeNode? CommonTimeNode { get ; set; }
  
  /// <summary>
  /// Previous Conditions List.
  /// </summary>
  public IPreviousConditionList? PreviousConditionList { get ; set; }
  
  /// <summary>
  /// Next Conditions List.
  /// </summary>
  public INextConditionList? NextConditionList { get ; set; }
  
}
