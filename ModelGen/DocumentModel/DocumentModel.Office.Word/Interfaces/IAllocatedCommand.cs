namespace DocumentModel.Office.Word;

/// <summary>
/// Defines the AllocatedCommand Class.
/// </summary>
public interface IAllocatedCommand // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// argValue
  /// </summary>
  public System.String? ArgumentValue { get ; set; }
  
  /// <summary>
  /// fciBasedOn
  /// </summary>
  public System.String? CommandBasedOn { get ; set; }
  
  /// <summary>
  /// fciIndexBasedOn
  /// </summary>
  public DocumentModel.IHexBinaryValue? CommandIndexBasedOn { get ; set; }
  
  /// <summary>
  /// acdName
  /// </summary>
  public System.String? AcceleratorName { get ; set; }
  
}
