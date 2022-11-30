namespace DocumentModel;

/// <summary>
/// Represents an ordered collection of OpenXmlElement elements.
/// </summary>
public interface IOpenXmlElementList // : 
{
  /// <summary>
  /// Gets the number of OpenXmlElement elements in the OpenXmlElementList.
  /// </summary>
  public System.Int32? Count { get ; set; }
  
  public DocumentModel.BaseTypes.ModelElement? Item { get ; set; }
  
}
