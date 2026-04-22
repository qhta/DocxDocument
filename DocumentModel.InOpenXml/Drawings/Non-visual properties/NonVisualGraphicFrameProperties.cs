namespace DocumentModel.Drawings;
/// <summary>
///   Defines the NonVisualGraphicFrameProperties Class.
/// </summary>
[OpenXmlType(typeof(DXD.NonVisualGraphicFrameProperties))]
[XmlRoot("NonVisualGraphicFrameProperties", Namespace = "DocumentModel.Drawings")]
public abstract partial class NonVisualGraphicFrameProperties<T> : ModelElement<T> where T : DX.OpenXmlElement
{
 /// <summary>
 ///   Graphic Frame Locks.
 /// </summary>
 public GraphicFrameLocks? GraphicFrameLocks { get => _GraphicFrameLocks; set => UpdateField(ref _GraphicFrameLocks, value, nameof(GraphicFrameLocks)); }
 private GraphicFrameLocks? _GraphicFrameLocks;

 /// <summary>
 ///   ExtensionList.
 /// </summary>
 public IExtensionList? ExtensionList { get => _ExtensionList; set => UpdateField(ref _ExtensionList, value, nameof(ExtensionList)); }
 private IExtensionList? _ExtensionList;
}

/// <summary>
/// Specific DXD.NonVisualGraphicFrameProperties mapping class.
/// </summary>
[OpenXmlType(typeof(DXD.NonVisualGraphicFrameProperties))]
[XmlRoot("NonVisualGraphicFrameProperties", Namespace = "DocumentModel.Drawings")]
public class NonVisualGraphicFrameProperties : NonVisualGraphicFrameProperties<DXD.NonVisualGraphicFrameProperties>
{
}