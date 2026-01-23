namespace DocumentModel.Drawings;
/// <summary>
/// Represents a connection type for connectors, defining an identifier and index for the connection.
/// </summary>
public partial class ConnectionType : ModelElement<DXD.ConnectionType>
{
    /// <summary>
    /// Unique identifier for the connection.
    /// </summary>
    public UInt32? Id { get => _Id; set => UpdateField(ref _Id, value, nameof(Id)); }

    private UInt32? _Id;
    /// <summary>
    /// Index of the connection.
    /// </summary>
    public UInt32? Index { get => _Index; set => UpdateField(ref _Index, value, nameof(Index)); }

    private UInt32? _Index;
}