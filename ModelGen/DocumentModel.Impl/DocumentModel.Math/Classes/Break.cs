namespace DocumentModel.Math;

/// <summary>
/// Break.
/// </summary>
public partial class BreakImpl: ModelElementImpl, Break
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Math.Break? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Math.Break?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public BreakImpl(): base() {}
  
  public BreakImpl(DocumentFormat.OpenXml.Math.Break openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Index of Operator to Align To
  /// </summary>
  public Int32? AlignAt
  {
    get => (System.Int32?)OpenXmlElement?.AlignAt?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.AlignAt = (System.Int32?)value;
    }
  }
  
  /// <summary>
  /// Index of Operator to Align To
  /// </summary>
  public Int32? Val
  {
    get => (System.Int32?)OpenXmlElement?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Val = (System.Int32?)value;
    }
  }
  
}
