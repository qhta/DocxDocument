namespace DocumentModel.Presentation;

/// <summary>
/// Previous Conditions List.
/// </summary>
public interface IPreviousConditionList // : DocumentModel.Presentation.ITimeListTimeConditionalListType
{
  public System.Collections.ObjectModel.Collection<DocumentModel.Presentation.ICondition>? Conditions { get ; set; }
  
}
