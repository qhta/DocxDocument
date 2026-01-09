namespace DocumentModel;

/// <summary>
/// Represents a collection of custom controls that can be added to the Quick Access Toolbar (QAT) in Office applications at the document level, supporting document-specific commands, workflow optimization, and enhanced productivity.
/// </summary>
/// <remarks>
/// This interface defines document-level QAT customization, enabling the addition of custom controls, cloned Office commands, and separators that appear only when a specific document is open. It supports streamlined, single-click operations and complements application-level QAT customizations for specialized workflows, templates, and productivity scenarios.
/// </remarks>
public interface DocumentControlsQatItems
{
  /// <summary>
  /// Reference to a built-in Office control to clone and add to the Quick Access Toolbar.
  /// </summary>
  public ControlCloneQat? ControlCloneQat { get; set; }

  /// <summary>
  /// Custom button control to add to the Quick Access Toolbar.
  /// </summary>
  public ButtonRegular? ButtonRegular { get; set; }

  /// <summary>
  /// Visual separator to organize and group related commands in the Quick Access Toolbar.
  /// </summary>
  public Separator? Separator { get; set; }
}