using DocumentModel.Drawings.Diagram1;

namespace DocumentModel.Drawings.Diagrams;

/// <summary>
///   Defines the DiagramDefinitionExtension Class.
/// </summary>
[OpenXmlType(typeof(DXDD.DiagramDefinitionExtension))]
/// <summary>
/// Represents the Diagram Definition Extension.
/// </summary>
public class DiagramDefinitionExtension : Extension<DXDD.DiagramDefinitionExtension>
{
  /// <summary>
  /// Number Diagram Info List.
  /// </summary>
  public NumberDiagramInfoList? NumberDiagramInfoList { get; set; }
  /// <summary>
  /// Text List Style Type.
  /// </summary>
  public ListStyle? TextListStyleType { get; set; }
}

