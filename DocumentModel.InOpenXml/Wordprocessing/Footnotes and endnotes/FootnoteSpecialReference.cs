namespace DocumentModel.Wordprocessing;
/// <summary>
///   Represents a reference for footnote separator element in a WordprocessingML document.
/// </summary>
[OpenXmlType(typeof(DXW.FootnoteSpecialReference))]
[DataContract]
[XmlRoot("FootnoteSpecialReference", Namespace = "DocumentModel.Wordprocessing")]
public abstract partial class FootnoteSpecialReference : FootnoteEndnoteSeparatorReferenceType<DXW.FootnoteSpecialReference>
{
}