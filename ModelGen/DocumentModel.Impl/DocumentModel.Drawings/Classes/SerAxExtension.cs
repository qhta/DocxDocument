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
    get => (String?)OpenXmlElement?.Uri?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Uri = (System.String?)value;
    }
  }
  
  public NumberingFormat1? NumberingFormat
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
