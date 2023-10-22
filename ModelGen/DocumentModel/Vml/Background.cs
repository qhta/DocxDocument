namespace DocumentModel.Vml;


/// <summary>
///   Document Background.
/// </summary>
public partial class Background
{
  
  /// <summary>
  ///   Unique Identifier
  /// </summary>
  public String? Id { get; set; }
  
  
  /// <summary>
  ///   Shape Fill Toggle
  /// </summary>
  public DM.TrueFalseValue? Filled { get; set; }
  
  
  /// <summary>
  ///   Fill Color
  /// </summary>
  public String? Fillcolor { get; set; }
  
  
  /// <summary>
  ///   Fill.
  /// </summary>
  public DocumentModel.Vml.Fill? Fill { get; set; }
  
}
