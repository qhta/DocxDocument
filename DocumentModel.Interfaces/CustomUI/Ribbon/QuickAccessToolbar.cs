namespace DocumentModel;

/// <summary>
/// Represents the Quick Access Toolbar (QAT) customization for the Office ribbon, supporting shared and document-specific controls for enhanced productivity and user experience.
/// </summary>
/// <remarks>
/// This interface defines the structure for customizing the Quick Access Toolbar in Office applications. It enables the addition of shared controls available across all documents and document-specific controls for contextual customization. The interface supports flexible arrangement and integration of frequently used commands, improving workflow efficiency and accessibility in the Office ribbon UI.
/// </remarks>
public interface QuickAccessToolbar
{
  /// <summary>
  /// Collection of shared controls displayed in the Quick Access Toolbar for all documents.
  /// </summary>
  public SharedControlsQatItems? SharedControlsQatItems { get; set; }

  /// <summary>
  /// Collection of document-specific controls displayed in the Quick Access Toolbar.
  /// </summary>
  public DocumentControlsQatItems? DocumentControlsQatItems { get; set; }
}