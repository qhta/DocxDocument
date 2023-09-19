namespace DocumentModel.Vml.Office;


/// <summary>
///   Skew Transform.
/// </summary>
public partial class Skew
{
  
  /// <summary>
  ///   VML Extension Handling Behavior
  /// </summary>
  [SchemaAttr("v:ext")]
  public DocumentModel.Vml.ExtensionHandlingBehaviorValues? Extension { get; set; }
  
  
  /// <summary>
  ///   Skew ID
  /// </summary>
  [SchemaAttr("id")]
  public String? Id { get; set; }
  
  
  /// <summary>
  ///   Skew Toggle
  /// </summary>
  [SchemaAttr("on")]
  public Boolean? On { get; set; }
  
  
  /// <summary>
  ///   Skew Offset
  /// </summary>
  [SchemaAttr("offset")]
  public String? Offset { get; set; }
  
  
  /// <summary>
  ///   Skew Origin
  /// </summary>
  [SchemaAttr("origin")]
  public String? Origin { get; set; }
  
  
  /// <summary>
  ///   Skew Perspective Matrix
  /// </summary>
  [SchemaAttr("matrix")]
  public String? Matrix { get; set; }
  
}
