namespace DocumentModel;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

public class AlternateContent: ModelElement, DMW.IRunElement
{
    public AlternateContentChoice? Choice { get; set; }
    public AlternateContentFallback? Fallback { get; set; }
}
