namespace DocumentModel.Drawings;

/// <summary>
///   Defines the ObjectProperties Class.
/// </summary>
public class ObjectProperties: ModelElement
{
  /// <summary>
  ///   objectId, this property is only available in Office 2013 and later.
  /// </summary>
  public string? Id { get; set; }
  /// <summary>
  ///   isActiveX, this property is only available in Office 2013 and later.
  /// </summary>
  public bool? IsActiveX { get; set; }
  /// <summary>
  ///   linkType, this property is only available in Office 2013 and later.
  /// </summary>
  public string? LinkType { get; set; }
}