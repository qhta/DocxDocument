namespace DocumentModel;

/// <summary>
/// Defines the ContextualTabs Class.
/// </summary>
public partial interface ContextualTabs
{
  public Collection<DocumentModel.TabSet>? TabSets { get; set; }
  
}
