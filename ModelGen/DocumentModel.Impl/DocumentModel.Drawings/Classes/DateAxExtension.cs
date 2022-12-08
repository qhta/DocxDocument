namespace DocumentModel.Drawings;

/// <summary>
/// Defines the DateAxExtension Class.
/// </summary>
public class DateAxExtensionImpl: ModelElementImpl, DateAxExtension
{
  public DocumentFormat.OpenXml.Drawing.Charts.DateAxExtension? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.DateAxExtension?)_OpenXmlElement;
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
