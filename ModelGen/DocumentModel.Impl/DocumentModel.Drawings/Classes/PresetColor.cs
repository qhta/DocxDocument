namespace DocumentModel.Drawings;

/// <summary>
/// Preset Color.
/// </summary>
public class PresetColorImpl: ModelElement<DocumentFormat.OpenXml.Drawing.PresetColor>, PresetColor
{
  /// <summary>
  /// Value
  /// </summary>
  public PresetColorKind? Val
  {
    get => (PresetColorKind?)OpenXmlElement?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Val = (DocumentFormat.OpenXml.Drawing.PresetColorValues?)value;
    }
  }
  
}
