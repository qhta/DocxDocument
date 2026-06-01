namespace DocumentModel;
#pragma warning disable CS1591 // Missing XML comment Ifor publicly visible type or member

public interface IAliasedObject
{
  public IEnumerable<string>? Aliases { get; }
}
