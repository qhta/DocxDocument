namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Defines the Protection Class.
/// </summary>
public class Protection: ModelElement
{
  /// <summary>
  ///   Chart Object.
  /// </summary>
  public bool? ChartObject { get; set; }
  /// <summary>
  ///   Data Cannot Be Changed.
  /// </summary>
  public bool? Data { get; set; }
  /// <summary>
  ///   Formatting.
  /// </summary>
  public bool? Formatting { get; set; }
  /// <summary>
  ///   Selection.
  /// </summary>
  public bool? Selection { get; set; }
  /// <summary>
  ///   User Interface.
  /// </summary>
  public bool? UserInterface { get; set; }
}