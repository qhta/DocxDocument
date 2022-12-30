namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the AllocatedCommand Class.
/// </summary>
public partial class AllocatedCommand
{
  /// <summary>
  /// argValue
  /// </summary>
  public String? ArgumentValue { get; set; }
  
  /// <summary>
  /// fciBasedOn
  /// </summary>
  public String? CommandBasedOn { get; set; }
  
  /// <summary>
  /// fciIndexBasedOn
  /// </summary>
  public DocumentModel.HexBinary? CommandIndexBasedOn { get; set; }
  
  /// <summary>
  /// acdName
  /// </summary>
  public String? AcceleratorName { get; set; }
  
}
