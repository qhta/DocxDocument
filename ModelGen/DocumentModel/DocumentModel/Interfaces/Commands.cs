namespace DocumentModel;

/// <summary>
/// Defines the Commands Class.
/// </summary>
public partial interface Commands
{
  public Collection<DocumentModel.Command>? Items { get; set; }
  
}
