namespace DocumentModel.Drawings;

/// <summary>
///   Defines the PictureAttributionSourceURL interface.
/// </summary>
public interface PictureAttributionSourceURL: IModelElement
{
  /// <summary>
  ///   id, this property is only available in Office 2019 and later.
  /// </summary>
  public string? Id { get; set; }
}