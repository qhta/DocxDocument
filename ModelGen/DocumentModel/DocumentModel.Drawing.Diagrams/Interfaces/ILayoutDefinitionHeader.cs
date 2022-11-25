namespace DocumentModel.Drawing.Diagrams;

/// <summary>
/// Layout Definition Header.
/// </summary>
public interface ILayoutDefinitionHeader // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Unique Identifier
  /// </summary>
  public System.String? UniqueId { get ; set; }
  
  /// <summary>
  /// Minimum Version
  /// </summary>
  public System.String? MinVersion { get ; set; }
  
  /// <summary>
  /// Default Style
  /// </summary>
  public System.String? DefaultStyle { get ; set; }
  
  /// <summary>
  /// Resource Identifier
  /// </summary>
  public System.Int32? ResourceId { get ; set; }
  
}
