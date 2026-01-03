namespace DocumentModel;

/// <summary>
///   Represents a collection of contextual tab sets that appear dynamically in the ribbon UI based on user context or selection.
/// </summary>
/// <remarks>
///   This interface extends <see cref="IModelElement"/> and defines a container for contextual tab sets that provide
///   context-sensitive commands and tools in Office applications. Contextual tabs are special ribbon tabs that appear
///   automatically when users select specific objects or enter particular contexts (such as selecting a table, image,
///   chart, or shape in a document). Unlike standard tabs that are always visible, contextual tabs provide focused
///   functionality relevant to the current selection or context, reducing ribbon clutter while ensuring necessary tools
///   are readily available when needed. Each contextual tab set can contain multiple related tabs grouped under a
///   common label and typically displayed with a distinctive color to indicate their contextual nature. The collection
///   enables add-ins to define multiple contextual tab sets for different object types or scenarios within the same
///   Office application. This approach enhances user productivity by presenting relevant commands at the right time
///   without overwhelming the standard ribbon interface with specialized tools that are only occasionally needed.
///   Contextual tabs automatically hide when the user deselects the triggering object or exits the associated context.
/// </remarks>
public interface ContextualTabs : IModelElement
{
  /// <summary>
  ///   Gets or sets the collection of tab sets that define contextual ribbon tabs.
  /// </summary>
  /// <value>
  ///   A collection of <see cref="TabSet"/> objects defining contextual tab groups,
  ///   or <c>null</c> if no contextual tabs are defined.
  /// </value>
  /// <remarks>
  ///   Each <see cref="TabSet"/> in the collection defines a group of related contextual tabs that appear together
  ///   under a common label in the ribbon. Tab sets typically correspond to specific object types or application
  ///   contexts (such as "Table Tools", "Picture Tools", or "Chart Tools" in native Office applications). The tab
  ///   set structure allows related functionality to be organized into multiple tabs while maintaining a clear
  ///   relationship through shared labeling and visual styling. Multiple tab sets can be defined to support various
  ///   contextual scenarios, with each tab set activating based on its specific trigger conditions. When multiple
  ///   contextual tab sets could apply simultaneously (such as selecting a table within a text box), Office determines
  ///   which tab sets to display based on selection hierarchy and context precedence rules.
  /// </remarks>
  public Collection<TabSet>? TabSets { get; set; }
}