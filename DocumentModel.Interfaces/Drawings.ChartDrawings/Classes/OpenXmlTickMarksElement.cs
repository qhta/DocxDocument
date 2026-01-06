namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
///   Defines the OpenXmlTickMarksElement Class.
/// </summary>
public interface OpenXmlTickMarksElement
{
  /// <summary>
  ///   type
  /// </summary>
  public TickMarksType? Type { get; set; }
  /// <summary>
  ///   ExtensionList.
  /// </summary>
  public ExtensionList? ExtensionList { get; set; }
}