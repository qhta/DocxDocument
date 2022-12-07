namespace DocumentModel.Drawings;

/// <summary>
/// Defines the Binning Class.
/// </summary>
public interface Binning
{
  /// <summary>
  /// intervalClosed, this property is only available in Office 2016 and later.
  /// </summary>
  public IntervalClosedSide? IntervalClosed { get ; set; }
  
}
