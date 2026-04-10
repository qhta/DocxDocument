namespace DocumentModel.Wordprocessing;
/// <summary>
/// Represents the collection of endnote elements in a WordprocessingML document.
/// This class provides access to and management of <see cref = "Endnote"/> objects, enabling advanced organization, referencing, and formatting of endnotes throughout the document.
/// </summary>
[OpenXmlType(typeof(Endnote))]
[XmlRoot("Endnotes", Namespace = "DocumentModel.Wordprocessing")]
public class Endnotes : ModelElementCollection<Endnote, DXW.Endnotes, DXW.Endnote>
{
}