namespace DocumentModel;

public class AlternateContent: DMW.IRunElement
{
  public AlternateContentChoice? Choice { get; set; }
  public AlternateContentFallback? Fallback { get; set; }
}
