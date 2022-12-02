namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the AllocatedCommand Class.
/// </summary>
public interface IAllocatedCommand // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// argValue
  /// </summary>
  public String? ArgumentValue { get ; set; }
  
  /// <summary>
  /// fciBasedOn
  /// </summary>
  public String? CommandBasedOn { get ; set; }
  
  /// <summary>
  /// fciIndexBasedOn
  /// </summary>
  public DocumentModel.IHexBinaryValue? CommandIndexBasedOn { get ; set; }
  
  /// <summary>
  /// acdName
  /// </summary>
  public String? AcceleratorName { get ; set; }
  
}
