namespace DocumentModel.CustomUI;

/// <summary>
/// Represents a collection of custom controls that can be added to the Quick Access Toolbar (QAT) at the application level, shared across all documents for enhanced productivity and workflow efficiency.
/// </summary>
/// <remarks>
/// This interface defines application-level QAT customization, enabling the addition of shared controls, cloned Office commands, and separators that persist across all documents and sessions. It supports streamlined, single-click operations and complements document-level QAT customizations for global workflows, add-in integration, and user preferences.
/// </remarks>
public interface QatItemsCollection: ElementCollection<QatItem>
{

}