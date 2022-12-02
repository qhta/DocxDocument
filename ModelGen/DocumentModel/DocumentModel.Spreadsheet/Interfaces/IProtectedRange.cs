namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the ProtectedRange Class.
/// </summary>
public interface IProtectedRange // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// password, this property is only available in Office 2010 and later.
  /// </summary>
  public DocumentModel.IHexBinaryValue? Password { get ; set; }
  
  /// <summary>
  /// algorithmName, this property is only available in Office 2010 and later.
  /// </summary>
  public System.String? AlgorithmName { get ; set; }
  
  /// <summary>
  /// hashValue, this property is only available in Office 2010 and later.
  /// </summary>
  public DocumentModel.IBase64BinaryValue? HashValue { get ; set; }
  
  /// <summary>
  /// saltValue, this property is only available in Office 2010 and later.
  /// </summary>
  public DocumentModel.IBase64BinaryValue? SaltValue { get ; set; }
  
  /// <summary>
  /// spinCount, this property is only available in Office 2010 and later.
  /// </summary>
  public System.UInt32? SpinCount { get ; set; }
  
  /// <summary>
  /// name, this property is only available in Office 2010 and later.
  /// </summary>
  public System.String? Name { get ; set; }
  
  /// <summary>
  /// securityDescriptor, this property is only available in Office 2010 and later.
  /// </summary>
  public System.String? SecurityDescriptor { get ; set; }
  
  /// <summary>
  /// ReferenceSequence.
  /// </summary>
  public System.String? ReferenceSequence { get ; set; }
  
}
