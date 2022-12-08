namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the FitText Class.
/// </summary>
public class FitTextImpl: ModelElementImpl, FitText
{
  public DocumentFormat.OpenXml.Wordprocessing.FitText? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.FitText?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// Value
  /// </summary>
  public UInt32? Val
  {
    get;
    set;
  }
  
  /// <summary>
  /// Fit Text Run ID
  /// </summary>
  public Int32? Id
  {
    get;
    set;
  }
  
}
