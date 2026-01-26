namespace DocumentModel.Drawings.Pictures;
/// <summary>
///   Non-Visual Picture Properties.
/// </summary>
[OpenXmlType(typeof(DXDP.NonVisualDrawingProperties))]
public partial class NonVisualPictureProperties : ModelElement<DXDP.NonVisualDrawingProperties>
{
 /// <summary>
 ///   Non-Visual Drawing Properties.
 /// </summary>
 [OpenXmlElement(typeof(DXDP.NonVisualDrawingProperties))]
 public NonVisualDrawingProperties? NonVisualDrawingProperties { get => _NonVisualDrawingProperties; set => UpdateField(ref _NonVisualDrawingProperties, value, nameof(NonVisualDrawingProperties)); }

 private NonVisualDrawingProperties? _NonVisualDrawingProperties;
 /// <summary>
 ///   Non-Visual Picture Drawing Properties.
 /// </summary>
 [OpenXmlElement(typeof(DXDP.NonVisualDrawingProperties))]
 public NonVisualPictureDrawingProperties? NonVisualPictureDrawingProperties { get => _NonVisualPictureDrawingProperties; set => UpdateField(ref _NonVisualPictureDrawingProperties, value, nameof(NonVisualPictureDrawingProperties)); }

 private NonVisualPictureDrawingProperties? _NonVisualPictureDrawingProperties;
}