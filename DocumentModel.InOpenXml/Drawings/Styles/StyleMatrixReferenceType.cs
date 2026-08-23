namespace DocumentModel.Drawings;
/// <summary>
///   Represents a reference to a style matrix entry, including index and color information in multiple color models.
/// </summary>
[OpenXmlType(typeof(DXD.StyleMatrixReferenceType))]
[DataContract]
[XmlRoot("StyleMatrixReferenceType", Namespace = "DocumentModel.Drawings")]
public partial class StyleMatrixReferenceType : ModelElement<DXD.StyleMatrixReferenceType>
{
  /// <summary>
  ///   Index into the style matrix.
  /// </summary>
  public UInt32? Index { get => _Index; set => UpdateField(ref _Index, value, nameof(Index)); }
  private UInt32? _Index;

  /// <summary>
  ///   Color specified using the RGB color model with percentage values.
  /// </summary>
  public ColorType? Color { get => _Color; set => UpdateField(ref _Color, value, nameof(Color)); }
  private ColorType? _Color;

}