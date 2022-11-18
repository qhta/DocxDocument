namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Defines the MajorTimeUnit Class.
/// </summary>
public interface IMajorTimeUnit // : DocumentFormat.OpenXml.Drawing.Charts.TimeUnitType
{
  /// <summary>
  /// Time Unit Value
  /// </summary>
  public TimeUnit? Val { get ; set; }
  
}
