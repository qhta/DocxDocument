namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
///   Defines the OpenXmlTickMarksElement Class.
/// </summary>
public class OpenXmlTickMarksElement: ModelElement
{
  /// <summary>
  ///   type, this property is only available in Office 2016 and later.
  /// </summary>
  public TickMarksType? Type { get; set; }
  /// <summary>
  ///   ExtensionList.
  /// </summary>
  public ExtensionList? ExtensionList { get; set; }
}