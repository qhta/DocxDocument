namespace DocumentModel.Drawings;
/// <summary>
///   Represents a unique creation identifier for a drawing element.
/// </summary>
public partial class CreationId : ModelElement<DXO16D.CreationId>
{
    /// <summary>
    ///   Unique identifier value.
    /// </summary>
    public string? Id { get => _Id; set => UpdateField(ref _Id, value, nameof(Id)); }

    private string? _Id;
}