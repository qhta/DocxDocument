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
  
  /// <summary>
  /// Identifier
  /// </summary>
  public UInt32? Id
  {
    get;
    set;
  }
  
  /// <summary>
  /// Index
  /// </summary>
  public UInt32? Index
  {
    get;
    set;
  }
  
}
