namespace DocumentModel.Wordprocessing;
/// <summary>
/// Represents entry types for a glossary document entry (DocPart) in a WordprocessingML document.
/// This interface provides properties for specifying whether the entry is of all types and for defining a specific document part type, enabling advanced classification and filtering of building blocks, autotext, and other reusable document content.
/// </summary>
public partial class DocPartTypes : ModelElement<DXW.DocPartTypes>
{
    /// <summary>
    /// Indicates whether the entry is of all types.
    /// </summary>
    public bool? All { get => _All; set => UpdateField(ref _All, value, nameof(All)); }

    private bool? _All;
    /// <summary>
    /// Specific document part type associated with the entry.
    /// </summary>
    public DocPartKind? DocPartType { get; set; }
}