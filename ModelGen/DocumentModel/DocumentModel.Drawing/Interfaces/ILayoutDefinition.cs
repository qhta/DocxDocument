namespace DocumentModel.Drawing;

/// <summary>
/// Layout Definition.
/// </summary>
public interface ILayoutDefinition // : DocumentModel.ITypedOpenXmlPartRootElement
{
  /// <summary>
  /// uniqueId
  /// </summary>
  public String? UniqueId { get ; set; }
  
  /// <summary>
  /// minVer
  /// </summary>
  public String? MinVersion { get ; set; }
  
  /// <summary>
  /// defStyle
  /// </summary>
  public String? DefaultStyle { get ; set; }
  
  public Collection<ITitle>? Titles { get ; set; }
  
  public Collection<IDescription>? Descriptions { get ; set; }
  
  public ICategoryList? CategoryList { get ; set; }
  
  public ISampleData? SampleData { get ; set; }
  
  public IStyleData? StyleData { get ; set; }
  
  public IColorData? ColorData { get ; set; }
  
  public ILayoutNode? LayoutNode { get ; set; }
  
  public IDiagramDefinitionExtensionList? DiagramDefinitionExtensionList { get ; set; }
  
}
