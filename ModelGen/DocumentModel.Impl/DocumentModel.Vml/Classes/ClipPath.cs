namespace DocumentModel.Vml;

/// <summary>
/// Shape Clipping Path.
/// </summary>
public class ClipPathImpl: ModelElementImpl, ClipPath
{
  public DocumentFormat.OpenXml.Vml.Office.ClipPath? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Vml.Office.ClipPath?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public ClipPathImpl(): base() {}
  
  public ClipPathImpl(DocumentFormat.OpenXml.Vml.Office.ClipPath openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Path Definition
  /// </summary>
  public String? Value
  {
    get => (System.String?)OpenXmlElement?.Value?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Value = (System.String?)value;
    }
  }
  
}
