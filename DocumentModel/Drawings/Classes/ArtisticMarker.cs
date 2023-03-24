namespace DocumentModel.Drawings;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the ArtisticMarker Class.
/// </summary>
public class ArtisticMarker: ModelElement
{
  /// <summary>
  ///   trans, this property is only available in Office 2010 and later.
  /// </summary>
  public Int32? Transparancy { get; set; }

  /// <summary>
  ///   size, this property is only available in Office 2010 and later.
  /// </summary>
  public Int32? Size { get; set; }
}