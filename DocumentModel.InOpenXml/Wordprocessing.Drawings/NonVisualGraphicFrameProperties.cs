using DocumentModel.Drawings;

namespace DocumentModel.Wordprocessing.Drawings;
/// <summary>
///   Defines the NonVisualGraphicFrameProperties Class.
/// </summary>
public partial class NonVisualGraphicFrameProperties : ModelElement
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