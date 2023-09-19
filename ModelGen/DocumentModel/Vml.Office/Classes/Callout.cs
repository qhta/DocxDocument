namespace DocumentModel.Vml.Office;


/// <summary>
///   Defines the Callout Class.
/// </summary>
public partial class Callout
{
  
  /// <summary>
  ///   VML Extension Handling Behavior
  /// </summary>
  [SchemaAttr("v:ext")]
  public DocumentModel.Vml.ExtensionHandlingBehaviorValues? Extension { get; set; }
  
  
  /// <summary>
  ///   Callout toggle
  /// </summary>
  [SchemaAttr("on")]
  public Boolean? On { get; set; }
  
  
  /// <summary>
  ///   Callout type
  /// </summary>
  [SchemaAttr("type")]
  public String? Type { get; set; }
  
  
  /// <summary>
  ///   Callout gap
  /// </summary>
  [SchemaAttr("gap")]
  public String? Gap { get; set; }
  
  
  /// <summary>
  ///   Callout angle
  /// </summary>
  [SchemaAttr("angle")]
  public DocumentModel.Vml.Office.AngleValues? Angle { get; set; }
  
  
  /// <summary>
  ///   Callout automatic drop toggle
  /// </summary>
  [SchemaAttr("dropauto")]
  public Boolean? DropAuto { get; set; }
  
  
  /// <summary>
  ///   Callout drop position
  /// </summary>
  [SchemaAttr("drop")]
  public String? Drop { get; set; }
  
  
  /// <summary>
  ///   Callout drop distance
  /// </summary>
  [SchemaAttr("distance")]
  public String? Distance { get; set; }
  
  
  /// <summary>
  ///   Callout length toggle
  /// </summary>
  [SchemaAttr("lengthspecified")]
  public Boolean? LengthSpecified { get; set; }
  
  
  /// <summary>
  ///   Callout length
  /// </summary>
  [SchemaAttr("length")]
  public String? Length { get; set; }
  
  
  /// <summary>
  ///   Callout accent bar toggle
  /// </summary>
  [SchemaAttr("accentbar")]
  public Boolean? AccentBar { get; set; }
  
  
  /// <summary>
  ///   Callout text border toggle
  /// </summary>
  [SchemaAttr("textborder")]
  public Boolean? TextBorder { get; set; }
  
  
  /// <summary>
  ///   Callout flip x
  /// </summary>
  [SchemaAttr("minusx")]
  public Boolean? MinusX { get; set; }
  
  
  /// <summary>
  ///   Callout flip y
  /// </summary>
  [SchemaAttr("minusy")]
  public Boolean? MinusY { get; set; }
  
}
