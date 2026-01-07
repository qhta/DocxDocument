namespace DocumentModel.Wordprocessing;

/// <summary>
///   Represents a collection of bibliographic sources.
/// </summary>
public interface Sources : ElementCollection<Source>
{
  /// <summary>
  ///   Removes a source by its tag identifier.
  /// </summary>
  /// <param name="tag">The unique tag of the source to remove.</param>
  /// <returns>True if the source was found and removed.</returns>
  public bool Remove(string tag);

  /// <summary>
  ///   Gets a source by its tag identifier.
  /// </summary>
  /// <param name="tag">The unique tag of the source.</param>
  /// <returns>The source if found, otherwise null.</returns>
  public Source? GetByTag(string tag);

  /// <summary>
  ///   Checks if a source with the specified tag exists.
  /// </summary>
  /// <param name="tag">The tag to check.</param>
  /// <returns>True if a source with the tag exists.</returns>
  public bool Contains(string tag);

  /// <summary>
  ///   Gets all sources of a specific type.
  /// </summary>
  /// <param name="sourceType">The type of sources to retrieve.</param>
  /// <returns>Collection of sources of the specified type.</returns>
  public IEnumerable<Source> GetByType(SourceTypeKind sourceType);

  /// <summary>
  ///   Sorts the sources by a specified criteria.
  /// </summary>
  /// <param name="sortBy">The sorting criteria.</param>
  /// <param name="ascending">Whether to sort in ascending order.</param>
  public void Sort(SourceSortKind sortBy, bool ascending = true);
}