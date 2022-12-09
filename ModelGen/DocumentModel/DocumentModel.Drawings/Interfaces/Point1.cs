namespace DocumentModel.Drawings;

/// <summary>
/// Point.
/// </summary>
public interface Point1
{
  /// <summary>
  /// Model Identifier
  /// </summary>
  public String? ModelId { get ; set; }
  
  /// <summary>
  /// Point Type
  /// </summary>
  public PointKind? Type { get ; set; }
  
  /// <summary>
  /// Connection Identifier
  /// </summary>
  public String? ConnectionId { get ; set; }
  
  /// <summary>
  /// Property Set.
  /// </summary>
  public PropertySet? PropertySet { get ; set; }
  
  /// <summary>
  /// Shape Properties.
  /// </summary>
  public ShapeProperties3? ShapeProperties { get ; set; }
  
  /// <summary>
  /// Text Body.
  /// </summary>
  public TextBody1? TextBody { get ; set; }
  
  /// <summary>
  /// PtExtensionList.
  /// </summary>
  public PtExtensionList? PtExtensionList { get ; set; }
  
}
