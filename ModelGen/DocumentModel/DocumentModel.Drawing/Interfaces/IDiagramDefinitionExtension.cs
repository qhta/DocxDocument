namespace DocumentModel.Drawing;

/// <summary>
/// Defines the DiagramDefinitionExtension Class.
/// </summary>
public interface IDiagramDefinitionExtension // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// URI
  /// </summary>
  public System.String? Uri { get ; set; }
  
  public DocumentModel.Drawing.INumberDiagramInfoList? NumberDiagramInfoList { get ; set; }
  
  public DocumentModel.Drawing.ITextListStyleType? TextListStyleType { get ; set; }
  
}
