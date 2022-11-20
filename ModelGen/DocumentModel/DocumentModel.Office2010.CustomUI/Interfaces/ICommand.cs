namespace DocumentModel.Office2010.CustomUI;

/// <summary>
/// Defines the Command Class.
/// </summary>
public interface ICommand // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// onAction, this property is only available in Office 2010 and later.
  /// </summary>
  public string? OnAction { get ; set; }
  
  /// <summary>
  /// enabled, this property is only available in Office 2010 and later.
  /// </summary>
  public bool? Enabled { get ; set; }
  
  /// <summary>
  /// getEnabled, this property is only available in Office 2010 and later.
  /// </summary>
  public string? GetEnabled { get ; set; }
  
  /// <summary>
  /// idMso, this property is only available in Office 2010 and later.
  /// </summary>
  public string? IdMso { get ; set; }
  
}
