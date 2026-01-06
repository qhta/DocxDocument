namespace DocumentModel.Drawings;

/// <summary>
/// Represents an artistic crisscross etching effect, which simulates a textured etching with adjustable transparency and pressure.
/// </summary>
public interface ArtisticCrisscrossEtching
{
  /// <summary>
  /// Gets or sets the transparency level of the crisscross etching effect.
  /// </summary>
  public Int32? Transparency { get; set; }

  /// <summary>
  /// Gets or sets the pressure applied in the crisscross etching effect, influencing the intensity of the etched lines.
  /// </summary>
  public Int32? Pressure { get; set; }
}