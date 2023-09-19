namespace DocumentModel.Drawings;


/// <summary>
///   Defines the BevelType Class.
/// </summary>
public partial class BevelType
{
  
  /// <summary>
  ///   Width
  /// </summary>
  [SchemaAttr("w")]
  public Int64? Width { get; set; }
  
  
  /// <summary>
  ///   Height
  /// </summary>
  [SchemaAttr("h")]
  public Int64? Height { get; set; }
  
  
  /// <summary>
  ///   Preset Bevel
  /// </summary>
  [SchemaAttr("prst")]
  public DocumentModel.Drawings.BevelPresetValues? Preset { get; set; }
  
}
