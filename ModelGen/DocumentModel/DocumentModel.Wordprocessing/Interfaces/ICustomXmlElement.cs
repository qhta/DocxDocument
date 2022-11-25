namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines CustomXmlElement - the base class for the customXml elements.
/// </summary>
public interface ICustomXmlElement // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Gets or sets the custom XML Markup Namespace.
  /// </summary>
  public System.String? Uri { get ; set; }
  
  /// <summary>
  /// Gets or sets the element name.
  /// </summary>
  public System.String? Element { get ; set; }
  
  /// <summary>
  /// Gets or sets the CustomXmlProperties which represents the element tag in schema: w:customXmlPr.
  /// </summary>
  public DocumentModel.Wordprocessing.ICustomXmlProperties? CustomXmlProperties { get ; set; }
  
}
