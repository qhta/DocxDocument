namespace DocumentModel.Drawings;

/// <summary>
/// Miter Line Join.
/// </summary>
public class MiterImpl: ModelElementImpl, Miter
{
  public DocumentFormat.OpenXml.Drawing.Miter? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Miter?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// Miter Join Limit
  /// </summary>
  public Int32? Limit
  {
    get => (Int32?)OpenXmlElement?.Limit?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Limit = (System.Int32?)value;
    }
  }
  
}
