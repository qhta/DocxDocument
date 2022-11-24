namespace DocumentModel.Drawing.Diagrams;

/// <summary>
/// Color Transform Header.
/// </summary>
public interface IColorsDefinitionHeader // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Unique ID
  /// </summary>
  public String? UniqueId { get ; set; }
  
  /// <summary>
  /// Minimum Version
  /// </summary>
  public String? MinVersion { get ; set; }
  
  /// <summary>
  /// Resource ID
  /// </summary>
  public Int32? ResourceId { get ; set; }
  
}
