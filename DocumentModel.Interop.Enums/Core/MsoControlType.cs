namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies the type of the command bar control.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msocontroltype?view=office-pia` for Office interop details.
/// </remarks>
public enum MsoControlType
{
  /// <summary>
  /// Custom control. Cannot be created through the object model.
  /// </summary>
  Custom,
  /// <summary>
  /// Command button.
  /// </summary>
  Button,
  /// <summary>
  /// Text box.
  /// </summary>
  Edit,
  /// <summary>
  /// Drop-down list.
  /// </summary>
  Dropdown,
  /// <summary>
  /// Combo box. msoControlButtonDropdown5 Drop-down button. Cannot be created through the object model.
  /// </summary>
  ComboBox,
  /// <summary>
  /// Specifies the type of the command bar control.
  /// </summary>
  ButtonDropdown,
  /// <summary>
  /// Split drop-down list. Cannot be created through the object model.
  /// </summary>
  SplitDropdown,
  /// <summary>
  /// OCX drop-down list. Cannot be created through the object model. msoControlGenericDropdown8 Generic drop-down
  /// list. Cannot be created through the object model. msoControlGraphicDropdown9 Graphic drop-down list. Cannot be
  /// created through the object model. public enum class MsoControlType ﾉ Expand table
  /// </summary>
  OCXDropdown,
  /// <summary>
  /// Specifies the type of the command bar control.
  /// </summary>
  GenericDropdown,
  /// <summary>
  /// Specifies the type of the command bar control.
  /// </summary>
  GraphicDropdown,
  /// <summary>
  /// Pop-up.
  /// </summary>
  Popup,
  /// <summary>
  /// Graphic pop-up menu. Cannot be created through the object model.
  /// </summary>
  GraphicPopup,
  /// <summary>
  /// Pop-up button. Cannot be created through the object model.
  /// </summary>
  ButtonPopup,
  /// <summary>
  /// Split button pop-up. Cannot be created through the object model.
  /// </summary>
  SplitButtonPopup,
  /// <summary>
  /// Most Recently Used (MRU) pop-up. Cannot be created through the object model.
  /// </summary>
  SplitButtonMRUPopup,
  /// <summary>
  /// Label. Cannot be created through the object model.
  /// </summary>
  Label,
  /// <summary>
  /// Expanding grid. Cannot be created through the object model. msoControlSplitExpandingGrid17 Split expanding
  /// grid. Cannot be created through the object model.
  /// </summary>
  ExpandingGrid,
  /// <summary>
  /// Specifies the type of the command bar control.
  /// </summary>
  SplitExpandingGrid,
  /// <summary>
  /// Grid. Cannot be created through the object model.
  /// </summary>
  Grid,
  /// <summary>
  /// Gauge control. Cannot be created through the object model.
  /// </summary>
  Gauge,
  /// <summary>
  /// Graphic combo box. Cannot be created through the object model.
  /// </summary>
  GraphicCombo,
  /// <summary>
  /// Pane. Cannot be created through the object model.
  /// </summary>
  Pane,
  /// <summary>
  /// ActiveX control.
  /// </summary>
  ActiveX,
  /// <summary>
  /// Spinner. Cannot be created through the object model.
  /// </summary>
  Spinner,
  /// <summary>
  /// Extended label. Cannot be created through the object model.
  /// </summary>
  LabelEx,
  /// <summary>
  /// Work pane. Cannot be created through the object model. msoControlAutoCompleteCombo26 Combo box in which the
  /// first matching choice is automatically filled in as the user types. Cannot be created through the object
  /// model.
  /// </summary>
  WorkPane,
  /// <summary>
  /// Specifies the type of the command bar control.
  /// </summary>
  AutoCompleteCombo
}
