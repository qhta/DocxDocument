using DocumentFormat.OpenXml.EMMA;

namespace DocumentModel.Packaging;
/// <summary>
/// Represents an identified relationship type in a WordprocessingML document.
/// This class provides a property for the relationship ID, enabling advanced linking and referencing of document parts, external files, or resources within the document structure.
/// </summary>
public abstract partial class ReferenceRelationship<T> : ModelElement where T : DXPP.ReferenceRelationship
{
    /// <summary>
    /// Gets the type of the relationship represented by this instance.
    /// </summary>
    public string? RelationshipType { get => _RelationshipType; set => UpdateField(ref _RelationshipType, value, nameof(RelationshipType)); }

    private string? _RelationshipType;
    /// <summary>
    /// Gets a value indicating whether the target of the relationship is Internal or External to the <see cref="T:DocumentFormat.OpenXml.Packaging.OpenXmlPackage"/>.
    /// </summary>
    public bool IsExternal { get => _IsExternal; set => UpdateField(ref _IsExternal, value, nameof(IsExternal)); }

    private bool _IsExternal;
    /// <summary>Gets the relationship ID.</summary>
    public string? Id { get => _Id; set => UpdateField(ref _Id, value, nameof(Id)); }

    private string? _Id;
    /// <summary>Gets the target URI of the relationship.</summary>
    public Uri? Uri { get => _Uri; set => UpdateField(ref _Uri, value, nameof(Uri)); }

    private Uri? _Uri;
}