namespace DocumentModel.Spreadsheet;

/// <summary>
/// Protected Range.
/// </summary>
public interface IProtectedRange // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// password
  /// </summary>
  public DocumentModel.IHexBinaryValue? Password { get ; set; }
  
  /// <summary>
  /// algorithmName
  /// </summary>
  public System.String? AlgorithmName { get ; set; }
  
  /// <summary>
  /// hashValue
  /// </summary>
  public DocumentModel.IBase64BinaryValue? HashValue { get ; set; }
  
  /// <summary>
  /// saltValue
  /// </summary>
  public DocumentModel.IBase64BinaryValue? SaltValue { get ; set; }
  
  /// <summary>
  /// spinCount
  /// </summary>
  public System.UInt32? SpinCount { get ; set; }
  
  /// <summary>
  /// sqref
  /// </summary>
  public System.Collections.Generic.List<System.String>? SequenceOfReferences { get ; set; }
  
  /// <summary>
  /// name
  /// </summary>
  public System.String? Name { get ; set; }
  
  /// <summary>
  /// securityDescriptor
  /// </summary>
  public System.String? SecurityDescriptor { get ; set; }
  
}
