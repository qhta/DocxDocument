
namespace DocumentModel.Wordprocessing;
/// <summary>
///   Defines CustomXmlElement - the base interface for the customXml elements.
/// </summary>
public interface CustomXmlElement
{
  /// <summary>
  ///   Gets or sets the custom XML Markup Namespace.
  /// </summary>
  public string? Uri { get; set; }
  /// <summary>
  ///   Gets or sets the element name.
  /// </summary>
  public string? Element { get; set; }
  /// <summary>
  ///   Gets or sets the CustomXmlProperties which represents the element tag in schema: w:customXmlPr.
  /// </summary>
  public CustomXmlProperties? CustomXmlProperties { get; set; }
}