namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents the configuration for a checkbox content control in a structured document tag (SDT) in a Wordprocessing document.
/// This class provides properties for checked state, checked symbol, and unchecked symbol, enabling advanced customization and management of checkbox controls in SDTs.
/// </summary>
[OpenXmlType(typeof(DXO10W.SdtContentCheckBox))]
[DataContract]
[XmlRoot("SdtContentCheckBox", Namespace = "DocumentModel.Wordprocessing")]
public partial class SdtContentCheckBox: ModelElement<DXO10W.SdtContentCheckBox>
{
  /// <summary>
  /// Indicates whether the checkbox is checked.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10W.SdtContentCheckBox.Checked))]
  public Boolean? Checked
  {
    get => _Checked ??= GetProperty<Boolean?>(GetUpdatableElement()?.Checked);
    set => UpdateField(ref _Checked, value, nameof(Checked));
  }

  private Boolean? _Checked;

  /// <summary>
  /// Symbol used to represent the checked state of the checkbox.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10W.SdtContentCheckBox.CheckedState))]
  public CheckBoxSymbolType? CheckedState
  {
    get => _CheckedState ??= GetProperty<CheckBoxSymbolType?>(GetUpdatableElement()?.CheckedState);
    set => UpdateField(ref _CheckedState, value, nameof(CheckedState));
  }

  private CheckBoxSymbolType? _CheckedState;

  /// <summary>
  /// Symbol used to represent the unchecked state of the checkbox.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10W.SdtContentCheckBox.UncheckedState))]
  public CheckBoxSymbolType? UncheckedState
  {
    get => _UncheckedState ??= GetProperty<CheckBoxSymbolType?>(GetUpdatableElement()?.UncheckedState);
    set => UpdateField(ref _UncheckedState, value, nameof(UncheckedState));
  }

  private CheckBoxSymbolType? _UncheckedState;
}