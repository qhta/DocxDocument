namespace DocumentModel.Drawing.Diagrams;

/// <summary>
/// Layout Definition.
/// </summary>
public interface ILayoutDefinition // : DocumentModel.ITypedOpenXmlPartRootElement
{
  /// <summary>
  /// uniqueId
  /// </summary>
  public String? UniqueId { get ; set; }
  
  /// <summary>
  /// minVer
  /// </summary>
  public String? MinVersion { get ; set; }
  
  /// <summary>
  /// defStyle
  /// </summary>
  public String? DefaultStyle { get ; set; }
  
  /// <summary>
  /// Gets the DiagramLayoutDefinitionPart associated with this element.
  /// </summary>
  public DiagramLayoutDefinitionPart? DiagramLayoutDefinitionPart { get ; set; }
  
}
