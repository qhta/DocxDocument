namespace DocumentModel.Drawings;

/// <summary>
/// Legend Entry.
/// </summary>
public class LegendEntryImpl: ModelElementImpl, LegendEntry
{
  public DocumentFormat.OpenXml.Drawing.Charts.LegendEntry? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.LegendEntry?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// Index.
  /// </summary>
  public UInt32? Index
  {
    get;
    set;
  }
  
  public Boolean? Delete
  {
    get;
    set;
  }
  
  public TextProperties2? TextProperties
  {
    get;
    set;
  }
  
  public ExtensionList4? ExtensionList
  {
    get;
    set;
  }
  
}
