namespace DocumentModel;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

public class AlternateContent: ModelElement, DMW.IRunContent
{
    public AlternateContentChoice? Choice { get; set; }
    public AlternateContentFallback? Fallback { get; set; }
}
