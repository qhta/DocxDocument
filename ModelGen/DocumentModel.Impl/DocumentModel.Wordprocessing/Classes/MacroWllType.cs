namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the MacroWllType Class.
/// </summary>
public partial class MacroWllTypeImpl: ModelElementImpl, MacroWllType
{
  public DocumentFormat.OpenXml.Office.Word.MacroWllType? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office.Word.MacroWllType?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public MacroWllTypeImpl(): base() {}
  
  public MacroWllTypeImpl(DocumentFormat.OpenXml.Office.Word.MacroWllType openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// macroName
  /// </summary>
  public String? MacroName
  {
    get => (System.String?)OpenXmlElement?.MacroName?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.MacroName = (System.String?)value;
    }
  }
  
}
