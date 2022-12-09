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
    get => (Int64?)OpenXmlElement?.Width?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Width = (System.Int64?)value;
    }
  }
  
  /// <summary>
  /// Height
  /// </summary>
  public Int64? Height
  {
    get => (Int64?)OpenXmlElement?.Height?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Height = (System.Int64?)value;
    }
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
