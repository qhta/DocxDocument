namespace DocumentModel.Drawings;

/// <summary>
/// Defines the BevelType Class.
/// </summary>
public class BevelTypeImpl: ModelElement<DocumentFormat.OpenXml.Drawing.BevelType>, BevelType
{
  /// <summary>
  /// Preset Bevel
  /// </summary>
  public BevelPresetKind? Preset
  {
    get => (BevelPresetKind?)OpenXmlElement?.Preset?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Preset = (DocumentFormat.OpenXml.Drawing.BevelPresetValues?)value;
    }
  }
  
}
