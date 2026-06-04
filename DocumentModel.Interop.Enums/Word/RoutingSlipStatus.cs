namespace DocumentModel.Interop.Word;

/// <summary>
/// This object, member, or enumeration is deprecated and is not intended to be used in your code.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdroutingslipstatus?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType("WdRoutingSlipStatus")]
public enum RoutingSlipStatus
{
  /// <summary>
  /// This object, member, or enumeration is deprecated and is not intended to be used in your code.
  /// </summary>
  [WordInteropEnumValue("wdNotYetRouted")]
  NotYetRouted = 0,
  /// <summary>
  /// This object, member, or enumeration is deprecated and is not intended to be used in your code.
  /// </summary>
  [WordInteropEnumValue("wdRouteInProgress")]
  RouteInProgress = 1,
  /// <summary>
  /// This object, member, or enumeration is deprecated and is not intended to be used in your code.
  /// </summary>
  [WordInteropEnumValue("wdRouteComplete")]
  RouteComplete = 2
}
