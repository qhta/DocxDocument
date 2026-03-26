namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies the type of the command bar control.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msocontroltype?view=office-pia` for Office interop details.
/// </remarks>
public enum ControlType
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
  /// Combo box.
  /// </summary>
  ComboBox,
  /// <summary>
  /// Drop-down button. Cannot be created through the object model.
  /// </summary>
  ButtonDropdown,
  /// <summary>
  /// Split drop-down list. Cannot be created through the object model.
  /// </summary>
  SplitDropdown,
  /// <summary>
  /// OCX drop-down list. Cannot be created through the object model.
  /// </summary>
  OCXDropdown,
  /// <summary>
  /// Generic drop-down list. Cannot be created through the object model.
  /// </summary>
  GenericDropdown,
  /// <summary>
  /// Graphic drop-down list. Cannot be created through the object model.
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
  /// Expanding grid. Cannot be created through the object model.
  /// </summary>
  ExpandingGrid,
  /// <summary>
  /// Split expanding grid. Cannot be created through the object model.
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
  /// Work pane. Cannot be created through the object model.
  /// </summary>
  WorkPane,
  /// <summary>
  /// Combo box in which the first matching choice is automatically filled in as the user types. Cannot be created
  /// through the object model.
  /// </summary>
  AutoCompleteCombo
}
