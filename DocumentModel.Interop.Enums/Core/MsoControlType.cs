namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies the type of the command bar control.
/// </summary>
public enum MsoControlType
{
  /// <summary>
  /// Custom control. Cannot be created through the object model.
  /// </summary>
  msoControlCustom,
  /// <summary>
  /// Command button.
  /// </summary>
  msoControlButton,
  /// <summary>
  /// Text box.
  /// </summary>
  msoControlEdit,
  /// <summary>
  /// Drop-down list.
  /// </summary>
  msoControlDropdown,
  /// <summary>
  /// Combo box. msoControlButtonDropdown5 Drop-down button. Cannot be created through the object model.
  /// </summary>
  msoControlComboBox,
  /// <summary>
  /// Specifies the type of the command bar control.
  /// </summary>
  msoControlButtonDropdown,
  /// <summary>
  /// Split drop-down list. Cannot be created through the object model.
  /// </summary>
  msoControlSplitDropdown,
  /// <summary>
  /// OCX drop-down list. Cannot be created through the object model. msoControlGenericDropdown8 Generic drop-down
  /// list. Cannot be created through the object model. msoControlGraphicDropdown9 Graphic drop-down list. Cannot be
  /// created through the object model. public enum class MsoControlType ﾉ Expand table
  /// </summary>
  msoControlOCXDropdown,
  /// <summary>
  /// Specifies the type of the command bar control.
  /// </summary>
  msoControlGenericDropdown,
  /// <summary>
  /// Specifies the type of the command bar control.
  /// </summary>
  msoControlGraphicDropdown,
  /// <summary>
  /// Pop-up.
  /// </summary>
  msoControlPopup,
  /// <summary>
  /// Graphic pop-up menu. Cannot be created through the object model.
  /// </summary>
  msoControlGraphicPopup,
  /// <summary>
  /// Pop-up button. Cannot be created through the object model.
  /// </summary>
  msoControlButtonPopup,
  /// <summary>
  /// Split button pop-up. Cannot be created through the object model.
  /// </summary>
  msoControlSplitButtonPopup,
  /// <summary>
  /// Most Recently Used (MRU) pop-up. Cannot be created through the object model.
  /// </summary>
  msoControlSplitButtonMRUPopup,
  /// <summary>
  /// Label. Cannot be created through the object model.
  /// </summary>
  msoControlLabel,
  /// <summary>
  /// Expanding grid. Cannot be created through the object model. msoControlSplitExpandingGrid17 Split expanding
  /// grid. Cannot be created through the object model.
  /// </summary>
  msoControlExpandingGrid,
  /// <summary>
  /// Specifies the type of the command bar control.
  /// </summary>
  msoControlSplitExpandingGrid,
  /// <summary>
  /// Grid. Cannot be created through the object model.
  /// </summary>
  msoControlGrid,
  /// <summary>
  /// Gauge control. Cannot be created through the object model.
  /// </summary>
  msoControlGauge,
  /// <summary>
  /// Graphic combo box. Cannot be created through the object model.
  /// </summary>
  msoControlGraphicCombo,
  /// <summary>
  /// Pane. Cannot be created through the object model.
  /// </summary>
  msoControlPane,
  /// <summary>
  /// ActiveX control.
  /// </summary>
  msoControlActiveX,
  /// <summary>
  /// Spinner. Cannot be created through the object model.
  /// </summary>
  msoControlSpinner,
  /// <summary>
  /// Extended label. Cannot be created through the object model.
  /// </summary>
  msoControlLabelEx,
  /// <summary>
  /// Work pane. Cannot be created through the object model. msoControlAutoCompleteCombo26 Combo box in which the
  /// first matching choice is automatically filled in as the user types. Cannot be created through the object
  /// model.
  /// </summary>
  msoControlWorkPane,
  /// <summary>
  /// Specifies the type of the command bar control.
  /// </summary>
  msoControlAutoCompleteCombo
}
