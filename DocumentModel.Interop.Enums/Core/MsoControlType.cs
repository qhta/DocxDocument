namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies the type of the command bar control.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msocontroltype?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Core.MsoControlType")]
public enum ControlType
{
  /// <summary>
  /// Custom control. Cannot be created through the object model.
  /// </summary>
  [InteropEnumValue("msoControlCustom")]
  Custom,
  /// <summary>
  /// Command button.
  /// </summary>
  [InteropEnumValue("msoControlButton")]
  Button,
  /// <summary>
  /// Text box.
  /// </summary>
  [InteropEnumValue("msoControlEdit")]
  Edit,
  /// <summary>
  /// Drop-down list.
  /// </summary>
  [InteropEnumValue("msoControlDropdown")]
  Dropdown,
  /// <summary>
  /// Combo box.
  /// </summary>
  [InteropEnumValue("msoControlComboBox")]
  ComboBox,
  /// <summary>
  /// Drop-down button. Cannot be created through the object model.
  /// </summary>
  [InteropEnumValue("msoControlButtonDropdown")]
  ButtonDropdown,
  /// <summary>
  /// Split drop-down list. Cannot be created through the object model.
  /// </summary>
  [InteropEnumValue("msoControlSplitDropdown")]
  SplitDropdown,
  /// <summary>
  /// OCX drop-down list. Cannot be created through the object model.
  /// </summary>
  [InteropEnumValue("msoControlOCXDropdown")]
  OCXDropdown,
  /// <summary>
  /// Generic drop-down list. Cannot be created through the object model.
  /// </summary>
  [InteropEnumValue("msoControlGenericDropdown")]
  GenericDropdown,
  /// <summary>
  /// Graphic drop-down list. Cannot be created through the object model.
  /// </summary>
  [InteropEnumValue("msoControlGraphicDropdown")]
  GraphicDropdown,
  /// <summary>
  /// Pop-up.
  /// </summary>
  [InteropEnumValue("msoControlPopup")]
  Popup,
  /// <summary>
  /// Graphic pop-up menu. Cannot be created through the object model.
  /// </summary>
  [InteropEnumValue("msoControlGraphicPopup")]
  GraphicPopup,
  /// <summary>
  /// Pop-up button. Cannot be created through the object model.
  /// </summary>
  [InteropEnumValue("msoControlButtonPopup")]
  ButtonPopup,
  /// <summary>
  /// Split button pop-up. Cannot be created through the object model.
  /// </summary>
  [InteropEnumValue("msoControlSplitButtonPopup")]
  SplitButtonPopup,
  /// <summary>
  /// Most Recently Used (MRU) pop-up. Cannot be created through the object model.
  /// </summary>
  [InteropEnumValue("msoControlSplitButtonMRUPopup")]
  SplitButtonMRUPopup,
  /// <summary>
  /// Label. Cannot be created through the object model.
  /// </summary>
  [InteropEnumValue("msoControlLabel")]
  Label,
  /// <summary>
  /// Expanding grid. Cannot be created through the object model.
  /// </summary>
  [InteropEnumValue("msoControlExpandingGrid")]
  ExpandingGrid,
  /// <summary>
  /// Split expanding grid. Cannot be created through the object model.
  /// </summary>
  [InteropEnumValue("msoControlSplitExpandingGrid")]
  SplitExpandingGrid,
  /// <summary>
  /// Grid. Cannot be created through the object model.
  /// </summary>
  [InteropEnumValue("msoControlGrid")]
  Grid,
  /// <summary>
  /// Gauge control. Cannot be created through the object model.
  /// </summary>
  [InteropEnumValue("msoControlGauge")]
  Gauge,
  /// <summary>
  /// Graphic combo box. Cannot be created through the object model.
  /// </summary>
  [InteropEnumValue("msoControlGraphicCombo")]
  GraphicCombo,
  /// <summary>
  /// Pane. Cannot be created through the object model.
  /// </summary>
  [InteropEnumValue("msoControlPane")]
  Pane,
  /// <summary>
  /// ActiveX control.
  /// </summary>
  [InteropEnumValue("msoControlActiveX")]
  ActiveX,
  /// <summary>
  /// Spinner. Cannot be created through the object model.
  /// </summary>
  [InteropEnumValue("msoControlSpinner")]
  Spinner,
  /// <summary>
  /// Extended label. Cannot be created through the object model.
  /// </summary>
  [InteropEnumValue("msoControlLabelEx")]
  LabelEx,
  /// <summary>
  /// Work pane. Cannot be created through the object model.
  /// </summary>
  [InteropEnumValue("msoControlWorkPane")]
  WorkPane,
  /// <summary>
  /// Combo box in which the first matching choice is automatically filled in as the user types. Cannot be created
  /// through the object model.
  /// </summary>
  [InteropEnumValue("msoControlAutoCompleteCombo")]
  AutoCompleteCombo
}
