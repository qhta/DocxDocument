namespace DocumentModel.Drawings;

/// <summary>
///   Defines the ArtisticTexturizer Class.
/// </summary>
public class ArtisticTexturizer
{
  /// <summary>
  ///   trans, this property is only available in Office 2010 and later.
  /// </summary>
  public Int32? Transparancy { get; set; }

  /// <summary>
  ///   scaling, this property is only available in Office 2010 and later.
  /// </summary>
  public Int32? Scaling { get; set; }
}