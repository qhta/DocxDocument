namespace DocumentModel.Drawings.Pictures;
/// <summary>
///   Picture.
/// </summary>
[OpenXmlType(typeof(DXDP.NonVisualDrawingProperties))]
[DataContract]
[XmlRoot("Picture", Namespace = "DocumentModel.Drawings.Pictures")]
public partial class Picture : ModelElement<DXDP.NonVisualDrawingProperties>
{
 /// <summary>
 ///   Non-Visual Picture Properties.
 /// </summary>
 public NonVisualPictureProperties? NonVisualPictureProperties { get => _NonVisualPictureProperties; set => UpdateField(ref _NonVisualPictureProperties, value, nameof(NonVisualPictureProperties)); }
 private NonVisualPictureProperties? _NonVisualPictureProperties;

 /// <summary>
 ///   Picture Fill.
 /// </summary>
 public BlipFill? BlipFill { get => _BlipFill; set => UpdateField(ref _BlipFill, value, nameof(BlipFill)); }
 private BlipFill? _BlipFill;

 /// <summary>
 ///   Shape Properties.
 /// </summary>
 public ShapeProperties? ShapeProperties { get => _ShapeProperties; set => UpdateField(ref _ShapeProperties, value, nameof(ShapeProperties)); }
 private ShapeProperties? _ShapeProperties;

 /// <summary>
 ///   ShapeStyle.
 /// </summary>
 public ShapeStyle? ShapeStyle { get => _ShapeStyle; set => UpdateField(ref _ShapeStyle, value, nameof(ShapeStyle)); }
 private ShapeStyle? _ShapeStyle;

 /// <summary>
 ///   OfficeArtExtensionList.
 /// </summary>
 public OfficeArtExtensionList? OfficeArtExtensionList { get => _OfficeArtExtensionList; set => UpdateField(ref _OfficeArtExtensionList, value, nameof(OfficeArtExtensionList)); }
 private OfficeArtExtensionList? _OfficeArtExtensionList;
}