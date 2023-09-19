namespace DocumentModel.Drawings;


/// <summary>
///   Keep text out of 3D scene entirely.
/// </summary>
public partial class FlatText
{
  
  /// <summary>
  ///   Specifies the Z coordinate to be used in positioning the flat text within the 3D scene.
  /// </summary>
  [SchemaAttr("z")]
  public Int64? Z { get; set; }
  
}
