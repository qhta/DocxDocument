namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the RunPropertiesChange Class.
/// </summary>
public interface RunPropertiesChange
{
  /// <summary>
  /// Previous Run Properties.
  /// </summary>
  public PreviousRunProperties? PreviousRunProperties { get ; set; }
  
}
