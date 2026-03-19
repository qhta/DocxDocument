namespace DocumentModel.Drawings.Diagrams;
/// <summary>
///   Shape Adjust.
/// </summary>
[OpenXmlType(typeof(DXDD.Adjust))]
public partial class Adjust : ModelElement<DXDD.Adjust>
{
 /// <summary>
 ///   Adjust Handle Index
 /// </summary>
 [OpenXmlProperty(nameof(DXDD.Adjust.Index))]
 public UInt32? Index { get => _Index; set => UpdateField(ref _Index, value, nameof(Index)); }

 private UInt32? _Index;
 /// <summary>
 ///   Value
 /// </summary>
 [OpenXmlProperty(nameof(DXDD.Adjust.Val))]
 public Double? Val { get => _Val; set => UpdateField(ref _Val, value, nameof(Val)); }

 private Double? _Val;
}
