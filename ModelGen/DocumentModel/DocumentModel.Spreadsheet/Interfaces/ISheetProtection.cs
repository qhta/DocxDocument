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
  public System.String? AlgorithmName { get ; set; }
  
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
  public System.UInt32? SpinCount { get ; set; }
  
  /// <summary>
  /// Sheet Locked
  /// </summary>
  public System.Boolean? Sheet { get ; set; }
  
  /// <summary>
  /// Objects Locked
  /// </summary>
  public System.Boolean? Objects { get ; set; }
  
  /// <summary>
  /// Scenarios Locked
  /// </summary>
  public System.Boolean? Scenarios { get ; set; }
  
  /// <summary>
  /// Format Cells Locked
  /// </summary>
  public System.Boolean? FormatCells { get ; set; }
  
  /// <summary>
  /// Format Columns Locked
  /// </summary>
  public System.Boolean? FormatColumns { get ; set; }
  
  /// <summary>
  /// Format Rows Locked
  /// </summary>
  public System.Boolean? FormatRows { get ; set; }
  
  /// <summary>
  /// Insert Columns Locked
  /// </summary>
  public System.Boolean? InsertColumns { get ; set; }
  
  /// <summary>
  /// Insert Rows Locked
  /// </summary>
  public System.Boolean? InsertRows { get ; set; }
  
  /// <summary>
  /// Insert Hyperlinks Locked
  /// </summary>
  public System.Boolean? InsertHyperlinks { get ; set; }
  
  /// <summary>
  /// Delete Columns Locked
  /// </summary>
  public System.Boolean? DeleteColumns { get ; set; }
  
  /// <summary>
  /// Delete Rows Locked
  /// </summary>
  public System.Boolean? DeleteRows { get ; set; }
  
  /// <summary>
  /// Select Locked Cells Locked
  /// </summary>
  public System.Boolean? SelectLockedCells { get ; set; }
  
  /// <summary>
  /// Sort Locked
  /// </summary>
  public System.Boolean? Sort { get ; set; }
  
  /// <summary>
  /// AutoFilter Locked
  /// </summary>
  public System.Boolean? AutoFilter { get ; set; }
  
  /// <summary>
  /// Pivot Tables Locked
  /// </summary>
  public System.Boolean? PivotTables { get ; set; }
  
  /// <summary>
  /// Select Unlocked Cells Locked
  /// </summary>
  public System.Boolean? SelectUnlockedCells { get ; set; }
  
}
