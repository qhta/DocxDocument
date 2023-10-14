namespace DocumentModel.Vml.Office;


/// <summary>
///   Defines the Callout Class.
/// </summary>
public partial class Callout
{
  
  /// <summary>
  ///   VML Extension Handling Behavior
  /// </summary>
  public DocumentModel.Vml.ExtensionHandlingBehaviorKind? Extension { get; set; }
  
  
  /// <summary>
  ///   Callout toggle
  /// </summary>
  public DM.TrueFalseValue? On { get; set; }
  
  
  /// <summary>
  ///   Callout type
  /// </summary>
  public String? Type { get; set; }
  
  
  /// <summary>
  ///   Callout gap
  /// </summary>
  public String? Gap { get; set; }
  
  
  /// <summary>
  ///   Callout angle
  /// </summary>
  public DocumentModel.Vml.Office.AngleKind? Angle { get; set; }
  
  
  /// <summary>
  ///   Callout automatic drop toggle
  /// </summary>
  public DM.TrueFalseValue? DropAuto { get; set; }
  
  
  /// <summary>
  ///   Callout drop position
  /// </summary>
  public String? Drop { get; set; }
  
  
  /// <summary>
  ///   Callout drop distance
  /// </summary>
  public String? Distance { get; set; }
  
  
  /// <summary>
  ///   Callout length toggle
  /// </summary>
  public DM.TrueFalseValue? LengthSpecified { get; set; }
  
  
  /// <summary>
  ///   Callout length
  /// </summary>
  public String? Length { get; set; }
  
  
  /// <summary>
  ///   Callout accent bar toggle
  /// </summary>
  public DM.TrueFalseValue? AccentBar { get; set; }
  
  
  /// <summary>
  ///   Callout text border toggle
  /// </summary>
  public DM.TrueFalseValue? TextBorder { get; set; }
  
  
  /// <summary>
  ///   Callout flip x
  /// </summary>
  public DM.TrueFalseValue? MinusX { get; set; }
  
  
  /// <summary>
  ///   Callout flip y
  /// </summary>
  public DM.TrueFalseValue? MinusY { get; set; }
  
}
