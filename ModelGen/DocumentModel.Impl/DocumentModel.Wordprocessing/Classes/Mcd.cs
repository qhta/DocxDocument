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
  
  public McdImpl(): base() {}
  
  public McdImpl(DocumentFormat.OpenXml.Office.Word.Mcd openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// macroName
  /// </summary>
  public String? MacroName
  {
    get => (String?)OpenXmlElement?.MacroName?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.MacroName = (System.String?)value;
    }
  }
  
  /// <summary>
  /// name
  /// </summary>
  public String? Name
  {
    get => (String?)OpenXmlElement?.Name?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Name = (System.String?)value;
    }
  }
  
  /// <summary>
  /// menuHelp
  /// </summary>
  public String? MenuHelp
  {
    get => (String?)OpenXmlElement?.MenuHelp?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.MenuHelp = (System.String?)value;
    }
  }
  
  /// <summary>
  /// bEncrypt
  /// </summary>
  public HexBinaryValue? BEncrypt
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// cmg
  /// </summary>
  public HexBinaryValue? Cmg
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
