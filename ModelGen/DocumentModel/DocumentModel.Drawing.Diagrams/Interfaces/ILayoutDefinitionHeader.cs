namespace DocumentModel.Drawing.Diagrams;

/// <summary>
/// Layout Definition Header.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.Diagrams.IExtensionList))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Diagrams.ICategoryList))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Diagrams.IDescription))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Diagrams.ITitle))]
public interface ILayoutDefinitionHeader // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// Unique Identifier
  /// </summary>
  public string? UniqueId { get ; set; }
  
  /// <summary>
  /// Minimum Version
  /// </summary>
  public string? MinVersion { get ; set; }
  
  /// <summary>
  /// Default Style
  /// </summary>
  public string? DefaultStyle { get ; set; }
  
  /// <summary>
  /// Resource Identifier
  /// </summary>
  public int? ResourceId { get ; set; }
  
}
