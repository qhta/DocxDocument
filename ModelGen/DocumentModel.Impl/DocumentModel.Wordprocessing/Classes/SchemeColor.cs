namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the SchemeColor Class.
/// </summary>
public class SchemeColorImpl: ModelElement<DocumentFormat.OpenXml.Office2010.Word.SchemeColor>, SchemeColor
{
  /// <summary>
  /// val, this property is only available in Office 2010 and later.
  /// </summary>
  public SchemeColorKind? Val
  {
    get => (SchemeColorKind?)OpenXmlElement?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Val = (DocumentFormat.OpenXml.Office2010.Word.SchemeColorValues?)value;
    }
  }
  
}
