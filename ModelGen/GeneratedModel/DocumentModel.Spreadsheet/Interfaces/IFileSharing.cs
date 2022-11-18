namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the FileSharing Class.
/// </summary>
public interface IFileSharing // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// Read Only Recommended
  /// </summary>
  public bool? ReadOnlyRecommended { get ; set; }
  
  /// <summary>
  /// User Name
  /// </summary>
  public string? UserName { get ; set; }
  
  /// <summary>
  /// Write Reservation Password
  /// </summary>
  public IHexBinaryValue? ReservationPassword { get ; set; }
  
  /// <summary>
  /// Password hash algorithm
  /// </summary>
  public string? AlgorithmName { get ; set; }
  
  /// <summary>
  /// Password hash
  /// </summary>
  public IBase64BinaryValue? HashValue { get ; set; }
  
  /// <summary>
  /// Salt for password hash
  /// </summary>
  public IBase64BinaryValue? SaltValue { get ; set; }
  
  /// <summary>
  /// Spin count for password hash
  /// </summary>
  public uint? SpinCount { get ; set; }
  
}
