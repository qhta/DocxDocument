namespace DocumentModel;


/// <summary>
///   Defines the Tasks Class.
/// </summary>
public partial class Tasks
{
  public ExtensionList? ExtensionList { get; set; }
  
  public ElementCollection<Task>? Items { get; set; }
  
}
