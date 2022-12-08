namespace DocumentModel.Drawings;

/// <summary>
/// Defines the StrDataExtension Class.
/// </summary>
public class StrDataExtensionImpl: ModelElementImpl, StrDataExtension
{
  public DocumentFormat.OpenXml.Drawing.Charts.StrDataExtension? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.StrDataExtension?)_OpenXmlElement;
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
  
  public Boolean? AutoGeneneratedCategories
  {
    get;
    set;
  }
  
}
