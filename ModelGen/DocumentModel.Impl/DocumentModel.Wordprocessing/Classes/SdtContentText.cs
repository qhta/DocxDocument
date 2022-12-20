namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the SdtContentText Class.
/// </summary>
public partial class SdtContentTextImpl: ModelElementImpl, SdtContentText
{
  public DocumentFormat.OpenXml.Wordprocessing.SdtContentText? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.SdtContentText?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public SdtContentTextImpl(): base() {}
  
  public SdtContentTextImpl(DocumentFormat.OpenXml.Wordprocessing.SdtContentText openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Allow Soft Line Breaks
  /// </summary>
  public Boolean? MultiLine
  {
    get => (System.Boolean?)OpenXmlElement?.MultiLine?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.MultiLine = (System.Boolean?)value;
    }
  }
  
}
