namespace DocumentModel;

/// <summary>
/// Represents the OpenXml loading context.
/// </summary>
public interface IOpenXmlElementContext // : 
{
  public DocumentModel.Packaging.IMarkupCompatibilityProcessSettings? MCSettings { get ; set; }
  
  /// <summary>
  /// Gets the XmlReaderSettings to be used by public XmlReader
  /// </summary>
  public System.Xml.XmlReaderSettings? XmlReaderSettings { get ; set; }
  
  /// <summary>
  /// Gets or sets load mode
  /// </summary>
  public DocumentModel.OpenXmlLoadMode? LoadMode { get ; set; }
  
  public DocumentModel.IMCContext? MCContext { get ; set; }
  
  public System.UInt32? ACBlockLevel { get ; set; }
  
}
