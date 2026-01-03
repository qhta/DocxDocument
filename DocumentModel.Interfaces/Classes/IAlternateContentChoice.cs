namespace DocumentModel;

/// <summary>
/// Collection of alternate content items selected when the specified Requires condition is met.
/// </summary>
public interface IAlternateContentChoice : IElementCollection<ICollectionItem>, ICollectionItem
{
  /// <summary>
  /// Condition that must be met for this choice to be selected.
  /// </summary>
  public string? Requires { get; set; }
}
