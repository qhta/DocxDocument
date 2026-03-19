using DocumentModel.Drawings.Diagram1;

namespace DocumentModel.Drawings.Diagrams;

/// <summary>
///   Defines the DiagramDefinitionExtension Class.
/// </summary>
[OpenXmlType(typeof(DXDD.DiagramDefinitionExtension))]
public class DiagramDefinitionExtension : Extension<DXDD.DiagramDefinitionExtension>
{
  public NumberDiagramInfoList? NumberDiagramInfoList { get; set; }
  public ListStyle? TextListStyleType { get; set; }
}