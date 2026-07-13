namespace DocumentModel;

/// <summary>
/// Interface representing a color that can be specified by name.
/// </summary>
public interface INamedColor
{

  /// <summary>
  /// Gets or sets the name of color. May be used to specify a color by name, such as "red", "blue", etc.
  /// The actual interpretation of the name depends on the context in which it is used and may be mapped to a specific RGB value or theme color.
  /// </summary>
  public string? Name { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
}