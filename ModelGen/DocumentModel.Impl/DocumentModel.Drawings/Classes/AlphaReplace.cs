namespace DocumentModel.Drawings;

/// <summary>
/// Alpha Replace Effect.
/// </summary>
public partial class AlphaReplaceImpl: ModelElementImpl, AlphaReplace
{
  public DocumentFormat.OpenXml.Drawing.AlphaReplace? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.AlphaReplace?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public AlphaReplaceImpl(): base() {}
  
  public AlphaReplaceImpl(DocumentFormat.OpenXml.Drawing.AlphaReplace openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Alpha
  /// </summary>
  public Int32? Alpha
  {
    get => (System.Int32?)OpenXmlElement?.Alpha?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Alpha = (System.Int32?)value;
    }
  }
  
}
