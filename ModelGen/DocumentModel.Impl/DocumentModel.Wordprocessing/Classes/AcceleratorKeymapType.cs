namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the AcceleratorKeymapType Class.
/// </summary>
public class AcceleratorKeymapTypeImpl: ModelElementImpl, AcceleratorKeymapType
{
  public DocumentFormat.OpenXml.Office.Word.AcceleratorKeymapType? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office.Word.AcceleratorKeymapType?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// acdName
  /// </summary>
  public String? AcceleratorName
  {
    get => (String?)OpenXmlElement?.AcceleratorName?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.AcceleratorName = (System.String?)value;
    }
  }
  
}
