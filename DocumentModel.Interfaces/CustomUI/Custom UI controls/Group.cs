namespace DocumentModel.CustomUI;

/// <summary>
/// Represents a group container for organizing related controls within a ribbon tab, supporting dynamic state, visual customization, and advanced layout for Office UI scenarios.
/// </summary>
/// <remarks>
/// Groups are the main organizational unit in the ribbon, containing collections of related commands, buttons, galleries, and other controls. This interface supports dynamic labeling, images, tooltips, scaling, and dialog box launchers for flexible and adaptive ribbon layouts.
/// </remarks>
public interface Group : CustomUIControl, BuiltInObject, TaggedObject, 
  VisibleControl,
  LabelledControl, ImagedControl,
  ScreentipControl, SupertipControl, KeytipControl,
  BoxContent,
  GroupContentCollection
{

  /// <summary>
  /// Enable automatic scaling of controls when ribbon space is limited.
  /// </summary>
  public bool? AutoScale { get; set; }

  /// <summary>
  /// Vertically center controls in the group.
  /// </summary>
  public bool? CenterVertically { get; set; }

  /// <summary>
  /// Cloned instance of a built-in or custom control.
  /// </summary>
  public ControlClone? ControlClone { get; set; }

   /// <summary>
  /// Dialog box launcher for accessing additional options or settings.
  /// </summary>
  public DialogBoxLauncher? DialogBoxLauncher { get; set; }

}