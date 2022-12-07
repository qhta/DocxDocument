namespace DocumentModel.Wordprocessing;

/// <summary>
/// Caption Settings.
/// </summary>
public class CaptionsImpl: ModelElement<DocumentFormat.OpenXml.Wordprocessing.Captions>, Captions
{
  public AutoCaptions? AutoCaptions
  {
    get;
    set;
  }
  
}
