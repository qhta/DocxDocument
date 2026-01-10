namespace DocumentModel.CustomUI;

/// <summary>
/// Represents a collection of commands that define custom actions, behaviors, and event handlers
/// for Office ribbon controls, task panes, and other UI elements. Commands provide the bridge between
/// user interface controls and the application logic that executes when users interact with custom
/// Office add-in features.
/// </summary>
public interface Commands: ElementCollection<Command>
{
}
