namespace DocumentModel.Drawings;
/// <summary>
///   Represents rotation parameters, including latitude, longitude, and revolution values.
/// </summary>
public partial class Rotation : ModelElement
{
    /// <summary>
    ///   Latitude value for the rotation.
    /// </summary>
    public Int32? Latitude { get => _Latitude; set => UpdateField(ref _Latitude, value, nameof(Latitude)); }

    private Int32? _Latitude;
    /// <summary>
    ///   Longitude value for the rotation.
    /// </summary>
    public Int32? Longitude { get; set; }
    /// <summary>
    ///   Revolution value for the rotation.
    /// </summary>
    public Int32? Revolution { get; set; }
}