namespace DocumentModel.Drawings;

/// <summary>
/// Defines the ConnectionType Class.
/// </summary>
public class ConnectionTypeImpl: ModelElementImpl, ConnectionType
{
  public DocumentFormat.OpenXml.Drawing.ConnectionType? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.ConnectionType?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public ConnectionTypeImpl(): base() {}
  
  public ConnectionTypeImpl(DocumentFormat.OpenXml.Drawing.ConnectionType openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Identifier
  /// </summary>
  public UInt32? Id
  {
    get => (System.UInt32?)OpenXmlElement?.Id?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Id = (System.UInt32?)value;
    }
  }
  
  /// <summary>
  /// Index
  /// </summary>
  public UInt32? Index
  {
    get => (System.UInt32?)OpenXmlElement?.Index?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Index = (System.UInt32?)value;
    }
  }
  
}
