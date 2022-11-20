namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the FileVersion Class.
/// </summary>
public interface IFileVersion // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// Application Name
  /// </summary>
  public string? ApplicationName { get ; set; }
  
  /// <summary>
  /// Last Edited Version
  /// </summary>
  public string? LastEdited { get ; set; }
  
  /// <summary>
  /// Lowest Edited Version
  /// </summary>
  public string? LowestEdited { get ; set; }
  
  /// <summary>
  /// Build Version
  /// </summary>
  public string? BuildVersion { get ; set; }
  
  /// <summary>
  /// Code Name
  /// </summary>
  public string? CodeName { get ; set; }
  
}
