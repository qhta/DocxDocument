namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the AllocatedCommand Class.
/// </summary>
public interface AllocatedCommand
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
  public HexBinaryValue? CommandIndexBasedOn { get ; set; }
  
  /// <summary>
  /// acdName
  /// </summary>
  public String? AcceleratorName { get ; set; }
  
}
