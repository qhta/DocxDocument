namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the WebPublishing Class.
/// </summary>
public interface IWebPublishing // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// css
  /// </summary>
  public bool? UseCss { get ; set; }
  
  /// <summary>
  /// thicket
  /// </summary>
  public bool? Thicket { get ; set; }
  
  /// <summary>
  /// longFileNames
  /// </summary>
  public bool? LongFileNames { get ; set; }
  
  /// <summary>
  /// vml
  /// </summary>
  public bool? UseVml { get ; set; }
  
  /// <summary>
  /// allowPng
  /// </summary>
  public bool? AllowPng { get ; set; }
  
  /// <summary>
  /// targetScreenSize
  /// </summary>
  public DocumentModel.Spreadsheet.TargetScreenSize? TargetScreenSize { get ; set; }
  
  /// <summary>
  /// dpi
  /// </summary>
  public uint? Dpi { get ; set; }
  
  /// <summary>
  /// codePage
  /// </summary>
  public uint? CodePage { get ; set; }
  
  /// <summary>
  /// characterSet
  /// </summary>
  public string? CharacterSet { get ; set; }
  
}
