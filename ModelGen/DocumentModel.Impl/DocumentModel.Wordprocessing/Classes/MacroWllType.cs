namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the MacroWllType Class.
/// </summary>
public class MacroWllTypeImpl: ModelElementImpl, MacroWllType
{
  public DocumentFormat.OpenXml.Office.Word.MacroWllType? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office.Word.MacroWllType?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// macroName
  /// </summary>
  public String? MacroName
  {
    get;
    set;
  }
  
}
