namespace DocumentModel.Drawings;

/// <summary>
/// Defines the CatAxExtension Class.
/// </summary>
public class CatAxExtensionImpl: ModelElementImpl, CatAxExtension
{
  public DocumentFormat.OpenXml.Drawing.Charts.CatAxExtension? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.CatAxExtension?)_OpenXmlElement;
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
