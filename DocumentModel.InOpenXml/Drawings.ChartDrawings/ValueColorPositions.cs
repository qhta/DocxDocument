namespace DocumentModel.Drawings.ChartDrawings;
/// <summary>
///   Defines the ValueColorPositions Class.
/// </summary>
[OpenXmlType(typeof(DXO16DCD.ValueColorPositions))]
[XmlRoot("ValueColorPositions", Namespace = "DocumentModel.Drawings.ChartDrawings")]
public class ValueColorPositions : ModelElement<DXO16DCD.ValueColorPositions>
{
 /// <summary>
 /// Specifies the count.
 /// </summary>
 [OpenXmlProperty(nameof(DXO16DCD.ValueColorPositions.Count))]
 public Int32? Count { get => _Count; set => UpdateField(ref _Count, value, nameof(Count)); }

 private Int32? _Count;
 /// <summary>
 /// Specifies the min value color end position.
 /// </summary>
 [OpenXmlProperty(nameof(DXO16DCD.ValueColorPositions.MinValueColorEndPosition))]
 public MinValueColorEndPosition? MinValueColorEndPosition { get => _MinValueColorEndPosition; set => UpdateField(ref _MinValueColorEndPosition, value, nameof(MinValueColorEndPosition)); }

 private MinValueColorEndPosition? _MinValueColorEndPosition;
 /// <summary>
 /// Specifies the value color middle position.
 /// </summary>
 [OpenXmlProperty(nameof(DXO16DCD.ValueColorPositions.ValueColorMiddlePosition))]
 public ValueColorMiddlePosition? ValueColorMiddlePosition { get => _ValueColorMiddlePosition; set => UpdateField(ref _ValueColorMiddlePosition, value, nameof(ValueColorMiddlePosition)); }

 private ValueColorMiddlePosition? _ValueColorMiddlePosition;
 /// <summary>
 /// Specifies the max value color end position.
 /// </summary>
 [OpenXmlProperty(nameof(DXO16DCD.ValueColorPositions.MaxValueColorEndPosition))]
 public MaxValueColorEndPosition? MaxValueColorEndPosition { get => _MaxValueColorEndPosition; set => UpdateField(ref _MaxValueColorEndPosition, value, nameof(MaxValueColorEndPosition)); }

 private MaxValueColorEndPosition? _MaxValueColorEndPosition;
}