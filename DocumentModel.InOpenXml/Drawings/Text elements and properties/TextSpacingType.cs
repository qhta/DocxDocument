namespace DocumentModel.Drawings;
/// <summary>
///   Represents text spacing settings, allowing specification of spacing as a percentage or in points.
/// </summary>
[OpenXmlType(typeof(DXD.TextSpacingType))]
public partial class TextSpacingType : ModelElement<DXD.TextSpacingType>
{
 /// <summary>
 ///   Spacing value specified as a percentage.
 /// </summary>
 public Int32? SpacingPercent { get => _SpacingPercent; set => UpdateField(ref _SpacingPercent, value, nameof(SpacingPercent)); }

 private Int32? _SpacingPercent;
 /// <summary>
 ///   Spacing value specified in points.
 /// </summary>
 public Int32? SpacingPoints { get => _SpacingPoints; set => UpdateField(ref _SpacingPoints, value, nameof(SpacingPoints)); }

 private Int32? _SpacingPoints;
}