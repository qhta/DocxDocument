namespace DocumentModel.Drawing.Diagrams;

/// <summary>
/// Layout Definition Header.
/// </summary>
public interface ILayoutDefinitionHeader // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Unique Identifier
  /// </summary>
  public String? UniqueId { get ; set; }
  
  /// <summary>
  /// Minimum Version
  /// </summary>
  public String? MinVersion { get ; set; }
  
  /// <summary>
  /// Default Style
  /// </summary>
  public String? DefaultStyle { get ; set; }
  
  /// <summary>
  /// Resource Identifier
  /// </summary>
  public Int32? ResourceId { get ; set; }
  
}
