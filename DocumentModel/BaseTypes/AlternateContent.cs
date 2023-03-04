namespace DocumentModel;

public class AlternateContent: DMW.RunElement
{
  public AlternateContentChoice? Choice { get; set; }
  public AlternateContentFallback? Fallback { get; set; }
}
