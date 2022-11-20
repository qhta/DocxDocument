namespace DocumentModel.Spreadsheet;

/// <summary>
/// OLAP Grouping Levels.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IExtensionList))]
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IGroups))]
public interface IGroupLevel // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// Unique Name
  /// </summary>
  public string? UniqueName { get ; set; }
  
  /// <summary>
  /// Grouping Level Display Name
  /// </summary>
  public string? Caption { get ; set; }
  
  /// <summary>
  /// User-Defined Group Level
  /// </summary>
  public bool? User { get ; set; }
  
  /// <summary>
  /// Custom Roll Up
  /// </summary>
  public bool? CustomRollUp { get ; set; }
  
  /// <summary>
  /// OLAP Level Groups.
  /// </summary>
  public IGroups? Groups { get ; set; }
  
  /// <summary>
  /// Future Feature Data Storage Area.
  /// </summary>
  public DocumentModel.Spreadsheet.IExtensionList? ExtensionList { get ; set; }
  
}
