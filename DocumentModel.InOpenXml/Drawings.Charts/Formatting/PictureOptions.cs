namespace DocumentModel.Drawings.Charts;
/// <summary>
///   Represents picture formatting options for chart elements.
///   This class allows configuration of how pictures are applied to different parts of a chart, as well as the format and stacking behavior of the images.
/// </summary>
[OpenXmlType(typeof(DXDC.PictureOptions))]
[DataContract]
[XmlRoot("PictureOptions", Namespace = "DocumentModel.Drawings.Charts")]
public partial class PictureOptions : ModelElement<DXDC.PictureOptions>
{
 /// <summary>
 ///   Indicates whether the picture is applied to the front faces of the chart element.
 /// </summary>
 [OpenXmlProperty(nameof(DXDC.PictureOptions.ApplyToFront))]
 public bool? ApplyToFront { get => _ApplyToFront; set => UpdateField(ref _ApplyToFront, value, nameof(ApplyToFront)); }
 private bool? _ApplyToFront;

 /// <summary>
 ///   Indicates whether the picture is applied to the side faces of the chart element.
 /// </summary>
 [OpenXmlProperty(nameof(DXDC.PictureOptions.ApplyToSides))]
 public bool? ApplyToSides { get => _ApplyToSides; set => UpdateField(ref _ApplyToSides, value, nameof(ApplyToSides)); }
 private bool? _ApplyToSides;

 /// <summary>
 ///   Indicates whether the picture is applied to the end faces of the chart element.
 /// </summary>
 [OpenXmlProperty(nameof(DXDC.PictureOptions.ApplyToEnd))]
 public bool? ApplyToEnd { get => _ApplyToEnd; set => UpdateField(ref _ApplyToEnd, value, nameof(ApplyToEnd)); }
 private bool? _ApplyToEnd;

 /// <summary>
 ///   Specifies the format in which the picture is rendered on the chart element.
 /// </summary>
 [OpenXmlProperty(nameof(DXDC.PictureOptions.PictureFormat))]
 public PictureFormat? PictureFormat { get => _PictureFormat; set => UpdateField(ref _PictureFormat, value, nameof(PictureFormat)); }
 private PictureFormat? _PictureFormat;

 /// <summary>
 ///   Defines the unit value for stacking pictures, controlling how images are repeated or stretched along the chart element.
 /// </summary>
 [OpenXmlProperty(nameof(DXDC.PictureOptions.PictureStackUnit))]
 public Double? PictureStackUnit { get => _PictureStackUnit; set => UpdateField(ref _PictureStackUnit, value, nameof(PictureStackUnit)); }
 private Double? _PictureStackUnit;
}