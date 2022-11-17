namespace DocumentModel.Spreadsheet;

public interface IFileSharing // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  public bool? ReadOnlyRecommended { get ; set; }
  
  public string? UserName { get ; set; }
  
  public IHexBinaryValue? ReservationPassword { get ; set; }
  
  public string? AlgorithmName { get ; set; }
  
  public IBase64BinaryValue? HashValue { get ; set; }
  
  public IBase64BinaryValue? SaltValue { get ; set; }
  
  public uint? SpinCount { get ; set; }
  
}
