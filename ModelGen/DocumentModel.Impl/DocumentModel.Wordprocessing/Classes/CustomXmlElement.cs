namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines CustomXmlElement - the base class for the customXml elements.
/// </summary>
public class CustomXmlElementImpl: ModelElement<DocumentFormat.OpenXml.Wordprocessing.CustomXmlElement>, CustomXmlElement
{
  /// <summary>
  /// Gets or sets the CustomXmlProperties which represents the element tag in schema: w:customXmlPr.
  /// </summary>
  public virtual CustomXmlProperties? CustomXmlProperties
  {
    get;
    set;
  }
  
}
