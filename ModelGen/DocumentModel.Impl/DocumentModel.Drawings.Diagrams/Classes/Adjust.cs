namespace DocumentModel.Drawings.Diagrams;

/// <summary>
/// Shape Adjust.
/// </summary>
public partial class AdjustImpl: ModelElementImpl, Adjust
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Drawing.Diagrams.Adjust? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Diagrams.Adjust?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public AdjustImpl(): base() {}
  
  public AdjustImpl(DocumentFormat.OpenXml.Drawing.Diagrams.Adjust openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Adjust Handle Index
  /// </summary>
  public UInt32? Index
  {
    get => (System.UInt32?)OpenXmlElement?.Index?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Index = (System.UInt32?)value;
    }
  }
  
  /// <summary>
  /// Value
  /// </summary>
  public Double? Val
  {
    get => (System.Double?)OpenXmlElement?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Val = (System.Double?)value;
    }
  }
  
}
