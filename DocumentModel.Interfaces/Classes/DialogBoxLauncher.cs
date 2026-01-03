namespace DocumentModel;

/// <summary>
///   Represents a dialog box launcher button that appears in the lower-right corner of ribbon groups.
/// </summary>
/// <remarks>
///   This interface extends <see cref="IModelElement"/> and defines a dialog box launcher element that provides
///   access to a dialog box or task pane related to a ribbon group's functionality. Dialog box launchers are
///   small arrow buttons that appear in the lower-right corner of ribbon groups, offering users a way to access
///   additional options, settings, or features that don't fit within the group's main controls. When clicked,
///   the launcher typically opens a dialog box, task pane, or backstage view that provides more comprehensive
///   access to the group's functionality. This is particularly useful for groups that contain frequently used
///   commands on the ribbon but also offer advanced options or detailed configuration that would clutter the
///   ribbon if displayed directly. The dialog box launcher contains a <see cref="ButtonRegular"/> control that
///   defines its behavior, appearance, and the action to perform when clicked. This approach enables consistent
///   user experience across Office applications, where users expect to find additional options via the small
///   arrow button at the bottom of groups. Dialog box launchers are optional and should be used judiciously to
///   provide access to truly supplementary functionality rather than essential commands.
/// </remarks>
public interface DialogBoxLauncher : IModelElement
{
  /// <summary>
  ///   Gets or sets the button control that defines the dialog box launcher's behavior and appearance.
  /// </summary>
  /// <remarks>
  ///   The ButtonRegular control provides all the properties needed to define the dialog box launcher,
  ///   including the action to perform when clicked (onAction callback), screentip and supertip for
  ///   describing the launcher's purpose, and enabled/visible state management. The button is automatically
  ///   styled as a small arrow icon in the group's lower-right corner, so explicit image properties are
  ///   typically not needed. The onAction callback should open the appropriate dialog, task pane, or
  ///   backstage view that provides the extended functionality for the ribbon group.
  /// </remarks>
  public ButtonRegular? ButtonRegular { get; set; }
}