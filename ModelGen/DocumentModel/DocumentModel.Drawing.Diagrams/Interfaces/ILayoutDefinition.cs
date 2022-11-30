namespace DocumentModel.Drawing.Diagrams;

/// <summary>
/// Layout Definition.
/// </summary>
public interface ILayoutDefinition // : DocumentModel.ITypedOpenXmlPartRootElement
{
  /// <summary>
  /// uniqueId
  /// </summary>
  public System.String? UniqueId { get ; set; }
  
  /// <summary>
  /// minVer
  /// </summary>
  public System.String? MinVersion { get ; set; }
  
  /// <summary>
  /// defStyle
  /// </summary>
  public System.String? DefaultStyle { get ; set; }
  
  public System.Collections.ObjectModel.Collection<DocumentModel.Drawing.Diagrams.ITitle>? Titles { get ; set; }
  
  public System.Collections.ObjectModel.Collection<DocumentModel.Drawing.Diagrams.IDescription>? Descriptions { get ; set; }
  
  public DocumentModel.Drawing.Diagrams.ICategoryList? CategoryList { get ; set; }
  
  public DocumentModel.Drawing.Diagrams.ISampleData? SampleData { get ; set; }
  
  public DocumentModel.Drawing.Diagrams.IStyleData? StyleData { get ; set; }
  
  public DocumentModel.Drawing.Diagrams.IColorData? ColorData { get ; set; }
  
  public DocumentModel.Drawing.Diagrams.ILayoutNode? LayoutNode { get ; set; }
  
  public DocumentModel.Drawing.Diagrams.IDiagramDefinitionExtensionList? DiagramDefinitionExtensionList { get ; set; }
  
}
