namespace DocumentModel.Spreadsheet;

/// <summary>
/// Chart Sheet Protection.
/// </summary>
public interface IChartSheetProtection // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
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
  /// Contents
  /// </summary>
  public bool? Content { get ; set; }
  
  /// <summary>
  /// Objects Locked
  /// </summary>
  public bool? Objects { get ; set; }
  
}
