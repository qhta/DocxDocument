namespace DocumentModel.Wordprocessing;

/// <summary>
/// Legacy Numbering Level Properties.
/// </summary>
public class LegacyNumberingImpl: ModelElementImpl, LegacyNumbering
{
  public DocumentFormat.OpenXml.Wordprocessing.LegacyNumbering? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.LegacyNumbering?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public LegacyNumberingImpl(): base() {}
  
  public LegacyNumberingImpl(DocumentFormat.OpenXml.Wordprocessing.LegacyNumbering openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Use Legacy Numbering Properties
  /// </summary>
  public Boolean? Legacy
  {
    get => (System.Boolean?)OpenXmlElement?.Legacy?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Legacy = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// Legacy Spacing
  /// </summary>
  public String? LegacySpace
  {
    get => (System.String?)OpenXmlElement?.LegacySpace?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.LegacySpace = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Legacy Indent
  /// </summary>
  public String? LegacyIndent
  {
    get => (System.String?)OpenXmlElement?.LegacyIndent?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.LegacyIndent = (System.String?)value;
    }
  }
  
}
