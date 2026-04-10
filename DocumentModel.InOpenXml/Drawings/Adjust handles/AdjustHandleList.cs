namespace DocumentModel.Drawings;
/// <summary>
/// Represents a list of shape adjust handles, providing access to both XY and polar adjustment handles for shape manipulation.
/// </summary>
[OpenXmlType(typeof(DXD.AdjustHandleList))]
[XmlRoot("AdjustHandleList", Namespace = "DocumentModel.Drawings")]
public partial class AdjustHandleList : ModelElement<DXD.AdjustHandleList>
{
 /// <summary>
 /// XY adjust handle, which provides guides and limits for horizontal and vertical adjustments.
 /// </summary>
 public AdjustHandleXY? AdjustHandleXY { get => _AdjustHandleXY; set => UpdateField(ref _AdjustHandleXY, value, nameof(AdjustHandleXY)); }

 private AdjustHandleXY? _AdjustHandleXY;
 /// <summary>
 /// Polar adjust handle, which provides guides and limits for radial and angular adjustments.
 /// </summary>
 public AdjustHandlePolar? AdjustHandlePolar { get => _AdjustHandlePolar; set => UpdateField(ref _AdjustHandlePolar, value, nameof(AdjustHandlePolar)); }

 private AdjustHandlePolar? _AdjustHandlePolar;
}