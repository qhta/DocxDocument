namespace DocumentModel.Drawings;

/// <summary>
/// Legend Entry.
/// </summary>
public class LegendEntryImpl: ModelElement<DocumentFormat.OpenXml.Drawing.Charts.LegendEntry>, LegendEntry
{
  public TextProperties1? TextProperties
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
