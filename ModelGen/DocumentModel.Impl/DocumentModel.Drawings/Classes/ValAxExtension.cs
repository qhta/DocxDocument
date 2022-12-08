namespace DocumentModel.Drawings;

/// <summary>
/// Defines the ValAxExtension Class.
/// </summary>
public class ValAxExtensionImpl: ModelElementImpl, ValAxExtension
{
  public DocumentFormat.OpenXml.Drawing.Charts.ValAxExtension? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.ValAxExtension?)_OpenXmlElement;
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
