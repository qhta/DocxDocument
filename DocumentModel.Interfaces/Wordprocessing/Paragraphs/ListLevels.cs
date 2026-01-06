namespace DocumentModel.Wordprocessing;

/// <summary>
///   Represents a collection of list levels in a list template.
/// </summary>
public interface ListLevels : ElementCollection<ListLevel>
{
  #region Collection Properties

  /// <summary>
  ///   Gets the number of list levels in the collection (always 9).
  /// </summary>
  public int Count { get; }

  #endregion

  #region Item Access

  /// <summary>
  ///   Gets a list level by its index (1-9).
  /// </summary>
  /// <param name="index">The one-based index of the list level.</param>
  /// <returns>The list level at the specified index.</returns>
  public ListLevel? Item(int index);

  #endregion

  #region Parent Properties

  /// <summary>
  ///   Gets the parent list template.
  /// </summary>
  public ListTemplate? Parent { get; }

  /// <summary>
  ///   Gets the application object.
  /// </summary>
  public Application? Application { get; }

  #endregion
}