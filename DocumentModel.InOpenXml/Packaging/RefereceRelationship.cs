using DocumentFormat.OpenXml.EMMA;

namespace DocumentModel.Packaging;
/// <summary>
/// Represents an identified relationship type in a WordprocessingML document.
/// This class provides a property for the relationship ID, enabling advanced linking and referencing of document parts, external files, or resources within the document structure.
/// </summary>
public abstract partial class ReferenceRelationship<T> : ModelElement where T : DXPack.ReferenceRelationship
{
    /// <summary>
    /// Gets the type of the relationship represented by this instance.
    /// </summary>
    public string? RelationshipType { get => _RelationshipType; set => UpdateField(ref _RelationshipType, value, nameof(RelationshipType)); }

    private string? _RelationshipType;
    /// <summary>
    /// Gets a value indicating whether the target of the relationship is Internal or External to the <see cref="T:DocumentFormat.OpenXml.Packaging.OpenXmlPackage"/>.
    /// </summary>
    public bool IsExternal { get; set; }
    /// <summary>Gets the relationship ID.</summary>
    public string? Id { get; set; }
    /// <summary>Gets the target URI of the relationship.</summary>
    public Uri? Uri { get; set; }
}