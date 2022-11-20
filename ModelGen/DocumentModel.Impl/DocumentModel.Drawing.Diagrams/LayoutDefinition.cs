namespace DocumentModel.Drawing.Diagrams;

/// <summary>
/// Layout Definition.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.Diagrams.ICategoryList))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Diagrams.IDescription))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Diagrams.IDiagramDefinitionExtensionList))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Diagrams.ILayoutNode))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Diagrams.ITitle))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Diagrams.ISampleData))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Diagrams.IStyleData))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Diagrams.IColorData))]
public class LayoutDefinition: ILayoutDefinition
{
  /// <summary>
  /// uniqueId
  /// </summary>
  public string? UniqueId
  {
    get;
    set;
  }
  
  /// <summary>
  /// minVer
  /// </summary>
  public string? MinVersion
  {
    get;
    set;
  }
  
  /// <summary>
  /// defStyle
  /// </summary>
  public string? DefaultStyle
  {
    get;
    set;
  }
  
}
