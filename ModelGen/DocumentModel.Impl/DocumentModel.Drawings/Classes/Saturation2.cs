namespace DocumentModel.Drawings;

/// <summary>
/// Defines the Saturation Class.
/// </summary>
public partial class Saturation2Impl: ModelElementImpl, Saturation2
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Office2010.Drawing.Saturation? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2010.Drawing.Saturation?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public Saturation2Impl(): base() {}
  
  public Saturation2Impl(DocumentFormat.OpenXml.Office2010.Drawing.Saturation openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// sat, this property is only available in Office 2010 and later.
  /// </summary>
  public Int32? SaturationAmount
  {
    get => (System.Int32?)OpenXmlElement?.SaturationAmount?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.SaturationAmount = (System.Int32?)value;
    }
  }
  
}
