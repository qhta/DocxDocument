namespace DocumentModel.Wordprocessing;

/// <summary>
///   Represents a single list template that contains all the formatting attributes
///   that make up a list.
/// </summary>
/// <remarks>
///   A list template contains all nine outline levels, each with its own formatting
///   such as number style, starting number, position, and font.
/// </remarks>
public interface ListTemplate
{
  #region Properties

  /// <summary>
  ///   Gets the name of the list template.
  /// </summary>
  public string? Name { get; }

  /// <summary>
  ///   Gets whether the list template is an outline numbered list.
  /// </summary>
  public bool OutlineNumbered { get; }

  /// <summary>
  ///   Gets the collection of list levels (1-9) in the template.
  /// </summary>
  public ListLevels? ListLevels { get; }

  #endregion

  #region Methods

  /// <summary>
  ///   Converts the list template to a regular template.
  /// </summary>
  /// <param name="replace">Whether to replace the existing template.</param>
  public void Convert(bool replace = false);

  #endregion

  #region Parent Properties

  /// <summary>
  ///   Gets the parent object.
  /// </summary>
  public object? Parent { get; }

  /// <summary>
  ///   Gets the application object.
  /// </summary>
  public Application? Application { get; }

  #endregion
}