namespace DocumentModel.Vml;


/// <summary>
///   Defines the TextPath Class.
/// </summary>
public partial class TextPath
{
  
  /// <summary>
  ///   Unique Identifier
  /// </summary>
  [SchemaAttr("id")]
  public String? Id { get; set; }
  
  
  /// <summary>
  ///   Shape Styling Properties
  /// </summary>
  [SchemaAttr("style")]
  public String? Style { get; set; }
  
  
  /// <summary>
  ///   Text Path Toggle
  /// </summary>
  [SchemaAttr("on")]
  public Boolean? On { get; set; }
  
  
  /// <summary>
  ///   Shape Fit Toggle
  /// </summary>
  [SchemaAttr("fitshape")]
  public Boolean? FitShape { get; set; }
  
  
  /// <summary>
  ///   Path Fit Toggle
  /// </summary>
  [SchemaAttr("fitpath")]
  public Boolean? FitPath { get; set; }
  
  
  /// <summary>
  ///   Text Path Trim Toggle
  /// </summary>
  [SchemaAttr("trim")]
  public Boolean? Trim { get; set; }
  
  
  /// <summary>
  ///   Text X-Scaling
  /// </summary>
  [SchemaAttr("xscale")]
  public Boolean? XScale { get; set; }
  
  
  /// <summary>
  ///   Text Path Text
  /// </summary>
  [SchemaAttr("string")]
  public String? String { get; set; }
  
}
