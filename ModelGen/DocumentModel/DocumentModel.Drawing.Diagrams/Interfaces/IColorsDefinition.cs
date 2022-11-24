namespace DocumentModel.Drawing.Diagrams;

/// <summary>
/// Color Transform Definitions.
/// </summary>
public interface IColorsDefinition // : DocumentModel.ITypedOpenXmlPartRootElement
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
  /// Gets the DiagramColorsPart associated with this element.
  /// </summary>
  public DiagramColorsPart? DiagramColorsPart { get ; set; }
  
}
