namespace DocumentModel.Drawings;

/// <summary>
/// Defines the FullReference Class.
/// </summary>
public class FullReferenceImpl: ModelElementImpl, FullReference
{
  public DocumentFormat.OpenXml.Office2013.Drawing.Chart.FullReference? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2013.Drawing.Chart.FullReference?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// SequenceOfReferences.
  /// </summary>
  public String? SequenceOfReferences
  {
    get;
    set;
  }
  
}
