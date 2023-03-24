namespace DocumentModel;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

[JsonObject]
public class AlternateContentChoice : ElementCollection<ModelElement>
{
    public string? Requires { get; set; }
}
