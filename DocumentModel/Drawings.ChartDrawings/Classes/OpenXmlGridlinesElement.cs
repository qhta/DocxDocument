namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
///   Defines the OpenXmlGridlinesElement Class.
/// </summary>
public record OpenXmlGridlinesElement
{
  /// <summary>
  ///   ShapeProperties.
  /// </summary>
  public ShapeProperties? ShapeProperties { get; set; }

  /// <summary>
  ///   ExtensionList.
  /// </summary>
  public ExtensionList? ExtensionList { get; set; }
}