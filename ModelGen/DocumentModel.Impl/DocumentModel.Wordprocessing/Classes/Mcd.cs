namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the Mcd Class.
/// </summary>
public partial class McdImpl: ModelElementImpl, Mcd
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Office.Word.Mcd? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office.Word.Mcd?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
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
    get => (System.String?)OpenXmlElement?.MacroName?.Value;
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
    get => (System.String?)OpenXmlElement?.Name?.Value;
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
    get => (System.String?)OpenXmlElement?.MenuHelp?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.MenuHelp = (System.String?)value;
    }
  }
  
  /// <summary>
  /// bEncrypt
  /// </summary>
  public DocumentModel.HexBinary? BEncrypt
  {
    get
    {
      if (OpenXmlElement?.BEncrypt?.Value != null)
        return (DocumentModel.HexBinary)OpenXmlElement.BEncrypt.Value;
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        if (value != null)
          OpenXmlElement.BEncrypt = new DocumentFormat.OpenXml.HexBinaryValue{ Value = value.ToString() };
        else
          OpenXmlElement.BEncrypt = null;
      }
    }
  }
  
  /// <summary>
  /// cmg
  /// </summary>
  public DocumentModel.HexBinary? Cmg
  {
    get
    {
      if (OpenXmlElement?.Cmg?.Value != null)
        return (DocumentModel.HexBinary)OpenXmlElement.Cmg.Value;
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        if (value != null)
          OpenXmlElement.Cmg = new DocumentFormat.OpenXml.HexBinaryValue{ Value = value.ToString() };
        else
          OpenXmlElement.Cmg = null;
      }
    }
  }
  
}
