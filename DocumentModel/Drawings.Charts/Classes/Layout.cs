namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Layout.
/// </summary>
public record Layout
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