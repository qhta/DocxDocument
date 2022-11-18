namespace DocumentModel.Spreadsheet;

/// <summary>
/// Protected Range.
/// </summary>
public interface IProtectedRange // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// password
  /// </summary>
  public IHexBinaryValue? Password { get ; set; }
  
  /// <summary>
  /// algorithmName
  /// </summary>
  public string? AlgorithmName { get ; set; }
  
  /// <summary>
  /// hashValue
  /// </summary>
  public IBase64BinaryValue? HashValue { get ; set; }
  
  /// <summary>
  /// saltValue
  /// </summary>
  public IBase64BinaryValue? SaltValue { get ; set; }
  
  /// <summary>
  /// spinCount
  /// </summary>
  public uint? SpinCount { get ; set; }
  
  /// <summary>
  /// sqref
  /// </summary>
  public List<string>? SequenceOfReferences { get ; set; }
  
  /// <summary>
  /// name
  /// </summary>
  public string? Name { get ; set; }
  
  /// <summary>
  /// securityDescriptor
  /// </summary>
  public string? SecurityDescriptor { get ; set; }
  
}
