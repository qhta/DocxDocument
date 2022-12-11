namespace DocumentModel.Drawings;

/// <summary>
/// Shape Adjust.
/// </summary>
public class AdjustImpl: ModelElementImpl, Adjust
{
  public DocumentFormat.OpenXml.Drawing.Diagrams.Adjust? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Diagrams.Adjust?)_OpenXmlElement;
    set => _OpenXmlElement = value;
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
    get => (UInt32?)OpenXmlElement?.Index?.Value;
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
    get => (Double?)OpenXmlElement?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Val = (System.Double?)value;
    }
  }
  
}
