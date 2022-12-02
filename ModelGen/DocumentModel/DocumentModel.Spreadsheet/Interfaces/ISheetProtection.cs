namespace DocumentModel.Spreadsheet;

/// <summary>
/// Sheet Protection.
/// </summary>
public interface ISheetProtection // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// Password
  /// </summary>
  public DocumentModel.IHexBinaryValue? Password { get ; set; }
  
  /// <summary>
  /// Cryptographic Algorithm Name
  /// </summary>
  public String? AlgorithmName { get ; set; }
  
  /// <summary>
  /// Password Hash Value
  /// </summary>
  public DocumentModel.IBase64BinaryValue? HashValue { get ; set; }
  
  /// <summary>
  /// Salt Value for Password Verifier
  /// </summary>
  public DocumentModel.IBase64BinaryValue? SaltValue { get ; set; }
  
  /// <summary>
  /// Iterations to Run Hashing Algorithm
  /// </summary>
  public UInt32? SpinCount { get ; set; }
  
  /// <summary>
  /// Sheet Locked
  /// </summary>
  public Boolean? Sheet { get ; set; }
  
  /// <summary>
  /// Objects Locked
  /// </summary>
  public Boolean? Objects { get ; set; }
  
  /// <summary>
  /// Scenarios Locked
  /// </summary>
  public Boolean? Scenarios { get ; set; }
  
  /// <summary>
  /// Format Cells Locked
  /// </summary>
  public Boolean? FormatCells { get ; set; }
  
  /// <summary>
  /// Format Columns Locked
  /// </summary>
  public Boolean? FormatColumns { get ; set; }
  
  /// <summary>
  /// Format Rows Locked
  /// </summary>
  public Boolean? FormatRows { get ; set; }
  
  /// <summary>
  /// Insert Columns Locked
  /// </summary>
  public Boolean? InsertColumns { get ; set; }
  
  /// <summary>
  /// Insert Rows Locked
  /// </summary>
  public Boolean? InsertRows { get ; set; }
  
  /// <summary>
  /// Insert Hyperlinks Locked
  /// </summary>
  public Boolean? InsertHyperlinks { get ; set; }
  
  /// <summary>
  /// Delete Columns Locked
  /// </summary>
  public Boolean? DeleteColumns { get ; set; }
  
  /// <summary>
  /// Delete Rows Locked
  /// </summary>
  public Boolean? DeleteRows { get ; set; }
  
  /// <summary>
  /// Select Locked Cells Locked
  /// </summary>
  public Boolean? SelectLockedCells { get ; set; }
  
  /// <summary>
  /// Sort Locked
  /// </summary>
  public Boolean? Sort { get ; set; }
  
  /// <summary>
  /// AutoFilter Locked
  /// </summary>
  public Boolean? AutoFilter { get ; set; }
  
  /// <summary>
  /// Pivot Tables Locked
  /// </summary>
  public Boolean? PivotTables { get ; set; }
  
  /// <summary>
  /// Select Unlocked Cells Locked
  /// </summary>
  public Boolean? SelectUnlockedCells { get ; set; }
  
}
