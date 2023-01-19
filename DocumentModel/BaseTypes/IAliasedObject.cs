namespace DocumentModel;

public interface IAliasedObject
{
  public IEnumerable<string>? Aliases { get; }
}