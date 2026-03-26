using DocumentModel.Interop.Core;

namespace DocumentModel.Wordprocessing;

/// <summary>
/// A collection of all the Axis objects in the specified chart.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.axes?view=word-pia"/>
public interface Axes : InteropObject, InteropDictionary<(AxisType, AxisGroup), Axis>
{
}
