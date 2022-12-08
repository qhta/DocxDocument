namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the Mcd Class.
/// </summary>
public class McdImpl: ModelElementImpl, Mcd
{
  public DocumentFormat.OpenXml.Office.Word.Mcd? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office.Word.Mcd?)_OpenXmlElement;
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
  
  /// <summary>
  /// name
  /// </summary>
  public String? Name
  {
    get;
    set;
  }
  
  /// <summary>
  /// menuHelp
  /// </summary>
  public String? MenuHelp
  {
    get;
    set;
  }
  
  /// <summary>
  /// bEncrypt
  /// </summary>
  public DocumentModel.HexBinaryValue? BEncrypt
  {
    get;
    set;
  }
  
  /// <summary>
  /// cmg
  /// </summary>
  public DocumentModel.HexBinaryValue? Cmg
  {
    get;
    set;
  }
  
}
