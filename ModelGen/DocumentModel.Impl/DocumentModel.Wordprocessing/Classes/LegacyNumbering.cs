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
  
  /// <summary>
  /// Use Legacy Numbering Properties
  /// </summary>
  public Boolean? Legacy
  {
    get;
    set;
  }
  
  /// <summary>
  /// Legacy Spacing
  /// </summary>
  public String? LegacySpace
  {
    get;
    set;
  }
  
  /// <summary>
  /// Legacy Indent
  /// </summary>
  public String? LegacyIndent
  {
    get;
    set;
  }
  
}
