namespace DocumentModel.Wordprocessing.Drawings;
/// <summary>
/// Represents the properties for a miter line join in a drawing element within a Wordprocessing document.
/// This class provides configuration for the miter limit, which determines how sharp a mitered corner can be before it is beveled.
/// </summary>
[OpenXmlType(typeof(DXO10W.LineJoinMiterProperties))]
public partial class LineJoinMiterProperties : ModelElement<DXO10W.LineJoinMiterProperties>
{
 /// <summary>
 /// The miter limit value, specifying the maximum allowed ratio of miter length to line width before the join is beveled.
 /// </summary>
 public Int32? Limit { get => _Limit; set => UpdateField(ref _Limit, value, nameof(Limit)); }

 private Int32? _Limit;
}