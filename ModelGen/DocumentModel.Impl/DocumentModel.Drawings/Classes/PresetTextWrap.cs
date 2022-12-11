namespace DocumentModel.Drawings;

/// <summary>
/// Preset Text Warp.
/// </summary>
public class PresetTextWrapImpl: ModelElementImpl, PresetTextWrap
{
  public DocumentFormat.OpenXml.Drawing.PresetTextWrap? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.PresetTextWrap?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public PresetTextWrapImpl(): base() {}
  
  public PresetTextWrapImpl(DocumentFormat.OpenXml.Drawing.PresetTextWrap openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
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
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
