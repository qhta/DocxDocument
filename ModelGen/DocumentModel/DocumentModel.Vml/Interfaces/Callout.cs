namespace DocumentModel.Vml;

/// <summary>
/// Defines the Callout Class.
/// </summary>
public interface Callout
{
  /// <summary>
  /// VML Extension Handling Behavior
  /// </summary>
  public DocumentModel.Vml.ExtensionHandlingBehaviorKind? Extension { get ; set; }
  
  /// <summary>
  /// Callout toggle
  /// </summary>
  public Boolean? On { get ; set; }
  
  /// <summary>
  /// Callout type
  /// </summary>
  public String? Type { get ; set; }
  
  /// <summary>
  /// Callout gap
  /// </summary>
  public String? Gap { get ; set; }
  
  /// <summary>
  /// Callout angle
  /// </summary>
  public DocumentModel.Vml.AngleKind? Angle { get ; set; }
  
  /// <summary>
  /// Callout automatic drop toggle
  /// </summary>
  public Boolean? DropAuto { get ; set; }
  
  /// <summary>
  /// Callout drop position
  /// </summary>
  public String? Drop { get ; set; }
  
  /// <summary>
  /// Callout drop distance
  /// </summary>
  public String? Distance { get ; set; }
  
  /// <summary>
  /// Callout length toggle
  /// </summary>
  public Boolean? LengthSpecified { get ; set; }
  
  /// <summary>
  /// Callout length
  /// </summary>
  public String? Length { get ; set; }
  
  /// <summary>
  /// Callout accent bar toggle
  /// </summary>
  public Boolean? AccentBar { get ; set; }
  
  /// <summary>
  /// Callout text border toggle
  /// </summary>
  public Boolean? TextBorder { get ; set; }
  
  /// <summary>
  /// Callout flip x
  /// </summary>
  public Boolean? MinusX { get ; set; }
  
  /// <summary>
  /// Callout flip y
  /// </summary>
  public Boolean? MinusY { get ; set; }
  
}
