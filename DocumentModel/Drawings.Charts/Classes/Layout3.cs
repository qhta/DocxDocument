namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Defines the Layout Class.
/// </summary>
public record Layout3
{
  /// <summary>
  ///   Manual Layout.
  /// </summary>
  public ManualLayout? ManualLayout { get; set; }

  /// <summary>
  ///   Chart Extensibility.
  /// </summary>
  public ExtensionList? ExtensionList { get; set; }
}