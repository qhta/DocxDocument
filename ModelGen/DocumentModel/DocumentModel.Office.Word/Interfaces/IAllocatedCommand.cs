namespace DocumentModel.Office.Word;

/// <summary>
/// Defines the AllocatedCommand Class.
/// </summary>
public interface IAllocatedCommand // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// argValue
  /// </summary>
  public string? ArgumentValue { get ; set; }
  
  /// <summary>
  /// fciBasedOn
  /// </summary>
  public string? CommandBasedOn { get ; set; }
  
  /// <summary>
  /// fciIndexBasedOn
  /// </summary>
  public IHexBinaryValue? CommandIndexBasedOn { get ; set; }
  
  /// <summary>
  /// acdName
  /// </summary>
  public string? AcceleratorName { get ; set; }
  
}
