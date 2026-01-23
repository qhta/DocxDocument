namespace DocumentModel.Wordprocessing;
/// <summary>
///   Represents a reference type for footnote or endnote separator elements in a WordprocessingML document.
///   This class provides a property for the footnote or endnote ID, enabling advanced management and referencing of separator elements for visual separation and formatting of footnote and endnote content.
/// </summary>
public partial class FootnoteEndnoteSeparatorReferenceType : ModelElement<DXW.FootnoteEndnoteSeparatorReferenceType>
{
    /// <summary>
    ///   Identifier for the footnote or endnote associated with this separator reference.
    /// </summary>
    [OpenXmlProperty(nameof(DXW.FootnoteEndnoteSeparatorReferenceType.Id))]
    public Int32? Id { get => _Id; set => UpdateField(ref _Id, value, nameof(Id)); }

    private Int32? _Id;
}