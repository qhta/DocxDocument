namespace DocumentModel.Drawings.Charts;
/// <summary>
///   Represents base data for a string data source type.
/// </summary>
[OpenXmlType(typeof(DXDC.StringDataType))]
[XmlRoot("StringDataType", Namespace = "DocumentModel.Drawings.Charts")]
public partial class StringDataType : ModelElement<DXDC.StringDataType>
{
 /// <summary>
 ///   Number of points in the string data set.
 /// </summary>
 [OpenXmlProperty(nameof(DXDC.StringDataType.PointCount))]
 public UInt32? PointCount { get => _PointCount; set => UpdateField(ref _PointCount, value, nameof(PointCount)); }

 private UInt32? _PointCount;
}