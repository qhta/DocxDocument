namespace DocumentModel.Spreadsheet;

public interface IWorkbookProtection // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  public IHexBinaryValue? WorkbookPassword { get ; set; }

  public IHexBinaryValue? RevisionsPassword { get ; set; }

  public bool? LockStructure { get ; set; }

  public bool? LockWindows { get ; set; }

  public bool? LockRevision { get ; set; }

  public string? RevisionsAlgorithmName { get ; set; }

  public IBase64BinaryValue? RevisionsHashValue { get ; set; }

  public IBase64BinaryValue? RevisionsSaltValue { get ; set; }

  public uint? RevisionsSpinCount { get ; set; }

  public string? WorkbookAlgorithmName { get ; set; }

  public IBase64BinaryValue? WorkbookHashValue { get ; set; }

  public IBase64BinaryValue? WorkbookSaltValue { get ; set; }

  public uint? WorkbookSpinCount { get ; set; }

}
