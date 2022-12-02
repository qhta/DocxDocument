namespace DocumentModel.Drawing;

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
  
  public System.Collections.ObjectModel.Collection<DocumentModel.Drawing.ITitle>? Titles { get ; set; }
  
  public System.Collections.ObjectModel.Collection<DocumentModel.Drawing.IDescription>? Descriptions { get ; set; }
  
  public DocumentModel.Drawing.ICategoryList? CategoryList { get ; set; }
  
  public DocumentModel.Drawing.ISampleData? SampleData { get ; set; }
  
  public DocumentModel.Drawing.IStyleData? StyleData { get ; set; }
  
  public DocumentModel.Drawing.IColorData? ColorData { get ; set; }
  
  public DocumentModel.Drawing.ILayoutNode? LayoutNode { get ; set; }
  
  public DocumentModel.Drawing.IDiagramDefinitionExtensionList? DiagramDefinitionExtensionList { get ; set; }
  
}
