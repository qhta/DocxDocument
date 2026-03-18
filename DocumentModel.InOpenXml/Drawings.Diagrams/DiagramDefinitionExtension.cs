using DocumentModel.Drawings.Diagram1;

namespace DocumentModel.Drawings.Diagrams;

/// <summary>
///   Defines the DiagramDefinitionExtension Class.
/// </summary>
public class DiagramDefinitionExtension : Extension
{
  public NumberDiagramInfoList? NumberDiagramInfoList { get; set; }
  public ListStyle? TextListStyleType { get; set; }
}