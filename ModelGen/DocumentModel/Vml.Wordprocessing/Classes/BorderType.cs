namespace DocumentModel.Vml.Wordprocessing;


/// <summary>
///   Defines the BorderType Class.
/// </summary>
public partial class BorderType
{
  
  /// <summary>
  ///   Border Style
  /// </summary>
  [SchemaAttr("type")]
  public DocumentModel.Vml.Wordprocessing.BorderValues? Type { get; set; }
  
  
  /// <summary>
  ///   Border Width
  /// </summary>
  [SchemaAttr("width")]
  public Int64? Width { get; set; }
  
  
  /// <summary>
  ///   Border shadow
  /// </summary>
  [SchemaAttr("shadow")]
  public Boolean? Shadow { get; set; }
  
}
