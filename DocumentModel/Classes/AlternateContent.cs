namespace DocumentModel;

public class AlternateContent: ModelElement, DMW.IRunElement
{
    public AlternateContentChoice? Choice { get; set; }
    public AlternateContentFallback? Fallback { get; set; }
}
