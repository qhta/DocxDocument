namespace DocumentModel.Math;

/// <summary>
/// Integral Limit Locations.
/// </summary>
public interface IIntegralLimitLocation // : DocumentFormat.OpenXml.Math.LimitLocationType
{
  /// <summary>
  /// Value
  /// </summary>
  public LimitLocationValues? Val { get ; set; }
  
}
