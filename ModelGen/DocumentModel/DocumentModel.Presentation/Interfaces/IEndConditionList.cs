namespace DocumentModel.Presentation;

/// <summary>
/// Defines the EndConditionList Class.
/// </summary>
public interface IEndConditionList // : DocumentModel.Presentation.ITimeListTimeConditionalListType
{
  public System.Collections.ObjectModel.Collection<DocumentModel.Presentation.ICondition>? Conditions { get ; set; }
  
}
