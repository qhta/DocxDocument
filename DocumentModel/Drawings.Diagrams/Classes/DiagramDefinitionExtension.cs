using DocumentModel.Drawings.Diagram1;
using DocumentModel.Drawings.Diagram2;

namespace DocumentModel.Drawings.Diagrams;

/// <summary>
///   Defines the DiagramDefinitionExtension Class.
/// </summary>
public class DiagramDefinitionExtension
{
  /// <summary>
  ///   URI
  /// </summary>
  public String? Uri { get; set; }

  public NumberDiagramInfoList? NumberDiagramInfoList { get; set; }

  public TextListStyleType? TextListStyleType { get; set; }
}