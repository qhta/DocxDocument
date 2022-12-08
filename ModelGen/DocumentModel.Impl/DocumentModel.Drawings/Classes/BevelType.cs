namespace DocumentModel.Drawings;

/// <summary>
/// Defines the BevelType Class.
/// </summary>
public class BevelTypeImpl: ModelElementImpl, BevelType
{
  public DocumentFormat.OpenXml.Drawing.BevelType? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.BevelType?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// Width
  /// </summary>
  public Int64? Width
  {
    get;
    set;
  }
  
  /// <summary>
  /// Height
  /// </summary>
  public Int64? Height
  {
    get;
    set;
  }
  
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
