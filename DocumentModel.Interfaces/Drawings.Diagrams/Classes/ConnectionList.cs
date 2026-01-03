namespace DocumentModel.Drawings.Diagrams;

/// <summary>
///   Connection List.
/// </summary>
public interface ConnectionList: IModelElement
{
  public Collection<Connection>? Connections { get; set; }
}