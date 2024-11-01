namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the FitText Class.
/// </summary>
public partial class FitTextImpl: ModelElementImpl, FitText
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Wordprocessing.FitText? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.FitText?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public FitTextImpl(): base() {}
  
  public FitTextImpl(DocumentFormat.OpenXml.Wordprocessing.FitText openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Value
  /// </summary>
  public UInt32? Val
  {
    get => (System.UInt32?)OpenXmlElement?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Val = (System.UInt32?)value;
    }
  }
  
  /// <summary>
  /// Fit Text Run ID
  /// </summary>
  public Int32? Id
  {
    get => (System.Int32?)OpenXmlElement?.Id?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Id = (System.Int32?)value;
    }
  }
  
}
