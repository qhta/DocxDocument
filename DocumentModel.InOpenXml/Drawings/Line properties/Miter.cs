namespace DocumentModel.Drawings;
/// <summary>
///   Represents a miter line join, specifying the miter limit for the join.
/// </summary>
[OpenXmlType(typeof(DXD.Miter))]
[DataContract]
[XmlRoot("Miter", Namespace = "DocumentModel.Drawings")]
public partial class Miter : ModelElement<DXD.Miter>
{
 /// <summary>
 ///   Miter join limit value.
 /// </summary>
 public Int32? Limit { get => _Limit; set => UpdateField(ref _Limit, value, nameof(Limit)); }
 private Int32? _Limit;
}