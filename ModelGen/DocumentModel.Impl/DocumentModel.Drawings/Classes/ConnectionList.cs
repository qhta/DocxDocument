namespace DocumentModel.Drawings;

/// <summary>
/// Connection List.
/// </summary>
public class ConnectionListImpl: ModelElementImpl, ConnectionList
{
  public DocumentFormat.OpenXml.Drawing.Diagrams.ConnectionList? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Diagrams.ConnectionList?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public Collection<Connection>? Connections
  {
    get;
    set;
  }
  
}
