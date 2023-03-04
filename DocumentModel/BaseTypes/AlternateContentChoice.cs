namespace DocumentModel;

[JsonObject]
public class AlternateContentChoice: ElementCollection<ModelElement>
{
  public string? Requires { get;set; }
}
