namespace DocumentModel.Wordprocessing;
/// <summary>
/// Represents extended style definition information for a Wordprocessing document.
/// Provides properties for the primary style name, alternative names (aliases), and status flags, enabling advanced management and customization of style definitions. Implements aliasing and property state checks.
/// </summary>
public partial class StyleDefinition : IAliasedObject
{
 ///// <summary>
 ///// The primary style name associated with this style definition.
 ///// </summary>
 //public string? Name { get; set; }
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
 /// Enumerates all alternative names (aliases) for this style, as required by the <see cref = "IAliasedObject"/> interface.
 /// </summary>
 IEnumerable<string>? IAliasedObject.Aliases => Aliases;

}
