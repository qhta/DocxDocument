namespace DocumentModel.Drawing.Diagrams;

/// <summary>
/// Style Definition.
/// </summary>
public interface IStyleDefinition // : DocumentModel.ITypedOpenXmlPartRootElement
{
  /// <summary>
  /// Unique Style ID
  /// </summary>
  public System.String? UniqueId { get ; set; }
  
  /// <summary>
  /// Minimum Version
  /// </summary>
  public System.String? MinVersion { get ; set; }
  
}
