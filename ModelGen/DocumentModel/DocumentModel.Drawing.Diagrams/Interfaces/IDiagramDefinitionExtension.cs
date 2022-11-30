namespace DocumentModel.Drawing.Diagrams;

/// <summary>
/// Defines the DiagramDefinitionExtension Class.
/// </summary>
public interface IDiagramDefinitionExtension // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// URI
  /// </summary>
  public System.String? Uri { get ; set; }
  
  public DocumentModel.Office2019.Drawing.Diagram11.INumberDiagramInfoList? NumberDiagramInfoList { get ; set; }
  
  public DocumentModel.Office2019.Drawing.Diagram12.ITextListStyleType? TextListStyleType { get ; set; }
  
}
