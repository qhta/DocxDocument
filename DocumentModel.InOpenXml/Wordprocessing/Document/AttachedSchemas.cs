using DocumentFormat.OpenXml.EMMA;

namespace DocumentModel.Wordprocessing;
/// <summary>
/// Represents a collection of additional schemas attached to a WordprocessingML document.
/// This class provides access to and management of <see cref = "Schema"/> objects, enabling advanced integration and validation of custom XML data using external or supplementary XML schemas.
/// </summary>
[OpenXmlType(typeof(DMW.AttachedSchema))]
[XmlRoot("AttachedSchemas", Namespace = "DocumentModel.Wordprocessing")]
public class AttachedSchemas : ModelElementCollection<AttachedSchema, DXW.Settings, DXW.AttachedSchema>
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
  /// <param name = "parent">The parent document settings element.</param>
  /// <param name = "openXmlCollection">The underlying OpenXml collection element.</param>
  public AttachedSchemas(DocumentSettings parent, DXW.Settings? openXmlCollection) : base(parent, openXmlCollection)
  {
  }

  /// <summary>
  /// Initializes a new instance of the AttachedSchemas class that contains elements copied from the specified
  /// collection of attached schemas.
  /// </summary>
  /// <param name="source">The collection of AttachedSchema objects whose elements are copied to the new AttachedSchemas instance.</param>
  public AttachedSchemas(IEnumerable<DMW.AttachedSchema> source) : base(source)
  {
  }
}