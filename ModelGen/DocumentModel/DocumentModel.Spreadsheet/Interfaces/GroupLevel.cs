namespace DocumentModel.Spreadsheet;

/// <summary>
/// OLAP Grouping Levels.
/// </summary>
public interface GroupLevel // : DocumentModel.BaseTypes.ModelElement
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
  public Groups? Groups { get ; set; }
  
  /// <summary>
  /// Future Feature Data Storage Area.
  /// </summary>
  public ExtensionList? ExtensionList { get ; set; }
  
}
