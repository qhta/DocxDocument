namespace DocumentModel.Drawings;

/// <summary>
/// Preset geometry.
/// </summary>
public partial class PresetGeometryImpl: ModelElementImpl, PresetGeometry
{
  public DocumentFormat.OpenXml.Drawing.PresetGeometry? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.PresetGeometry?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public PresetGeometryImpl(): base() {}
  
  public PresetGeometryImpl(DocumentFormat.OpenXml.Drawing.PresetGeometry openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Preset Shape
  /// </summary>
  public DocumentModel.Drawings.ShapeKind? Preset
  {
    get => (DocumentModel.Drawings.ShapeKind?)OpenXmlElement?.Preset?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Preset = (DocumentFormat.OpenXml.Drawing.ShapeTypeValues?)value;
    }
  }
  
  /// <summary>
  /// List of Shape Adjust Values.
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
