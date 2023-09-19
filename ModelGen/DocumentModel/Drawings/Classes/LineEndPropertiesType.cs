namespace DocumentModel.Drawings;


/// <summary>
///   Defines the LineEndPropertiesType Class.
/// </summary>
public partial class LineEndPropertiesType
{
  
  /// <summary>
  ///   Line Head/End Type
  /// </summary>
  [SchemaAttr("type")]
  public DocumentModel.Drawings.LineEndValues? Type { get; set; }
  
  
  /// <summary>
  ///   Width of Head/End
  /// </summary>
  [SchemaAttr("w")]
  public DocumentModel.Drawings.LineEndWidthValues? Width { get; set; }
  
  
  /// <summary>
  ///   Length of Head/End
  /// </summary>
  [SchemaAttr("len")]
  public DocumentModel.Drawings.LineEndLengthValues? Length { get; set; }
  
}
