namespace DocumentModel.Office.CustomUI;

/// <summary>
/// Defines the RepurposedCommand Class.
/// </summary>
public interface IRepurposedCommand // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// onAction
  /// </summary>
  public string? OnAction { get ; set; }
  
  /// <summary>
  /// enabled
  /// </summary>
  public bool? Enabled { get ; set; }
  
  /// <summary>
  /// getEnabled
  /// </summary>
  public string? GetEnabled { get ; set; }
  
  /// <summary>
  /// idMso
  /// </summary>
  public string? IdMso { get ; set; }
  
}
