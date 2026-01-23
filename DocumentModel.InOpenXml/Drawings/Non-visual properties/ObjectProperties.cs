namespace DocumentModel.Drawings;
/// <summary>
///   Represents properties for an embedded object, including its identifier, ActiveX status, and link type.
/// </summary>
public partial class ObjectProperties : ModelElement<DXO13D.ObjectProperties>
{
    /// <summary>
    ///   Identifier for the embedded object.
    /// </summary>
    public string? Id { get => _Id; set => UpdateField(ref _Id, value, nameof(Id)); }

    private string? _Id;
    /// <summary>
    ///   Indicates whether the object is an ActiveX control.
    /// </summary>
    public bool? IsActiveX { get => _IsActiveX; set => UpdateField(ref _IsActiveX, value, nameof(IsActiveX)); }

    private bool? _IsActiveX;
    /// <summary>
    ///   Type of link associated with the object.
    /// </summary>
    public string? LinkType { get => _LinkType; set => UpdateField(ref _LinkType, value, nameof(LinkType)); }

    private string? _LinkType;
}