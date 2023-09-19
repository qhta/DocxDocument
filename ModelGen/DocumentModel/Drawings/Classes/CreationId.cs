namespace DocumentModel.Drawings;


/// <summary>
///   Defines the CreationId Class.
/// </summary>
public partial class CreationId
{
  
  /// <summary>
  ///   id, this property is only available in Office 2016 and later.
  /// </summary>
  [SchemaAttr("id")]
  public String? Id { get; set; }
  
}
