namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Layout.
/// </summary>
public class Layout: ModelElement
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