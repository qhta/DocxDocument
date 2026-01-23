namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents extended style definition information for a Wordprocessing document.
/// This class provides properties for the primary style name, alternative names, and status flags, enabling advanced management and customization of style definitions. Implements aliasing and property state checks.
/// </summary>
public partial class StyleDef : IAliasedObject
{
  
  /// <summary>
  /// Primary style name associated with the style definition.
  /// </summary>
  public string? Name { get; set; }
  
  /// <summary>
  /// Determines whether any properties are defined for the style.
  /// </summary>
  public bool? IsDefined { get; set; }
  
  /// <summary>
  /// Determines whether suitable properties are defined for specific style types.
  /// </summary>
  public bool? IsVl { get; set; }

  public Collection<string>? Aliases { get; set; }

  IEnumerable<string>? IAliasedObject.Aliases => Aliases;

  public bool Equals(StyleDef? other)
  {
    throw new NotImplementedException();
  }
}