namespace DocumentModel.Drawing.Diagrams;

/// <summary>
/// Style Definition Header.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.Diagrams.IExtensionList))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Diagrams.IStyleDisplayCategories))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Diagrams.IStyleLabelDescription))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Diagrams.IStyleDefinitionTitle))]
public class StyleDefinitionHeader: IStyleDefinitionHeader
{
  /// <summary>
  /// Unique Style ID
  /// </summary>
  public string? UniqueId
  {
    get;
    set;
  }
  
  /// <summary>
  /// Minimum Version
  /// </summary>
  public string? MinVersion
  {
    get;
    set;
  }
  
  /// <summary>
  /// Resource ID
  /// </summary>
  public int? ResourceId
  {
    get;
    set;
  }
  
}
