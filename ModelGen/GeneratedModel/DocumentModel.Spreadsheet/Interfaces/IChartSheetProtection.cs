namespace DocumentModel.Spreadsheet;

public interface IChartSheetProtection // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  public IHexBinaryValue? Password { get ; set; }
  
  public string? AlgorithmName { get ; set; }
  
  public IBase64BinaryValue? HashValue { get ; set; }
  
  public IBase64BinaryValue? SaltValue { get ; set; }
  
  public uint? SpinCount { get ; set; }
  
  public bool? Content { get ; set; }
  
  public bool? Objects { get ; set; }
  
}
