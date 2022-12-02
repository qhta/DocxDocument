namespace DocumentModel.Spreadsheet;

/// <summary>
/// OLAP Grouping Levels.
/// </summary>
public interface IGroupLevel // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Unique Name
  /// </summary>
  public String? UniqueName { get ; set; }
  
  /// <summary>
  /// Grouping Level Display Name
  /// </summary>
  public String? Caption { get ; set; }
  
  /// <summary>
  /// User-Defined Group Level
  /// </summary>
  public Boolean? User { get ; set; }
  
  /// <summary>
  /// Custom Roll Up
  /// </summary>
  public Boolean? CustomRollUp { get ; set; }
  
  /// <summary>
  /// OLAP Level Groups.
  /// </summary>
  public IGroups? Groups { get ; set; }
  
  /// <summary>
  /// Future Feature Data Storage Area.
  /// </summary>
  public IExtensionList? ExtensionList { get ; set; }
  
}
