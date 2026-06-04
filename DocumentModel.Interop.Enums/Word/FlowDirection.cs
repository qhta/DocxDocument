namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the direction in which text flows from one text column to the next.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdflowdirection?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType("WdFlowDirection")]
public enum FlowDirection
{
  /// <summary>
  /// Text in columns flows from left to right.
  /// </summary>
  [WordInteropEnumValue("wdFlowLtr")]
  Ltr = 0,
  /// <summary>
  /// Text in columns flows from right to left.
  /// </summary>
  [WordInteropEnumValue("wdFlowRtl")]
  Rtl = 1
}
