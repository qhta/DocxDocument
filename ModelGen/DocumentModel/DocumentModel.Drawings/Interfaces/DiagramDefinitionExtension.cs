namespace DocumentModel.Drawings;

/// <summary>
/// Defines the DiagramDefinitionExtension Class.
/// </summary>
public interface DiagramDefinitionExtension // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// URI
  /// </summary>
  public String? Uri { get ; set; }
  
  public NumberDiagramInfoList? NumberDiagramInfoList { get ; set; }
  
  public TextListStyleType? TextListStyleType { get ; set; }
  
}
