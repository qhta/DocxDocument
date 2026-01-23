namespace DocumentModel.Wordprocessing;
/// <summary>
/// Represents a person associated with a revision in a WordprocessingML document.
/// This class extends <see cref = "CollectionItem"/> and provides properties for contact information, author name, and presence information, enabling tracking and management of user metadata for collaborative editing and revision history.
/// </summary>
public partial class Person : ModelElement<DXO13W.Person>, ICollectionItem
{
    /// <summary>
    /// Contact information for the person, available for backwards compatibility.
    /// </summary>
    public string? Contact { get => _Contact; set => UpdateField(ref _Contact, value, nameof(Contact)); }

    private string? _Contact;
    /// <summary>
    /// Name of the author associated with the revision or document change.
    /// </summary>
    [OpenXmlProperty(nameof(DXO13W.Person.Author))]
    public string? Author { get => _Author; set => UpdateField(ref _Author, value, nameof(Author)); }

    private string? _Author;
    /// <summary>
    /// Presence information for the person, providing metadata about user presence and collaboration status.
    /// </summary>
    [OpenXmlProperty(nameof(DXO13W.Person.PresenceInfo))]
    public PresenceInfo? PresenceInfo { get => _PresenceInfo; set => UpdateField(ref _PresenceInfo, value, nameof(PresenceInfo)); }

    private PresenceInfo? _PresenceInfo;
}