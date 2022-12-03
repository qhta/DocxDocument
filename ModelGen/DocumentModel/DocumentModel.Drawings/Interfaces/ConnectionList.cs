namespace DocumentModel.Drawings;

/// <summary>
/// Connection List.
/// </summary>
public interface ConnectionList // : DocumentModel.BaseTypes.ModelElement
{
  public Collection<Connection>? Connections { get ; set; }
  
}
