namespace DocumentModel.Drawings;

/// <summary>
///   Defines the ArtisticPlasticWrap interface.
/// </summary>
public interface ArtisticPlasticWrap: IModelElement
{
  /// <summary>
  ///   trans, this property is only available in Office 2010 and later.
  /// </summary>
  public Int32? Transparancy { get; set; }
  /// <summary>
  ///   smoothness, this property is only available in Office 2010 and later.
  /// </summary>
  public Int32? Smoothness { get; set; }
}