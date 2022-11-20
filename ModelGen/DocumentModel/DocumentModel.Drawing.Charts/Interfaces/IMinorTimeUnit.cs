namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Defines the MinorTimeUnit Class.
/// </summary>
public interface IMinorTimeUnit // : DocumentFormat.OpenXml.Drawing.Charts.TimeUnitType
{
  /// <summary>
  /// Time Unit Value
  /// </summary>
  public TimeUnitValues? Val { get ; set; }
  
}
