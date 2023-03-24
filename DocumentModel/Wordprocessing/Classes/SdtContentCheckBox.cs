namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the SdtContentCheckBox Class.
/// </summary>
[XmlObject]
public class SdtContentCheckBox: ModelElement
{
  /// <summary>
  ///   Checked.
  /// </summary>
  public OnOffKind? Checked { get; set; }

  /// <summary>
  ///   CheckedState.
  /// </summary>
  public CheckBoxSymbolType? CheckedState { get; set; }

  /// <summary>
  ///   UncheckedState.
  /// </summary>
  public CheckBoxSymbolType? UncheckedState { get; set; }
}