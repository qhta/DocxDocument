namespace DocumentModel;

/// <summary>
/// Represents an ordered collection of OpenXmlElement elements.
/// </summary>
[DefaultMember("Item")]
public interface OpenXmlElementList // : 
{
  /// <summary>
  /// Gets the number of OpenXmlElement elements in the OpenXmlElementList.
  /// </summary>
  public Int32? Count { get ; set; }
  
  public ModelElement? Item { get ; set; }
  
}
