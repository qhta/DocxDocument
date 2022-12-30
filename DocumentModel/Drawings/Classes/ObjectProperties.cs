namespace DocumentModel.Drawings;

/// <summary>
/// Defines the ObjectProperties Class.
/// </summary>
public partial class ObjectProperties
{
  /// <summary>
  /// objectId, this property is only available in Office 2013 and later.
  /// </summary>
  public String? Id { get; set; }
  
  /// <summary>
  /// isActiveX, this property is only available in Office 2013 and later.
  /// </summary>
  public Boolean? IsActiveX { get; set; }
  
  /// <summary>
  /// linkType, this property is only available in Office 2013 and later.
  /// </summary>
  public String? LinkType { get; set; }
  
}
