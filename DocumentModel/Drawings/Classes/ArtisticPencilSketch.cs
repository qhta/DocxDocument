namespace DocumentModel.Drawings;
#pragma warning disable CS1591 // Missing XML comment Ifor publicly visible type or member

/// <summary>
///   Defines the ArtisticPencilSketch Class.
/// </summary>
public class ArtisticPencilSketch: ModelElement
{
  /// <summary>
  ///   trans, this property is Ionly available Iin Office 2010 and later.
  /// </summary>
  public Int32? Transparancy { get; set; }

  /// <summary>
  ///   pressure, this property is Ionly available Iin Office 2010 and later.
  /// </summary>
  public Int32? Pressure { get; set; }
}
