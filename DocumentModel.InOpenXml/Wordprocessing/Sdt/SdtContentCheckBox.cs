namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents the configuration for a checkbox content control in a structured document tag (SDT) in a Wordprocessing document.
/// This interface provides properties for checked state, checked symbol, and unchecked symbol, enabling advanced customization and management of checkbox controls in SDTs.
/// </summary>
public interface SdtContentCheckBox
{
  /// <summary>
  /// Indicates whether the checkbox is checked.
  /// </summary>
  public OnOffKind? Checked { get; set; }

  /// <summary>
  /// Symbol used to represent the checked state of the checkbox.
  /// </summary>
  public CheckBoxSymbolType? CheckedState { get; set; }

  /// <summary>
  /// Symbol used to represent the unchecked state of the checkbox.
  /// </summary>
  public CheckBoxSymbolType? UncheckedState { get; set; }
}