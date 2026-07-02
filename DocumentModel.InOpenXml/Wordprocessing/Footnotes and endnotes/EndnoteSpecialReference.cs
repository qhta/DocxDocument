namespace DocumentModel.Wordprocessing;
/// <summary>
///   Represents a reference for endnote separator element in a WordprocessingML document.
/// </summary>
[OpenXmlType(typeof(DXW.EndnoteSpecialReference))]
[DataContract]
[XmlRoot("EndnoteSpecialReference", Namespace = "DocumentModel.Wordprocessing")]
public abstract partial class EndnoteSpecialReference : FootnoteEndnoteSeparatorReferenceType<DXW.EndnoteSpecialReference>
{
}