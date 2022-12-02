namespace DocumentModel.Drawing;

/// <summary>
/// Defines the DiagramDefinitionExtension Class.
/// </summary>
public interface IDiagramDefinitionExtension // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// URI
  /// </summary>
  public String? Uri { get ; set; }
  
  public INumberDiagramInfoList? NumberDiagramInfoList { get ; set; }
  
  public ITextListStyleType? TextListStyleType { get ; set; }
  
}
