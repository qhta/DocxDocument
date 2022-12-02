namespace DocumentModel.Presentation;

/// <summary>
/// Next Conditions List.
/// </summary>
public interface INextConditionList // : DocumentModel.Presentation.ITimeListTimeConditionalListType
{
  public Collection<ICondition>? Conditions { get ; set; }
  
}
