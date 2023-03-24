namespace DocumentModel.Drawings;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the ArtisticTexturizer Class.
/// </summary>
public class ArtisticTexturizer: ModelElement
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