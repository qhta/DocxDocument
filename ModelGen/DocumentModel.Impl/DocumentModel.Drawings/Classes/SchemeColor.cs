namespace DocumentModel.Drawings;

/// <summary>
/// Scheme Color.
/// </summary>
public class SchemeColorImpl: ModelElement<DocumentFormat.OpenXml.Drawing.SchemeColor>, SchemeColor
{
  /// <summary>
  /// Value
  /// </summary>
  public SchemeColorKind? Val
  {
    get => (SchemeColorKind?)OpenXmlElement?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Val = (DocumentFormat.OpenXml.Drawing.SchemeColorValues?)value;
    }
  }
  
}
