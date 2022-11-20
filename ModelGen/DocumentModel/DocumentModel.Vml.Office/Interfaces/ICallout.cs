namespace DocumentModel.Vml.Office;

/// <summary>
/// Defines the Callout Class.
/// </summary>
public interface ICallout // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// VML Extension Handling Behavior
  /// </summary>
  public ExtensionHandlingBehaviorValues? Extension { get ; set; }
  
  /// <summary>
  /// Callout toggle
  /// </summary>
  public ITrueFalseValue? On { get ; set; }
  
  /// <summary>
  /// Callout type
  /// </summary>
  public string? Type { get ; set; }
  
  /// <summary>
  /// Callout gap
  /// </summary>
  public string? Gap { get ; set; }
  
  /// <summary>
  /// Callout angle
  /// </summary>
  public AngleValues? Angle { get ; set; }
  
  /// <summary>
  /// Callout automatic drop toggle
  /// </summary>
  public ITrueFalseValue? DropAuto { get ; set; }
  
  /// <summary>
  /// Callout drop position
  /// </summary>
  public string? Drop { get ; set; }
  
  /// <summary>
  /// Callout drop distance
  /// </summary>
  public string? Distance { get ; set; }
  
  /// <summary>
  /// Callout length toggle
  /// </summary>
  public ITrueFalseValue? LengthSpecified { get ; set; }
  
  /// <summary>
  /// Callout length
  /// </summary>
  public string? Length { get ; set; }
  
  /// <summary>
  /// Callout accent bar toggle
  /// </summary>
  public ITrueFalseValue? AccentBar { get ; set; }
  
  /// <summary>
  /// Callout text border toggle
  /// </summary>
  public ITrueFalseValue? TextBorder { get ; set; }
  
  /// <summary>
  /// Callout flip x
  /// </summary>
  public ITrueFalseValue? MinusX { get ; set; }
  
  /// <summary>
  /// Callout flip y
  /// </summary>
  public ITrueFalseValue? MinusY { get ; set; }
  
}
