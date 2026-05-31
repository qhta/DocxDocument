namespace DocumentModel.Wordprocessing;
/// <summary>
/// Represents a specialized reference for an endnote separator in a WordprocessingML document.
/// This class extends <see cref = "CollectionItem"/> and <see cref = "FootnoteEndnoteSeparatorReferenceType"/>, providing a property for the target endnote. Enables advanced management and referencing of endnote separators for visual separation and formatting of endnote content.
/// </summary>
[XmlRoot("EndnoteSeparator", Namespace = "DocumentModel.Wordprocessing")]
public partial class EndnoteSeparator : FootnoteEndnoteSeparatorReferenceType
{
 ///// <summary>
 ///// Target endnote associated with this separator, specifying the endnote to which the separator applies.
 ///// </summary>
 //public Endnote? Endnote { get; set; }
}