namespace DocumentModel.Drawing.Diagrams;

/// <summary>
/// Color Transform Header.
/// </summary>
public interface IColorsDefinitionHeader // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Unique ID
  /// </summary>
  public System.String? UniqueId { get ; set; }
  
  /// <summary>
  /// Minimum Version
  /// </summary>
  public System.String? MinVersion { get ; set; }
  
  /// <summary>
  /// Resource ID
  /// </summary>
  public System.Int32? ResourceId { get ; set; }
  
}
