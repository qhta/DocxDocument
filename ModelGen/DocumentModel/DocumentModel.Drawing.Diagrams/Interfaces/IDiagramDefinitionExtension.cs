namespace DocumentModel.Drawing.Diagrams;

/// <summary>
/// Defines the DiagramDefinitionExtension Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2019.Drawing.Diagram12.ITextListStyleType))]
[ChildElementInfo(typeof(DocumentModel.Office2019.Drawing.Diagram11.INumberDiagramInfoList))]
public interface IDiagramDefinitionExtension // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// URI
  /// </summary>
  public string? Uri { get ; set; }
  
}
