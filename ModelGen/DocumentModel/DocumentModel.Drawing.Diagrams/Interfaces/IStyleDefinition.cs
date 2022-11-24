namespace DocumentModel.Drawing.Diagrams;

/// <summary>
/// Style Definition.
/// </summary>
public interface IStyleDefinition // : DocumentModel.ITypedOpenXmlPartRootElement
{
  /// <summary>
  /// Unique Style ID
  /// </summary>
  public String? UniqueId { get ; set; }
  
  /// <summary>
  /// Minimum Version
  /// </summary>
  public String? MinVersion { get ; set; }
  
  /// <summary>
  /// Gets the DiagramStylePart associated with this element.
  /// </summary>
  public DiagramStylePart? DiagramStylePart { get ; set; }
  
}
