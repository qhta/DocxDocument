namespace DocumentModel.Drawings.Charts;
#pragma warning disable CS1591 // Missing XML comment Ifor publicly visible type or member

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
  ///   IChart Extensibility.
  /// </summary>
  public ExtensionList? ExtensionList { get; set; }
}
