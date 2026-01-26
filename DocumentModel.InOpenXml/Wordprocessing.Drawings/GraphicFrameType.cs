using DocumentModel.Drawings;

namespace DocumentModel.Wordprocessing.Drawings;
/// <summary>
/// Represents the type definition for a graphic frame in a Wordprocessing document.
/// This class provides access to non-visual properties, transformation settings, the contained graphic, and extension data, enabling advanced layout, rendering, and extensibility for graphical content.
/// </summary>
[OpenXmlType(typeof(DXO10WDC.GraphicFrameType))]
public partial class GraphicFrameType : ModelElement<DXO10WDC.GraphicFrameType>
{
 /// <summary>
 /// Non-visual properties for the graphic frame, including identifiers, names, and descriptive information.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10WDC.GraphicFrameType.NonVisualDrawingProperties))]
 /// <summary>
 /// Non-visual properties for the graphic frame, including identifiers, names, and descriptive information.
 /// </summary>
 [OpenXmlElement(typeof(DXO10WDC.GraphicFrameType))]
 public NonVisualDrawingProperties? NonVisualDrawingProperties { get => _NonVisualDrawingProperties; set => UpdateField(ref _NonVisualDrawingProperties, value, nameof(NonVisualDrawingProperties)); }

 private NonVisualDrawingProperties? _NonVisualDrawingProperties;
 /// <summary>
 /// Non-visual properties specific to the graphic frame, such as locking and extension settings.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10WDC.GraphicFrameType.NonVisualGraphicFrameProperties))]
 /// <summary>
 /// Non-visual properties specific to the graphic frame, such as locking and extension settings.
 /// </summary>
 [OpenXmlElement(typeof(DXO10WDC.GraphicFrameType))]
 public NonVisualGraphicFrameProperties? NonVisualGraphicFrameProperties { get => _NonVisualGraphicFrameProperties; set => UpdateField(ref _NonVisualGraphicFrameProperties, value, nameof(NonVisualGraphicFrameProperties)); }

 private NonVisualGraphicFrameProperties? _NonVisualGraphicFrameProperties;
 /// <summary>
 /// The 2D transformation applied to the graphic frame, including translation, scaling, rotation, and skew.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10WDC.GraphicFrameType.Transform2D))]
 /// <summary>
 /// The 2D transformation applied to the graphic frame, including translation, scaling, rotation, and skew.
 /// </summary>
 [OpenXmlElement(typeof(DXO10WDC.GraphicFrameType))]
 public Transform2D? Transform2D { get => _Transform2D; set => UpdateField(ref _Transform2D, value, nameof(Transform2D)); }

 private Transform2D? _Transform2D;
 /// <summary>
 /// The graphic content contained within the frame, such as images, charts, or diagrams.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10WDC.GraphicFrameType.Graphic))]
 /// <summary>
 /// The graphic content contained within the frame, such as images, charts, or diagrams.
 /// </summary>
 [OpenXmlElement(typeof(DXO10WDC.GraphicFrameType))]
 public Graphic? Graphic { get => _Graphic; set => UpdateField(ref _Graphic, value, nameof(Graphic)); }

 private Graphic? _Graphic;
 /// <summary>
 /// List of OfficeArt extensions associated with the graphic frame, allowing for additional metadata or custom features.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10WDC.GraphicFrameType.OfficeArtExtensionList))]
 /// <summary>
 /// List of OfficeArt extensions associated with the graphic frame, allowing for additional metadata or custom features.
 /// </summary>
 [OpenXmlElement(typeof(DXO10WDC.GraphicFrameType))]
 public OfficeArtExtensionList? OfficeArtExtensionList { get => _OfficeArtExtensionList; set => UpdateField(ref _OfficeArtExtensionList, value, nameof(OfficeArtExtensionList)); }

 private OfficeArtExtensionList? _OfficeArtExtensionList;
}