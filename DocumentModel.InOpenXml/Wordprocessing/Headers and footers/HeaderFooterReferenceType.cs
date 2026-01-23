namespace DocumentModel.Wordprocessing;
/// <summary>
/// Represents a reference to a section header or footer in a WordprocessingML document.
/// This class extends <see cref = "IParagraphContent"/> and <see cref = "ISectionPropertiesContent"/>, providing properties for the type of header or footer and the relationship ID to the part where it is defined. Enables advanced management and referencing of headers and footers for different sections and page types.
/// </summary>
public partial class HeaderFooterReferenceType<T> : ModelElement<T>, IParagraphContent, ISectionPropertiesContent where T : DX.OpenXmlElement
{
    /// <summary>
    /// Specifies which header or footer (even, default, first) is referred to by this reference.
    /// </summary>
    public HeaderFooterKind? Type { get => _Type; set => UpdateField(ref _Type, value, nameof(Type)); }

    private HeaderFooterKind? _Type;
    /// <summary>
    /// Relationship ID to the part where the header or footer is defined.
    /// </summary>
    public string? Id { get => _Id; set => UpdateField(ref _Id, value, nameof(Id)); }

    private string? _Id;
}