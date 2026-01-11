namespace DocumentModel.WebExtensions.UI;

/// <summary>
/// Represents a collection of web extension task panes in a WordprocessingML document.
/// This interface provides access to and management of <see cref="WebExtensionTaskPane"/> objects, enabling advanced integration, configuration, and display of custom task panes within the document user interface.
/// </summary>
public interface TaskPanes : ElementCollection<WebExtensionTaskPane>
{
}