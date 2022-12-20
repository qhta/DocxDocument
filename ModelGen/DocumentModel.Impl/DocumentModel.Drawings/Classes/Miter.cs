namespace DocumentModel.Drawings;

/// <summary>
/// Miter Line Join.
/// </summary>
public partial class MiterImpl: ModelElementImpl, Miter
{
  public DocumentFormat.OpenXml.Drawing.Miter? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Miter?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public MiterImpl(): base() {}
  
  public MiterImpl(DocumentFormat.OpenXml.Drawing.Miter openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Miter Join Limit
  /// </summary>
  public Int32? Limit
  {
    get => (System.Int32?)OpenXmlElement?.Limit?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Limit = (System.Int32?)value;
    }
  }
  
}
