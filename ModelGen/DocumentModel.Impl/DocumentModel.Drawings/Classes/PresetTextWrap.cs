namespace DocumentModel.Drawings;

/// <summary>
/// Preset Text Warp.
/// </summary>
public class PresetTextWrapImpl: ModelElement<DocumentFormat.OpenXml.Drawing.PresetTextWrap>, PresetTextWrap
{
  /// <summary>
  /// Preset Warp Shape
  /// </summary>
  public TextShapeKind? Preset
  {
    get => (TextShapeKind?)OpenXmlElement?.Preset?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Preset = (DocumentFormat.OpenXml.Drawing.TextShapeValues?)value;
    }
  }
  
  /// <summary>
  /// Adjust Value List.
  /// </summary>
  public AdjustValueList? AdjustValueList
  {
    get;
    set;
  }
  
}
