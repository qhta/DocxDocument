namespace DocumentModel.Drawings;
/// <summary>
/// Represents a backdrop plane in 3D drawing space, defined by an anchor point, normal vector, and up vector.
/// </summary>
public partial class Backdrop : ModelElement<DXD.Backdrop>, IExtendableElement
{
    /// <summary>
    /// Anchor point of the backdrop plane.
    /// </summary>
    public Anchor? Anchor { get => _Anchor; set => UpdateField(ref _Anchor, value, nameof(Anchor)); }

    private Anchor? _Anchor;
    /// <summary>
    /// Normal vector of the backdrop plane.
    /// </summary>
    public Vector3DType? Normal { get => _Normal; set => UpdateField(ref _Normal, value, nameof(Normal)); }

    private Vector3DType? _Normal;
    /// <summary>
    /// Up vector of the backdrop plane.
    /// </summary>
    public Vector3DType? UpVector { get => _UpVector; set => UpdateField(ref _UpVector, value, nameof(UpVector)); }

    private Vector3DType? _UpVector;
    /// <summary>
    /// L
    /// </summary>
    public ExtensionList? ExtensionList { get => _ExtensionList; set => UpdateField(ref _ExtensionList, value, nameof(ExtensionList)); }

    private ExtensionList? _ExtensionList;
}