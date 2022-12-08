namespace DocumentModel.Drawings;

/// <summary>
/// Defines the LevelReference Class.
/// </summary>
public class LevelReferenceImpl: ModelElementImpl, LevelReference
{
  public DocumentFormat.OpenXml.Office2013.Drawing.Chart.LevelReference? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2013.Drawing.Chart.LevelReference?)_OpenXmlElement;
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
