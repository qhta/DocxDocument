namespace DocumentModel.Vml.Office;

/// <summary>
/// Defines the Callout Class.
/// </summary>
public interface ICallout // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// VML Extension Handling Behavior
  /// </summary>
  public DocumentModel.Vml.ExtensionHandlingBehaviorKind? Extension { get ; set; }
  
  /// <summary>
  /// Callout toggle
  /// </summary>
  public System.Boolean? On { get ; set; }
  
  /// <summary>
  /// Callout type
  /// </summary>
  public System.String? Type { get ; set; }
  
  /// <summary>
  /// Callout gap
  /// </summary>
  public System.String? Gap { get ; set; }
  
  /// <summary>
  /// Callout angle
  /// </summary>
  public DocumentModel.Vml.Office.AngleKind? Angle { get ; set; }
  
  /// <summary>
  /// Callout automatic drop toggle
  /// </summary>
  public System.Boolean? DropAuto { get ; set; }
  
  /// <summary>
  /// Callout drop position
  /// </summary>
  public System.String? Drop { get ; set; }
  
  /// <summary>
  /// Callout drop distance
  /// </summary>
  public System.String? Distance { get ; set; }
  
  /// <summary>
  /// Callout length toggle
  /// </summary>
  public System.Boolean? LengthSpecified { get ; set; }
  
  /// <summary>
  /// Callout length
  /// </summary>
  public System.String? Length { get ; set; }
  
  /// <summary>
  /// Callout accent bar toggle
  /// </summary>
  public System.Boolean? AccentBar { get ; set; }
  
  /// <summary>
  /// Callout text border toggle
  /// </summary>
  public System.Boolean? TextBorder { get ; set; }
  
  /// <summary>
  /// Callout flip x
  /// </summary>
  public System.Boolean? MinusX { get ; set; }
  
  /// <summary>
  /// Callout flip y
  /// </summary>
  public System.Boolean? MinusY { get ; set; }
  
}
