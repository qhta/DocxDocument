namespace DocumentModel.Drawing.Diagrams;

/// <summary>
/// Color Transform Header.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.Diagrams.IExtensionList))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Diagrams.IColorTransformCategories))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Diagrams.IColorTransformDescription))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Diagrams.IColorDefinitionTitle))]
public interface IColorsDefinitionHeader // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// Unique ID
  /// </summary>
  public string? UniqueId { get ; set; }
  
  /// <summary>
  /// Minimum Version
  /// </summary>
  public string? MinVersion { get ; set; }
  
  /// <summary>
  /// Resource ID
  /// </summary>
  public int? ResourceId { get ; set; }
  
}
