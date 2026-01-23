namespace DocumentModel.Wordprocessing;
/// <summary>
/// Represents a revision identifier in a WordprocessingML document.
/// This class provides a hexadecimal identifier for a tracked change, enabling unique identification and management of document revisions.
/// </summary>
public class Rsid : ModelElement<DXW.Rsid>
{
    /// <summary>
    /// Hexadecimal identifier of the revision, used to uniquely reference a tracked change.
    /// </summary>
    [OpenXmlElement(typeof(DXW.Rsid))]
    public HexInt Id { get => _Id; set => UpdateField(ref _Id, value, nameof(Id)); }

    private HexInt _Id;
}