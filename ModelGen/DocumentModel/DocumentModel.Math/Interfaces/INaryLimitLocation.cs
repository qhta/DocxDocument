namespace DocumentModel.Math;

/// <summary>
/// n-ary Limit Location.
/// </summary>
public interface INaryLimitLocation // : DocumentFormat.OpenXml.Math.LimitLocationType
{
  /// <summary>
  /// Value
  /// </summary>
  public LimitLocationValues? Val { get ; set; }
  
}
