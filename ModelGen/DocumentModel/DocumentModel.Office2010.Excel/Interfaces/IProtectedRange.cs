namespace DocumentModel.Office2010.Excel;

/// <summary>
/// Defines the ProtectedRange Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office.Excel.IReferenceSequence))]
public interface IProtectedRange // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// password, this property is only available in Office 2010 and later.
  /// </summary>
  public IHexBinaryValue? Password { get ; set; }
  
  /// <summary>
  /// algorithmName, this property is only available in Office 2010 and later.
  /// </summary>
  public string? AlgorithmName { get ; set; }
  
  /// <summary>
  /// hashValue, this property is only available in Office 2010 and later.
  /// </summary>
  public IBase64BinaryValue? HashValue { get ; set; }
  
  /// <summary>
  /// saltValue, this property is only available in Office 2010 and later.
  /// </summary>
  public IBase64BinaryValue? SaltValue { get ; set; }
  
  /// <summary>
  /// spinCount, this property is only available in Office 2010 and later.
  /// </summary>
  public uint? SpinCount { get ; set; }
  
  /// <summary>
  /// name, this property is only available in Office 2010 and later.
  /// </summary>
  public string? Name { get ; set; }
  
  /// <summary>
  /// securityDescriptor, this property is only available in Office 2010 and later.
  /// </summary>
  public string? SecurityDescriptor { get ; set; }
  
  /// <summary>
  /// ReferenceSequence.
  /// </summary>
  public IReferenceSequence? ReferenceSequence { get ; set; }
  
}
