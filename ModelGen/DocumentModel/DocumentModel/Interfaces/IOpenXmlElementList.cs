namespace DocumentModel;

/// <summary>
/// Represents an ordered collection of OpenXmlElement elements.
/// </summary>
public interface IOpenXmlElementList // : 
{
  /// <summary>
  /// Gets the number of OpenXmlElement elements in the OpenXmlElementList.
  /// </summary>
  public Int32? Count { get ; set; }
  
  public ModelElement? Item { get ; set; }
  
}
