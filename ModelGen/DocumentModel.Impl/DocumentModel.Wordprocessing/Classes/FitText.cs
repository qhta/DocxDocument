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
    get => (UInt32?)OpenXmlElement?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Val = (System.UInt32?)value;
    }
  }
  
  /// <summary>
  /// Fit Text Run ID
  /// </summary>
  public Int32? Id
  {
    get => (Int32?)OpenXmlElement?.Id?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Id = (System.Int32?)value;
    }
  }
  
}
