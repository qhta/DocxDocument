namespace DocumentModel.Drawings.Pictures;
/// <summary>
///   Non-Visual Picture Drawing Properties.
/// </summary>
[OpenXmlType(typeof(DXDP.NonVisualDrawingProperties))]
[XmlRoot("NonVisualPictureDrawingProperties", Namespace = "DocumentModel.Drawings.Pictures")]
public partial class NonVisualPictureDrawingProperties : ModelElement<DXDP.NonVisualDrawingProperties>
{
 /// <summary>
 ///   preferRelativeResize
 /// </summary>
 public bool? PreferRelativeResize { get => _PreferRelativeResize; set => UpdateField(ref _PreferRelativeResize, value, nameof(PreferRelativeResize)); }
 private bool? _PreferRelativeResize;

 /// <summary>
 ///   PictureLocks.
 /// </summary>
 public PictureLocks? PictureLocks { get => _PictureLocks; set => UpdateField(ref _PictureLocks, value, nameof(PictureLocks)); }
 private PictureLocks? _PictureLocks;

 /// <summary>
 ///   NonVisualPicturePropertiesExtensionList.
 /// </summary>
 public NonVisualPicturePropertiesExtensionList? NonVisualPicturePropertiesExtensionList { get => _NonVisualPicturePropertiesExtensionList; set => UpdateField(ref _NonVisualPicturePropertiesExtensionList, value, nameof(NonVisualPicturePropertiesExtensionList)); }
 private NonVisualPicturePropertiesExtensionList? _NonVisualPicturePropertiesExtensionList;
}