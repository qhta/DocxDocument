namespace DocumentModel;

/// <summary>
/// Defines the Tasks Class.
/// </summary>
public class TasksImpl: ModelElement<DocumentFormat.OpenXml.Office2021.DocumentTasks.Tasks>, Tasks
{
  public ExtensionList? ExtensionList
  {
    get;
    set;
  }
  
}
