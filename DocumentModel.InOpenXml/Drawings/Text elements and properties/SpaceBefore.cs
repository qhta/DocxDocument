namespace DocumentModel.Drawings;
/// <summary>
///   Represents the space before a paragraph, allowing specification as a percentage or in points.
/// </summary>
[OpenXmlType(typeof(DXD.SpaceBefore))]
[XmlRoot("SpaceBefore", Namespace = "DocumentModel.Drawings")]
public partial class SpaceBefore : ModelElement<DXD.SpaceBefore>
{
 /// <summary>
 ///   Space before the paragraph specified as a percentage.
 /// </summary>
 public Int32? SpacingPercent { get => _SpacingPercent; set => UpdateField(ref _SpacingPercent, value, nameof(SpacingPercent)); }
 private Int32? _SpacingPercent;

 /// <summary>
 ///   Space before the paragraph specified in points.
 /// </summary>
 public Int32? SpacingPoints { get => _SpacingPoints; set => UpdateField(ref _SpacingPoints, value, nameof(SpacingPoints)); }
 private Int32? _SpacingPoints;
}