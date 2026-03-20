namespace DocumentModel.Interop;

/// <summary>
/// A collection of all the Axis objects in the specified chart.
/// </summary>
public interface Axes : InteropObject, InteropDictionary<(Core.XlAxisType, Core.XlAxisGroup), Axis>
{
}
