namespace DocumentModel.Drawing.Diagrams;

/// <summary>
/// Style Definition.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.Diagrams.IExtensionList))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Diagrams.IScene3D))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Diagrams.IStyleDisplayCategories))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Diagrams.IStyleLabelDescription))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Diagrams.IStyleDefinitionTitle))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Diagrams.IStyleLabel))]
public interface IStyleDefinition // : DocumentFormat.OpenXml.TypedOpenXmlPartRootElement
{
  /// <summary>
  /// Unique Style ID
  /// </summary>
  public string? UniqueId { get ; set; }
  
  /// <summary>
  /// Minimum Version
  /// </summary>
  public string? MinVersion { get ; set; }
  
}
