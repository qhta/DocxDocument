namespace DocumentModel.Drawings;
/// <summary>
///   Represents a stop in a custom dash pattern, defining the length of a dash and the following space.
/// </summary>
[OpenXmlType(typeof(DXD.DashStop))]
public partial class DashStop : ModelElement<DXD.DashStop>
{
 /// <summary>
 ///   Length of the dash segment.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.DashStop.DashLength))]
 [OpenXmlElement(typeof(DXD.DashStop))]
 public Int32? DashLength { get => _DashLength; set => UpdateField(ref _DashLength, value, nameof(DashLength)); }

 private Int32? _DashLength;
 /// <summary>
 ///   Length of the space segment following the dash.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.DashStop.SpaceLength))]
 [OpenXmlElement(typeof(DXD.DashStop))]
 public Int32? SpaceLength { get => _SpaceLength; set => UpdateField(ref _SpaceLength, value, nameof(SpaceLength)); }

 private Int32? _SpaceLength;
}