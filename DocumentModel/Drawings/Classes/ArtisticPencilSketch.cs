namespace DocumentModel.Drawings;

/// <summary>
///   Defines the ArtisticPencilSketch Class.
/// </summary>
public class ArtisticPencilSketch
{
  /// <summary>
  ///   trans, this property is only available in Office 2010 and later.
  /// </summary>
  public Int32? Transparancy { get; set; }

  /// <summary>
  ///   pressure, this property is only available in Office 2010 and later.
  /// </summary>
  public Int32? Pressure { get; set; }
}