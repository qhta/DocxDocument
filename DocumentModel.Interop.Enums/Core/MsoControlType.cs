namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies the type of the command bar control.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msocontroltype?view=office-pia` for Office interop details.
/// </remarks>
[OfficeInteropEnumType(typeof(Microsoft.Office.Core.MsoControlType))]
public enum ControlType
{
  /// <summary>
  /// Custom control. Cannot be created through the object model.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoControlType.msoControlCustom))]
  Custom,
  /// <summary>
  /// Command button.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoControlType.msoControlButton))]
  Button,
  /// <summary>
  /// Text box.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoControlType.msoControlEdit))]
  Edit,
  /// <summary>
  /// Drop-down list.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoControlType.msoControlDropdown))]
  Dropdown,
  /// <summary>
  /// Combo box.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoControlType.msoControlComboBox))]
  ComboBox,
  /// <summary>
  /// Drop-down button. Cannot be created through the object model.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoControlType.msoControlButtonDropdown))]
  ButtonDropdown,
  /// <summary>
  /// Split drop-down list. Cannot be created through the object model.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoControlType.msoControlSplitDropdown))]
  SplitDropdown,
  /// <summary>
  /// OCX drop-down list. Cannot be created through the object model.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoControlType.msoControlOCXDropdown))]
  OCXDropdown,
  /// <summary>
  /// Generic drop-down list. Cannot be created through the object model.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoControlType.msoControlGenericDropdown))]
  GenericDropdown,
  /// <summary>
  /// Graphic drop-down list. Cannot be created through the object model.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoControlType.msoControlGraphicDropdown))]
  GraphicDropdown,
  /// <summary>
  /// Pop-up.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoControlType.msoControlPopup))]
  Popup,
  /// <summary>
  /// Graphic pop-up menu. Cannot be created through the object model.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoControlType.msoControlGraphicPopup))]
  GraphicPopup,
  /// <summary>
  /// Pop-up button. Cannot be created through the object model.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoControlType.msoControlButtonPopup))]
  ButtonPopup,
  /// <summary>
  /// Split button pop-up. Cannot be created through the object model.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoControlType.msoControlSplitButtonPopup))]
  SplitButtonPopup,
  /// <summary>
  /// Most Recently Used (MRU) pop-up. Cannot be created through the object model.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoControlType.msoControlSplitButtonMRUPopup))]
  SplitButtonMRUPopup,
  /// <summary>
  /// Label. Cannot be created through the object model.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoControlType.msoControlLabel))]
  Label,
  /// <summary>
  /// Expanding grid. Cannot be created through the object model.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoControlType.msoControlExpandingGrid))]
  ExpandingGrid,
  /// <summary>
  /// Split expanding grid. Cannot be created through the object model.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoControlType.msoControlSplitExpandingGrid))]
  SplitExpandingGrid,
  /// <summary>
  /// Grid. Cannot be created through the object model.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoControlType.msoControlGrid))]
  Grid,
  /// <summary>
  /// Gauge control. Cannot be created through the object model.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoControlType.msoControlGauge))]
  Gauge,
  /// <summary>
  /// Graphic combo box. Cannot be created through the object model.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoControlType.msoControlGraphicCombo))]
  GraphicCombo,
  /// <summary>
  /// Pane. Cannot be created through the object model.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoControlType.msoControlPane))]
  Pane,
  /// <summary>
  /// ActiveX control.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoControlType.msoControlActiveX))]
  ActiveX,
  /// <summary>
  /// Spinner. Cannot be created through the object model.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoControlType.msoControlSpinner))]
  Spinner,
  /// <summary>
  /// Extended label. Cannot be created through the object model.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoControlType.msoControlLabelEx))]
  LabelEx,
  /// <summary>
  /// Work pane. Cannot be created through the object model.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoControlType.msoControlWorkPane))]
  WorkPane,
  /// <summary>
  /// Combo box in which the first matching choice is automatically filled in as the user types. Cannot be created
  /// through the object model.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoControlType.msoControlAutoCompleteCombo))]
  AutoCompleteCombo
}
