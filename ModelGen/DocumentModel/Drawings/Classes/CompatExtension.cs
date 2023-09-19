namespace DocumentModel.Drawings;


/// <summary>
///   Defines the CompatExtension Class.
/// </summary>
public partial class CompatExtension
{
  
  /// <summary>
  ///   spid, this property is only available in Office 2010 and later.
  /// </summary>
  [SchemaAttr("spid")]
  public String? ShapeId { get; set; }
  
}
