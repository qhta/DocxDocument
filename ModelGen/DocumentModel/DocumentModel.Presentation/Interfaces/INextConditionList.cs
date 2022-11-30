namespace DocumentModel.Presentation;

/// <summary>
/// Next Conditions List.
/// </summary>
public interface INextConditionList // : DocumentModel.Presentation.ITimeListTimeConditionalListType
{
  public System.Collections.ObjectModel.Collection<DocumentModel.Presentation.ICondition>? Conditions { get ; set; }
  
}
