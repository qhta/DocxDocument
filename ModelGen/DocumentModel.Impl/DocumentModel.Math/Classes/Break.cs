namespace DocumentModel.Math;

/// <summary>
/// Break.
/// </summary>
public class BreakImpl: ModelElementImpl, Break
{
  public DocumentFormat.OpenXml.Math.Break? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Math.Break?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// Index of Operator to Align To
  /// </summary>
  public Int32? AlignAt
  {
    get => (Int32?)OpenXmlElement?.AlignAt?.Value;
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
    get => (Int32?)OpenXmlElement?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Val = (System.Int32?)value;
    }
  }
  
}
