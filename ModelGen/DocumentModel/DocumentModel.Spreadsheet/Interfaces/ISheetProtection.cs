namespace DocumentModel.Spreadsheet;

/// <summary>
/// Sheet Protection.
/// </summary>
public interface ISheetProtection // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// Password
  /// </summary>
  public IHexBinaryValue? Password { get ; set; }
  
  /// <summary>
  /// Cryptographic Algorithm Name
  /// </summary>
  public string? AlgorithmName { get ; set; }
  
  /// <summary>
  /// Password Hash Value
  /// </summary>
  public IBase64BinaryValue? HashValue { get ; set; }
  
  /// <summary>
  /// Salt Value for Password Verifier
  /// </summary>
  public IBase64BinaryValue? SaltValue { get ; set; }
  
  /// <summary>
  /// Iterations to Run Hashing Algorithm
  /// </summary>
  public uint? SpinCount { get ; set; }
  
  /// <summary>
  /// Sheet Locked
  /// </summary>
  public bool? Sheet { get ; set; }
  
  /// <summary>
  /// Objects Locked
  /// </summary>
  public bool? Objects { get ; set; }
  
  /// <summary>
  /// Scenarios Locked
  /// </summary>
  public bool? Scenarios { get ; set; }
  
  /// <summary>
  /// Format Cells Locked
  /// </summary>
  public bool? FormatCells { get ; set; }
  
  /// <summary>
  /// Format Columns Locked
  /// </summary>
  public bool? FormatColumns { get ; set; }
  
  /// <summary>
  /// Format Rows Locked
  /// </summary>
  public bool? FormatRows { get ; set; }
  
  /// <summary>
  /// Insert Columns Locked
  /// </summary>
  public bool? InsertColumns { get ; set; }
  
  /// <summary>
  /// Insert Rows Locked
  /// </summary>
  public bool? InsertRows { get ; set; }
  
  /// <summary>
  /// Insert Hyperlinks Locked
  /// </summary>
  public bool? InsertHyperlinks { get ; set; }
  
  /// <summary>
  /// Delete Columns Locked
  /// </summary>
  public bool? DeleteColumns { get ; set; }
  
  /// <summary>
  /// Delete Rows Locked
  /// </summary>
  public bool? DeleteRows { get ; set; }
  
  /// <summary>
  /// Select Locked Cells Locked
  /// </summary>
  public bool? SelectLockedCells { get ; set; }
  
  /// <summary>
  /// Sort Locked
  /// </summary>
  public bool? Sort { get ; set; }
  
  /// <summary>
  /// AutoFilter Locked
  /// </summary>
  public bool? AutoFilter { get ; set; }
  
  /// <summary>
  /// Pivot Tables Locked
  /// </summary>
  public bool? PivotTables { get ; set; }
  
  /// <summary>
  /// Select Unlocked Cells Locked
  /// </summary>
  public bool? SelectUnlockedCells { get ; set; }
  
}
