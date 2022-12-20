namespace DocumentModel.Drawings.Diagrams;

/// <summary>
/// Connection List.
/// </summary>
public partial interface ConnectionList
{
  public Collection<DocumentModel.Drawings.Diagrams.Connection>? Connections { get; set; }
  
}
