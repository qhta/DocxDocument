namespace DocumentModel.Drawings;

/// <summary>
/// Represents an artistic photocopy effect, which simulates a photocopied appearance with adjustable transparency and detail.
/// </summary>
public interface ArtisticPhotocopy
{
  /// <summary>
  /// Transparency level of the photocopy effect.
  /// </summary>
  public Int32? Transparency { get; set; }

  /// <summary>
  /// Detail level of the photocopy effect, influencing the sharpness and clarity of the simulated photocopy.
  /// </summary>
  public Int32? Detail { get; set; }
}