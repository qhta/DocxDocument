namespace DocumentModel.Drawings;
/// <summary>
///   Represents a custom dash pattern for lines, defined by a collection of dash stops.
/// </summary>
[OpenXmlType(typeof(DashStop))]
public class CustomDash : ModelElementCollection<DashStop, DXD.CustomDash, DXD.DashStop>
{
}