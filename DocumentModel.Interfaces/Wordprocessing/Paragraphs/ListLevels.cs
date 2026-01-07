namespace DocumentModel.Wordprocessing;

/// <summary>
///   Represents a collection of list levels in a list template.
/// </summary>
public interface ListLevels : ElementCollection<ListLevel>
{
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