namespace DocumentModel.Interop.Word;

/// <summary>
/// A collection of all the Axis objects in the specified chart.
/// </summary>
public interface Axes : InteropObject, InteropDictionary<(XlAxisType, XlAxisGroup), Axis>
{
}
