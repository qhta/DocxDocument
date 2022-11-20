namespace DocumentModel.Math;

/// <summary>
/// n-ary Limit Location.
/// </summary>
public interface ILimitLocation // : DocumentFormat.OpenXml.Math.LimitLocationType
{
  /// <summary>
  /// Value
  /// </summary>
  public LimitLocationValues? Val { get ; set; }
  
}
