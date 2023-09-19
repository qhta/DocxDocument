namespace DocumentModel.Vml.Office;


/// <summary>
///   Shape Reference.
/// </summary>
public partial class Proxy
{
  
  /// <summary>
  ///   Start Point Connection Flag
  /// </summary>
  [SchemaAttr("start")]
  public Boolean? Start { get; set; }
  
  
  /// <summary>
  ///   End Point Connection Flag
  /// </summary>
  [SchemaAttr("end")]
  public Boolean? End { get; set; }
  
  
  /// <summary>
  ///   Proxy Shape Reference
  /// </summary>
  [SchemaAttr("idref")]
  public String? ShapeReference { get; set; }
  
  
  /// <summary>
  ///   Connection Location
  /// </summary>
  [SchemaAttr("connectloc")]
  public Int32? ConnectionLocation { get; set; }
  
}
