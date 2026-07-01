namespace DocumentModel.WebExtensions.UI;
/// <summary>
/// Represents a collection of web extension task panes in a WordprocessingML document.
/// This class provides access to and management of <see cref = "WebExtensionTaskPane"/> objects, enabling advanced integration, configuration, and display of custom task panes within the document user class.
/// </summary>
[DataContract]
[XmlRoot("TaskPanes", Namespace = "DocumentModel.WebExtensions.UI")]
public class TaskPanes : ElementCollection<WebExtensionTaskPane>
{
}