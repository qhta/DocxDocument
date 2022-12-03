namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the ProtectedRange Class.
/// </summary>
public interface ProtectedRange // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// password, this property is only available in Office 2010 and later.
  /// </summary>
  public DocumentModel.HexBinaryValue? Password { get ; set; }
  
  /// <summary>
  /// algorithmName, this property is only available in Office 2010 and later.
  /// </summary>
  public String? AlgorithmName { get ; set; }
  
  /// <summary>
  /// hashValue, this property is only available in Office 2010 and later.
  /// </summary>
  public DocumentModel.Base64BinaryValue? HashValue { get ; set; }
  
  /// <summary>
  /// saltValue, this property is only available in Office 2010 and later.
  /// </summary>
  public DocumentModel.Base64BinaryValue? SaltValue { get ; set; }
  
  /// <summary>
  /// spinCount, this property is only available in Office 2010 and later.
  /// </summary>
  public UInt32? SpinCount { get ; set; }
  
  /// <summary>
  /// name, this property is only available in Office 2010 and later.
  /// </summary>
  public String? Name { get ; set; }
  
  /// <summary>
  /// securityDescriptor, this property is only available in Office 2010 and later.
  /// </summary>
  public String? SecurityDescriptor { get ; set; }
  
  /// <summary>
  /// ReferenceSequence.
  /// </summary>
  public String? ReferenceSequence { get ; set; }
  
}
