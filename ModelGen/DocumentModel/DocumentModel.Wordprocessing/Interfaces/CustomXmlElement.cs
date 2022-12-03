namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines CustomXmlElement - the base class for the customXml elements.
/// </summary>
public interface CustomXmlElement // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// Gets or sets the custom XML Markup Namespace.
  /// </summary>
  public String? Uri { get ; set; }
  
  /// <summary>
  /// Gets or sets the element name.
  /// </summary>
  public String? Element { get ; set; }
  
  /// <summary>
  /// Gets or sets the CustomXmlProperties which represents the element tag in schema: w:customXmlPr.
  /// </summary>
  public CustomXmlProperties? CustomXmlProperties { get ; set; }
  
}
