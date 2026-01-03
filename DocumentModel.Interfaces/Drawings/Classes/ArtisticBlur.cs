namespace DocumentModel.Drawings;

/// <summary>
///   Defines the ArtisticBlur interface.
/// </summary>
public interface ArtisticBlur: IModelElement
{
  /// <summary>
  ///   radius, this property is only available in Office 2010 and later.
  /// </summary>
  public Int32? Radius { get; set; }
}