namespace DocumentModel.Drawings;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the ArtisticChalkSketch Class.
/// </summary>
public class ArtisticChalkSketch: ModelElement
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