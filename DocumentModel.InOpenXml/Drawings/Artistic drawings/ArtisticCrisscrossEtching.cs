namespace DocumentModel.Drawings;

/// <summary>
/// Represents an artistic crisscross etching effect, which simulates a textured etching with adjustable transparency and pressure.
/// </summary>
public class ArtisticCrisscrossEtching: ModelElement<DXO10D.ArtisticCrisscrossEtching>
{
  /// <summary>
  /// Transparency level of the crisscross etching effect.
  /// </summary>
  public Int32? Transparency { get; set; }

  /// <summary>
  /// Pressure applied in the crisscross etching effect, influencing the intensity of the etched lines.
  /// </summary>
  public Int32? Pressure { get; set; }
}