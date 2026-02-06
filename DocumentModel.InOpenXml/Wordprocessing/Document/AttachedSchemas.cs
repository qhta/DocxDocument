using DocumentModel.CustomXml;

namespace DocumentModel.Wordprocessing;
/// <summary>
/// Represents a collection of additional schemas attached to a WordprocessingML document.
/// This class provides access to and management of <see cref = "Schema"/> objects, enabling advanced integration and validation of custom XML data using external or supplementary XML schemas.
/// </summary>
[XmlIgnoreEmptyCollection]
[OpenXmlType(typeof(DMW.AttachedSchema))]
//[OpenXmlItem(typeof(DXW.AttachedSchema))]
public class AttachedSchemas : ElementCollection<DMW.AttachedSchema>
{
 /// <summary>
 /// Default constructor.
 /// </summary>
 public AttachedSchemas()
 {
 }

 /// <summary>
 /// Initializing constructor.
 /// </summary>
 /// <param name = "source">Initial collection of schemas.</param>
 public AttachedSchemas(IEnumerable<DMW.AttachedSchema> source) : base(source)
 {
 }
}