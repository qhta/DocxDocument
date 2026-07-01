namespace DocumentModel.Drawings.ChartDrawings;
/// <summary>
///   Defines the MaxColorSolidColorFillProperties Class.
/// </summary>
[OpenXmlType(typeof(DXO10W.SolidColorFillProperties))]
[DataContract]
[XmlRoot("SolidColorFillProperties", Namespace = "DocumentModel.Drawings.ChartDrawings")]
public partial class SolidColorFillProperties : ModelElement<DXO10W.SolidColorFillProperties>
{
  /// <summary>
  ///  Color.
  /// </summary>
  public ColorType? Color { get => _Color; set => UpdateField(ref _Color, value, nameof(Color)); }
  private ColorType? _Color;
}