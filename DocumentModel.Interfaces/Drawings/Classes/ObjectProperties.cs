namespace DocumentModel.Drawings;

/// <summary>
///   Defines the ObjectProperties interface.
/// </summary>
public interface ObjectProperties: IModelElement
{
  /// <summary>
  ///   objectId
  /// </summary>
  public string? Id { get; set; }
  /// <summary>
  ///   isActiveX
  /// </summary>
  public bool? IsActiveX { get; set; }
  /// <summary>
  ///   linkType
  /// </summary>
  public string? LinkType { get; set; }
}