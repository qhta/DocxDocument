namespace DocumentModel.Vml.Office;


/// <summary>
///   Skew Transform.
/// </summary>
public partial class Skew
{
  
  /// <summary>
  ///   VML Extension Handling Behavior
  /// </summary>
  public ExtensionHandlingBehaviorKind? Extension { get; set; }
  
  
  /// <summary>
  ///   Skew ID
  /// </summary>
  public HexInt? Id { get; set; }
  
  
  /// <summary>
  ///   Skew Toggle
  /// </summary>
  public Boolean? On { get; set; }
  
  
  /// <summary>
  ///   Skew Offset
  /// </summary>
  public String? Offset { get; set; }
  
  
  /// <summary>
  ///   Skew Origin
  /// </summary>
  public String? Origin { get; set; }
  
  
  /// <summary>
  ///   Skew Perspective Matrix
  /// </summary>
  public String? Matrix { get; set; }
  
}
