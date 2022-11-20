namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Defines the BaseTimeUnit Class.
/// </summary>
public interface IBaseTimeUnit // : DocumentFormat.OpenXml.Drawing.Charts.TimeUnitType
{
  /// <summary>
  /// Time Unit Value
  /// </summary>
  public TimeUnitValues? Val { get ; set; }
  
}
