namespace DocumentModel.Presentation;

/// <summary>
/// Previous Conditions List.
/// </summary>
public interface IPreviousConditionList // : DocumentModel.Presentation.ITimeListTimeConditionalListType
{
  public Collection<ICondition>? Conditions { get ; set; }
  
}
