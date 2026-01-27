namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents extended style definition information for a Wordprocessing document.
/// Provides properties for the primary style name, alternative names (aliases), and status flags, enabling advanced management and customization of style definitions. Implements aliasing and property state checks.
/// </summary>
public partial class StyleDef : IAliasedObject
{
  /// <summary>
  /// The primary style name associated with this style definition.
  /// </summary>
  public string? Name { get; set; }
  
  /// <summary>
  /// Indicates whether any properties are defined for this style.
  /// </summary>
  public bool? IsDefined { get; set; }
  
  /// <summary>
  /// Indicates whether suitable properties are defined for specific style types (e.g., paragraph, character, table, or numbering styles).
  /// </summary>
  public bool? IsVl { get; set; }

  /// <summary>
  /// Collection of alternative names (aliases) for this style, supporting style lookup and mapping.
  /// </summary>
  public Collection<string>? Aliases { get; set; }

  /// <summary>
  /// Enumerates all alternative names (aliases) for this style, as required by the <see cref="IAliasedObject"/> interface.
  /// </summary>
  IEnumerable<string>? IAliasedObject.Aliases => Aliases;

  /// <summary>
  /// Determines whether the specified <see cref="StyleDef"/> is equal to the current style definition.
  /// </summary>
  /// <param name="other">The style definition to compare with the current instance.</param>
  /// <returns>True if the style definitions are considered equal; otherwise, false.</returns>
  public bool Equals(StyleDef? other)
  {
    throw new NotImplementedException();
  }
}