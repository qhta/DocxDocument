namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies the type of the command bar control.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msocontroltype?view=office-pia` for Office interop details.
/// </remarks>
[OfficeInteropEnumType("MsoControlType")]
public enum ControlType
{
  /// <summary>
  /// Custom control. Cannot be created through the object model.
  /// </summary>
  [OfficeInteropEnumValue("msoControlCustom")]
  Custom,
  /// <summary>
  /// Command button.
  /// </summary>
  [OfficeInteropEnumValue("msoControlButton")]
  Button,
  /// <summary>
  /// Text box.
  /// </summary>
  [OfficeInteropEnumValue("msoControlEdit")]
  Edit,
  /// <summary>
  /// Drop-down list.
  /// </summary>
  [OfficeInteropEnumValue("msoControlDropdown")]
  Dropdown,
  /// <summary>
  /// Combo box.
  /// </summary>
  [OfficeInteropEnumValue("msoControlComboBox")]
  ComboBox,
  /// <summary>
  /// Drop-down button. Cannot be created through the object model.
  /// </summary>
  [OfficeInteropEnumValue("msoControlButtonDropdown")]
  ButtonDropdown,
  /// <summary>
  /// Split drop-down list. Cannot be created through the object model.
  /// </summary>
  [OfficeInteropEnumValue("msoControlSplitDropdown")]
  SplitDropdown,
  /// <summary>
  /// OCX drop-down list. Cannot be created through the object model.
  /// </summary>
  [OfficeInteropEnumValue("msoControlOCXDropdown")]
  OCXDropdown,
  /// <summary>
  /// Generic drop-down list. Cannot be created through the object model.
  /// </summary>
  [OfficeInteropEnumValue("msoControlGenericDropdown")]
  GenericDropdown,
  /// <summary>
  /// Graphic drop-down list. Cannot be created through the object model.
  /// </summary>
  [OfficeInteropEnumValue("msoControlGraphicDropdown")]
  GraphicDropdown,
  /// <summary>
  /// Pop-up.
  /// </summary>
  [OfficeInteropEnumValue("msoControlPopup")]
  Popup,
  /// <summary>
  /// Graphic pop-up menu. Cannot be created through the object model.
  /// </summary>
  [OfficeInteropEnumValue("msoControlGraphicPopup")]
  GraphicPopup,
  /// <summary>
  /// Pop-up button. Cannot be created through the object model.
  /// </summary>
  [OfficeInteropEnumValue("msoControlButtonPopup")]
  ButtonPopup,
  /// <summary>
  /// Split button pop-up. Cannot be created through the object model.
  /// </summary>
  [OfficeInteropEnumValue("msoControlSplitButtonPopup")]
  SplitButtonPopup,
  /// <summary>
  /// Most Recently Used (MRU) pop-up. Cannot be created through the object model.
  /// </summary>
  [OfficeInteropEnumValue("msoControlSplitButtonMRUPopup")]
  SplitButtonMRUPopup,
  /// <summary>
  /// Label. Cannot be created through the object model.
  /// </summary>
  [OfficeInteropEnumValue("msoControlLabel")]
  Label,
  /// <summary>
  /// Expanding grid. Cannot be created through the object model.
  /// </summary>
  [OfficeInteropEnumValue("msoControlExpandingGrid")]
  ExpandingGrid,
  /// <summary>
  /// Split expanding grid. Cannot be created through the object model.
  /// </summary>
  [OfficeInteropEnumValue("msoControlSplitExpandingGrid")]
  SplitExpandingGrid,
  /// <summary>
  /// Grid. Cannot be created through the object model.
  /// </summary>
  [OfficeInteropEnumValue("msoControlGrid")]
  Grid,
  /// <summary>
  /// Gauge control. Cannot be created through the object model.
  /// </summary>
  [OfficeInteropEnumValue("msoControlGauge")]
  Gauge,
  /// <summary>
  /// Graphic combo box. Cannot be created through the object model.
  /// </summary>
  [OfficeInteropEnumValue("msoControlGraphicCombo")]
  GraphicCombo,
  /// <summary>
  /// Pane. Cannot be created through the object model.
  /// </summary>
  [OfficeInteropEnumValue("msoControlPane")]
  Pane,
  /// <summary>
  /// ActiveX control.
  /// </summary>
  [OfficeInteropEnumValue("msoControlActiveX")]
  ActiveX,
  /// <summary>
  /// Spinner. Cannot be created through the object model.
  /// </summary>
  [OfficeInteropEnumValue("msoControlSpinner")]
  Spinner,
  /// <summary>
  /// Extended label. Cannot be created through the object model.
  /// </summary>
  [OfficeInteropEnumValue("msoControlLabelEx")]
  LabelEx,
  /// <summary>
  /// Work pane. Cannot be created through the object model.
  /// </summary>
  [OfficeInteropEnumValue("msoControlWorkPane")]
  WorkPane,
  /// <summary>
  /// Combo box in which the first matching choice is automatically filled in as the user types. Cannot be created
  /// through the object model.
  /// </summary>
  [OfficeInteropEnumValue("msoControlAutoCompleteCombo")]
  AutoCompleteCombo
}
