namespace DocumentModel.Drawings;

/// <summary>
/// Defines the BevelType Class.
/// </summary>
public partial class BevelTypeImpl: ModelElementImpl, BevelType
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Drawing.BevelType? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.BevelType?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public BevelTypeImpl(): base() {}
  
  public BevelTypeImpl(DocumentFormat.OpenXml.Drawing.BevelType openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Width
  /// </summary>
  public Int64? Width
  {
    get => (System.Int64?)OpenXmlElement?.Width?.Value;
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
    get => (System.Int64?)OpenXmlElement?.Height?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Height = (System.Int64?)value;
    }
  }
  
  /// <summary>
  /// Preset Bevel
  /// </summary>
  public DocumentModel.Drawings.BevelPresetKind? Preset
  {
    get => (DocumentModel.Drawings.BevelPresetKind?)OpenXmlElement?.Preset?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Preset = (DocumentFormat.OpenXml.Drawing.BevelPresetValues?)value;
    }
  }
  
}
