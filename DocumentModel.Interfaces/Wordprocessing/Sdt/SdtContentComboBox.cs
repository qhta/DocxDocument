namespace DocumentModel.Wordprocessing;

/// <summary>
///   Defines the SdtContentComboBox Class.
/// </summary>
public interface SdtContentComboBox
{
  /// <summary>
  ///   Combo Box Last Saved Value
  /// </summary>
  public string? LastValue { get; set; }
  public ListItems ListItems { get; set; }
}