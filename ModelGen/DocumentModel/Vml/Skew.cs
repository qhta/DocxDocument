namespace DocumentModel.Vml;


/// <summary>
///   Skew Transform.
/// </summary>
public partial class Skew
{
  
  /// <summary>
  ///   Skew ID
  /// </summary>
  public String? Id { get; set; }
  
  
  /// <summary>
  ///   Skew Toggle
  /// </summary>
  public DM.TrueFalseValue? On { get; set; }
  
  
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
