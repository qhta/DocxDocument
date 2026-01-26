namespace DocumentModel.Wordprocessing;
/// <summary>
/// Represents the configuration for a checkbox content control in a structured document tag (SDT) in a Wordprocessing document.
/// This class provides properties for checked state, checked symbol, and unchecked symbol, enabling advanced customization and management of checkbox controls in SDTs.
/// </summary>
[OpenXmlType(typeof(DXO10W.SdtContentCheckBox))]
public partial class SdtContentCheckBox : ModelElement<DXO10W.SdtContentCheckBox>
{
 /// <summary>
 /// Indicates whether the checkbox is checked.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10W.SdtContentCheckBox.Checked))]
 [OpenXmlElement(typeof(DXO10W.SdtContentCheckBox))]
 public OnOffKind? Checked { get => _Checked; set => UpdateField(ref _Checked, value, nameof(Checked)); }

 private OnOffKind? _Checked;
 /// <summary>
 /// Symbol used to represent the checked state of the checkbox.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10W.SdtContentCheckBox.CheckedState))]
 [OpenXmlElement(typeof(DXO10W.SdtContentCheckBox))]
 public CheckBoxSymbolType? CheckedState { get => _CheckedState; set => UpdateField(ref _CheckedState, value, nameof(CheckedState)); }

 private CheckBoxSymbolType? _CheckedState;
 /// <summary>
 /// Symbol used to represent the unchecked state of the checkbox.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10W.SdtContentCheckBox.UncheckedState))]
 [OpenXmlElement(typeof(DXO10W.SdtContentCheckBox))]
 public CheckBoxSymbolType? UncheckedState { get => _UncheckedState; set => UpdateField(ref _UncheckedState, value, nameof(UncheckedState)); }

 private CheckBoxSymbolType? _UncheckedState;
}