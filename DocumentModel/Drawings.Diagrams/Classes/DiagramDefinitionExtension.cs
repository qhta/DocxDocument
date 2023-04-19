using DocumentModel.Drawings.Diagram1;
using DocumentModel.Drawings.Diagram2;

namespace DocumentModel.Drawings.Diagrams;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

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

  public TextListStyleType? TextListStyleType { get; set; }
}