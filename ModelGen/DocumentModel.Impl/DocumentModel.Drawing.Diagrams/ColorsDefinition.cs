namespace DocumentModel.Drawing.Diagrams;

/// <summary>
/// Color Transform Definitions.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.Diagrams.IExtensionList))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Diagrams.IColorTransformCategories))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Diagrams.IColorTransformDescription))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Diagrams.IColorDefinitionTitle))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Diagrams.IColorTransformStyleLabel))]
public class ColorsDefinition: IColorsDefinition
{
  /// <summary>
  /// Unique ID
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
  
}
