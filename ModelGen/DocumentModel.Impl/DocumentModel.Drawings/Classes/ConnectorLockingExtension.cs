namespace DocumentModel.Drawings;

/// <summary>
/// Defines the ConnectorLockingExtension Class.
/// </summary>
public class ConnectorLockingExtensionImpl: ModelElementImpl, ConnectorLockingExtension
{
  public DocumentFormat.OpenXml.Drawing.ConnectorLockingExtension? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.ConnectorLockingExtension?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// URI
  /// </summary>
  public String? Uri
  {
    get;
    set;
  }
  
  public Graphic? Graphic
  {
    get;
    set;
  }
  
}
