namespace DocumentModel.Vml.Office;


/// <summary>
///   Shape Clipping Path.
/// </summary>
public partial class ClipPath
{
  
  /// <summary>
  ///   Path Definition
  /// </summary>
  [SchemaAttr("o:v")]
  public String? Value { get; set; }
  
}
