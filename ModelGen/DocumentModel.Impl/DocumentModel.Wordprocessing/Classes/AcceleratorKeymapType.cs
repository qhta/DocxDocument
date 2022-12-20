namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the AcceleratorKeymapType Class.
/// </summary>
public partial class AcceleratorKeymapTypeImpl: ModelElementImpl, AcceleratorKeymapType
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Office.Word.AcceleratorKeymapType? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office.Word.AcceleratorKeymapType?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public AcceleratorKeymapTypeImpl(): base() {}
  
  public AcceleratorKeymapTypeImpl(DocumentFormat.OpenXml.Office.Word.AcceleratorKeymapType openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// acdName
  /// </summary>
  public String? AcceleratorName
  {
    get => (System.String?)OpenXmlElement?.AcceleratorName?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.AcceleratorName = (System.String?)value;
    }
  }
  
}
