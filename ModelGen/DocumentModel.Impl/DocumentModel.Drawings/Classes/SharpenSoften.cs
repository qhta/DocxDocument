namespace DocumentModel.Drawings;

/// <summary>
/// Defines the SharpenSoften Class.
/// </summary>
public partial class SharpenSoftenImpl: ModelElementImpl, SharpenSoften
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Office2010.Drawing.SharpenSoften? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2010.Drawing.SharpenSoften?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public SharpenSoftenImpl(): base() {}
  
  public SharpenSoftenImpl(DocumentFormat.OpenXml.Office2010.Drawing.SharpenSoften openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// amount, this property is only available in Office 2010 and later.
  /// </summary>
  public Int32? Amount
  {
    get => (System.Int32?)OpenXmlElement?.Amount?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Amount = (System.Int32?)value;
    }
  }
  
}
