namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the WorkbookProtection Class.
/// </summary>
public class WorkbookProtection: IWorkbookProtection
{
  /// <summary>
  /// Workbook Password
  /// </summary>
  public IHexBinaryValue? WorkbookPassword
  {
    get;
    set;
  }
  
  /// <summary>
  /// Revisions Password
  /// </summary>
  public IHexBinaryValue? RevisionsPassword
  {
    get;
    set;
  }
  
  /// <summary>
  /// Lock Structure
  /// </summary>
  public bool? LockStructure
  {
    get;
    set;
  }
  
  /// <summary>
  /// Lock Windows
  /// </summary>
  public bool? LockWindows
  {
    get;
    set;
  }
  
  /// <summary>
  /// Lock Revisions
  /// </summary>
  public bool? LockRevision
  {
    get;
    set;
  }
  
  /// <summary>
  /// Cryptographic Algorithm Name
  /// </summary>
  public string? RevisionsAlgorithmName
  {
    get;
    set;
  }
  
  /// <summary>
  /// Password Hash Value
  /// </summary>
  public IBase64BinaryValue? RevisionsHashValue
  {
    get;
    set;
  }
  
  /// <summary>
  /// Salt Value for Password Verifier
  /// </summary>
  public IBase64BinaryValue? RevisionsSaltValue
  {
    get;
    set;
  }
  
  /// <summary>
  /// Iterations to Run Hashing Algorithm
  /// </summary>
  public uint? RevisionsSpinCount
  {
    get;
    set;
  }
  
  /// <summary>
  /// Cryptographic Algorithm Name
  /// </summary>
  public string? WorkbookAlgorithmName
  {
    get;
    set;
  }
  
  /// <summary>
  /// Password Hash Value
  /// </summary>
  public IBase64BinaryValue? WorkbookHashValue
  {
    get;
    set;
  }
  
  /// <summary>
  /// Salt Value for Password Verifier
  /// </summary>
  public IBase64BinaryValue? WorkbookSaltValue
  {
    get;
    set;
  }
  
  /// <summary>
  /// Iterations to Run Hashing Algorithm
  /// </summary>
  public uint? WorkbookSpinCount
  {
    get;
    set;
  }
  
}
