namespace DocumentModel.Spreadsheet;

/// <summary>
/// OLAP Grouping Levels.
/// </summary>
public interface IGroupLevel // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Unique Name
  /// </summary>
  public System.String? UniqueName { get ; set; }
  
  /// <summary>
  /// Grouping Level Display Name
  /// </summary>
  public System.String? Caption { get ; set; }
  
  /// <summary>
  /// User-Defined Group Level
  /// </summary>
  public System.Boolean? User { get ; set; }
  
  /// <summary>
  /// Custom Roll Up
  /// </summary>
  public System.Boolean? CustomRollUp { get ; set; }
  
  /// <summary>
  /// OLAP Level Groups.
  /// </summary>
  public DocumentModel.Spreadsheet.IGroups? Groups { get ; set; }
  
  /// <summary>
  /// Future Feature Data Storage Area.
  /// </summary>
  public DocumentModel.Spreadsheet.IExtensionList? ExtensionList { get ; set; }
  
}
