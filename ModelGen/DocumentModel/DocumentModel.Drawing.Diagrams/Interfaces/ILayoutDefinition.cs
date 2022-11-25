namespace DocumentModel.Drawing.Diagrams;

/// <summary>
/// Layout Definition.
/// </summary>
public interface ILayoutDefinition // : DocumentModel.ITypedOpenXmlPartRootElement
{
  /// <summary>
  /// uniqueId
  /// </summary>
  public System.String? UniqueId { get ; set; }
  
  /// <summary>
  /// minVer
  /// </summary>
  public System.String? MinVersion { get ; set; }
  
  /// <summary>
  /// defStyle
  /// </summary>
  public System.String? DefaultStyle { get ; set; }
  
}
