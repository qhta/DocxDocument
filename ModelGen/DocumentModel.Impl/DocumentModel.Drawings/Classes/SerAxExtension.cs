namespace DocumentModel.Drawings;

/// <summary>
/// Defines the SerAxExtension Class.
/// </summary>
public class SerAxExtensionImpl: ModelElementImpl, SerAxExtension
{
  public DocumentFormat.OpenXml.Drawing.Charts.SerAxExtension? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.SerAxExtension?)_OpenXmlElement;
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
  
  public NumberingFormat2? NumberingFormat
  {
    get;
    set;
  }
  
}
