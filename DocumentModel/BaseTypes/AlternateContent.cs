namespace DocumentModel;

public class AlternateContent: DM.ModelElement, DMW.IRunElement
{
  public AlternateContentChoice? Choice { get; set; }
  public AlternateContentFallback? Fallback { get; set; }
}
