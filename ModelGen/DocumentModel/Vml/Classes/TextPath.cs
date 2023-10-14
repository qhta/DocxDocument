namespace DocumentModel.Vml;


/// <summary>
///   Defines the TextPath Class.
/// </summary>
public partial class TextPath
{
  
  /// <summary>
  ///   Unique Identifier
  /// </summary>
  public String? Id { get; set; }
  
  
  /// <summary>
  ///   Shape Styling Properties
  /// </summary>
  public String? Style { get; set; }
  
  
  /// <summary>
  ///   Text Path Toggle
  /// </summary>
  public DM.TrueFalseValue? On { get; set; }
  
  
  /// <summary>
  ///   Shape Fit Toggle
  /// </summary>
  public DM.TrueFalseValue? FitShape { get; set; }
  
  
  /// <summary>
  ///   Path Fit Toggle
  /// </summary>
  public DM.TrueFalseValue? FitPath { get; set; }
  
  
  /// <summary>
  ///   Text Path Trim Toggle
  /// </summary>
  public DM.TrueFalseValue? Trim { get; set; }
  
  
  /// <summary>
  ///   Text X-Scaling
  /// </summary>
  public DM.TrueFalseValue? XScale { get; set; }
  
  
  /// <summary>
  ///   Text Path Text
  /// </summary>
  public String? String { get; set; }
  
}
