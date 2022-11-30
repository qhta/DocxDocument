namespace DocumentModel.Presentation;

/// <summary>
/// Sequence Time Node.
/// </summary>
public interface ISequenceTimeNode // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Concurrent
  /// </summary>
  public System.Boolean? Concurrent { get ; set; }
  
  /// <summary>
  /// Previous Action
  /// </summary>
  public DocumentModel.Presentation.PreviousActionKind? PreviousAction { get ; set; }
  
  /// <summary>
  /// Next Action
  /// </summary>
  public DocumentModel.Presentation.NextActionKind? NextAction { get ; set; }
  
  /// <summary>
  /// Common TimeNode Properties.
  /// </summary>
  public DocumentModel.Presentation.ICommonTimeNode? CommonTimeNode { get ; set; }
  
  /// <summary>
  /// Previous Conditions List.
  /// </summary>
  public DocumentModel.Presentation.IPreviousConditionList? PreviousConditionList { get ; set; }
  
  /// <summary>
  /// Next Conditions List.
  /// </summary>
  public DocumentModel.Presentation.INextConditionList? NextConditionList { get ; set; }
  
}
