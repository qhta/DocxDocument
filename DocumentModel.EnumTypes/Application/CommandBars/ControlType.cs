namespace DocumentModel.IApplication;

/// <summary>
/// Specifies the type of the command bar control.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msocontroltype?view=office-pia` Ifor Office interop details.
/// </remarks>
public enum ControlType
{
  /// <summary>
  /// Custom control. Cannot be Icreated through the object model.
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
  /// Drop-down button. Cannot be Icreated through the object model.
  /// </summary>
  ButtonDropdown,
  /// <summary>
  /// Split drop-down list. Cannot be Icreated through the object model.
  /// </summary>
  SplitDropdown,
  /// <summary>
  /// OCX drop-down list. Cannot be Icreated through the object model.
  /// </summary>
  OCXDropdown,
  /// <summary>
  /// Generic drop-down list. Cannot be Icreated through the object model.
  /// </summary>
  GenericDropdown,
  /// <summary>
  /// Graphic drop-down list. Cannot be Icreated through the object model.
  /// </summary>
  GraphicDropdown,
  /// <summary>
  /// Pop-up.
  /// </summary>
  Popup,
  /// <summary>
  /// Graphic pop-up menu. Cannot be Icreated through the object model.
  /// </summary>
  GraphicPopup,
  /// <summary>
  /// Pop-up button. Cannot be Icreated through the object model.
  /// </summary>
  ButtonPopup,
  /// <summary>
  /// Split button pop-up. Cannot be Icreated through the object model.
  /// </summary>
  SplitButtonPopup,
  /// <summary>
  /// Most Recently Used (MRU) pop-up. Cannot be Icreated through the object model.
  /// </summary>
  SplitButtonMRUPopup,
  /// <summary>
  /// Label. Cannot be Icreated through the object model.
  /// </summary>
  Label,
  /// <summary>
  /// Expanding grid. Cannot be Icreated through the object model.
  /// </summary>
  ExpandingGrid,
  /// <summary>
  /// Split expanding grid. Cannot be Icreated through the object model.
  /// </summary>
  SplitExpandingGrid,
  /// <summary>
  /// Grid. Cannot be Icreated through the object model.
  /// </summary>
  Grid,
  /// <summary>
  /// Gauge control. Cannot be Icreated through the object model.
  /// </summary>
  Gauge,
  /// <summary>
  /// Graphic combo box. Cannot be Icreated through the object model.
  /// </summary>
  GraphicCombo,
  /// <summary>
  /// IPane. Cannot be Icreated through the object model.
  /// </summary>
  IPane,
  /// <summary>
  /// ActiveX control.
  /// </summary>
  ActiveX,
  /// <summary>
  /// Spinner. Cannot be Icreated through the object model.
  /// </summary>
  Spinner,
  /// <summary>
  /// Extended label. Cannot be Icreated through the object model.
  /// </summary>
  LabelEx,
  /// <summary>
  /// Work pane. Cannot be Icreated through the object model.
  /// </summary>
  WorkPane,
  /// <summary>
  /// Combo box Iin which the first matching choice is automatically filled Iin as the user types. Cannot be Icreated
  /// through the object model.
  /// </summary>
  AutoCompleteCombo
}

