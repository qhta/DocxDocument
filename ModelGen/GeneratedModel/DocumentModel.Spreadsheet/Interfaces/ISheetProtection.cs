namespace DocumentModel.Spreadsheet;

public interface ISheetProtection // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  public IHexBinaryValue? Password { get ; set; }
  
  public string? AlgorithmName { get ; set; }
  
  public IBase64BinaryValue? HashValue { get ; set; }
  
  public IBase64BinaryValue? SaltValue { get ; set; }
  
  public uint? SpinCount { get ; set; }
  
  public bool? Sheet { get ; set; }
  
  public bool? Objects { get ; set; }
  
  public bool? Scenarios { get ; set; }
  
  public bool? FormatCells { get ; set; }
  
  public bool? FormatColumns { get ; set; }
  
  public bool? FormatRows { get ; set; }
  
  public bool? InsertColumns { get ; set; }
  
  public bool? InsertRows { get ; set; }
  
  public bool? InsertHyperlinks { get ; set; }
  
  public bool? DeleteColumns { get ; set; }
  
  public bool? DeleteRows { get ; set; }
  
  public bool? SelectLockedCells { get ; set; }
  
  public bool? Sort { get ; set; }
  
  public bool? AutoFilter { get ; set; }
  
  public bool? PivotTables { get ; set; }
  
  public bool? SelectUnlockedCells { get ; set; }
  
}
