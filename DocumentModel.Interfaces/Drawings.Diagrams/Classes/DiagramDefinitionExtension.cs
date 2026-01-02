using DocumentModel.Drawings.Diagram1;

namespace DocumentModel.Drawings.Diagrams;

/// <summary>
///   Defines the DiagramDefinitionExtension Class.
/// </summary>
public class DiagramDefinitionExtension: ModelElement
{
  /// <summary>
  ///   URI
  /// </summary>
  public string? Uri { get; set; }
  public NumberDiagramInfoList? NumberDiagramInfoList { get; set; }
  public ListStyle? TextListStyleType { get; set; }
}