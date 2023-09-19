namespace DocumentModel;


/// <summary>
///   Represents an ordered collection of OpenXmlElement elements.
/// </summary>
public partial class OpenXmlElementList
{
  
  /// <summary>
  ///   Gets the number of OpenXmlElement elements in the OpenXmlElementList.
  /// </summary>
  public Int32? Count { get; set; }
  
  public DocumentModel.OpenXmlElement? Item { get; set; }
  
}
