namespace DocumentModel.Drawings;

/// <summary>
/// System Color.
/// </summary>
public class SystemColorImpl: ModelElement<DocumentFormat.OpenXml.Drawing.SystemColor>, SystemColor
{
  /// <summary>
  /// Value
  /// </summary>
  public SystemColorKind? Val
  {
    get => (SystemColorKind?)OpenXmlElement?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Val = (DocumentFormat.OpenXml.Drawing.SystemColorValues?)value;
    }
  }
  
}
