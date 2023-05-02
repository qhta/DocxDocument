namespace DocumentModel.Drawings;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the ArtisticBlur Class.
/// </summary>
public class ArtisticBlur: ModelElement
{
  /// <summary>
  ///   radius, this property is only available in Office 2010 and later.
  /// </summary>
  public Int32? Radius { get; set; }
}