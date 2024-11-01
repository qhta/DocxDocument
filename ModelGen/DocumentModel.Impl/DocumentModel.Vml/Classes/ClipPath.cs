namespace DocumentModel.Vml;

/// <summary>
/// Shape Clipping Path.
/// </summary>
public partial class ClipPathImpl: ModelElementImpl, ClipPath
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Vml.Office.ClipPath? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Vml.Office.ClipPath?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
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
