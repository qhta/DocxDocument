namespace DocumentModel.Drawings;

/// <summary>
/// Preset Text Warp.
/// </summary>
public partial class PresetTextWrapImpl: ModelElementImpl, PresetTextWrap
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
  public DocumentModel.Drawings.TextShapeKind? Preset
  {
    get => (DocumentModel.Drawings.TextShapeKind?)OpenXmlElement?.Preset?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Preset = (DocumentFormat.OpenXml.Drawing.TextShapeValues?)value;
    }
  }
  
  /// <summary>
  /// Adjust Value List.
  /// </summary>
  public DocumentModel.Drawings.AdjustValueList? AdjustValueList
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.AdjustValueList>();
        if (item != null)
          return new DocumentModel.Drawings.AdjustValueListImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.AdjustValueList>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.AdjustValueListImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
}
