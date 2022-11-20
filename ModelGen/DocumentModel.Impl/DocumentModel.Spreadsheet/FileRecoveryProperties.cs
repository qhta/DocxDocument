namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the FileRecoveryProperties Class.
/// </summary>
public class FileRecoveryProperties: IFileRecoveryProperties
{
  /// <summary>
  /// Auto Recover
  /// </summary>
  public bool? AutoRecover
  {
    get;
    set;
  }
  
  /// <summary>
  /// Crash Save
  /// </summary>
  public bool? CrashSave
  {
    get;
    set;
  }
  
  /// <summary>
  /// Data Extract Load
  /// </summary>
  public bool? DataExtractLoad
  {
    get;
    set;
  }
  
  /// <summary>
  /// Repair Load
  /// </summary>
  public bool? RepairLoad
  {
    get;
    set;
  }
  
}
