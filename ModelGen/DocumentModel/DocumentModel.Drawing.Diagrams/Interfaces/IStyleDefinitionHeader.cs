namespace DocumentModel.Drawing.Diagrams;

/// <summary>
/// Style Definition Header.
/// </summary>
public interface IStyleDefinitionHeader // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Unique Style ID
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
