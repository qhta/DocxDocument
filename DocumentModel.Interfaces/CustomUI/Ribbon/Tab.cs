namespace DocumentModel;

/// <summary>
/// Represents a tab in the Office ribbon interface that organizes groups of related commands and controls, supporting dynamic labeling, positioning, and advanced callback integration for Office UI extensibility.
/// </summary>
/// <remarks>
/// This interface defines a ribbon tab for Office applications, enabling organization of commands into logical groups. Tabs can be custom, built-in, or contextual, and support dynamic label, visibility, and keytip through callbacks. The interface allows precise positioning relative to built-in or custom tabs and supports integration of groups for efficient workflows and discoverable UI.
/// </remarks>
public interface Tab : CustomUIControl, BuiltInControl, TaggedObject,
    VisibleControl, LabelledControl, KeytipControl
{

  /// <summary>
  /// Group or collection of groups contained within this tab.
  /// </summary>
  public Group? Group { get; set; }
}