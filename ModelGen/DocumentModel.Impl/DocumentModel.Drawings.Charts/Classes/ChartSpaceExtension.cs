namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Defines the ChartSpaceExtension Class.
/// </summary>
public partial class ChartSpaceExtensionImpl: ModelElementImpl, ChartSpaceExtension
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Drawing.Charts.ChartSpaceExtension? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.ChartSpaceExtension?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public ChartSpaceExtensionImpl(): base() {}
  
  public ChartSpaceExtensionImpl(DocumentFormat.OpenXml.Drawing.Charts.ChartSpaceExtension openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// URI
  /// </summary>
  public String? Uri
  {
    get => (System.String?)OpenXmlElement?.Uri?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Uri = (System.String?)value;
    }
  }
  
  public DocumentModel.Drawings.Charts.PivotOptions? PivotOptions
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.Charts.PivotOptions>();
        if (item != null)
          return new DocumentModel.Drawings.Charts.PivotOptionsImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.Charts.PivotOptions>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.Charts.PivotOptionsImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  public DocumentModel.Drawings.Charts.SketchOptions? SketchOptions
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.Charts.SketchOptions>();
        if (item != null)
          return new DocumentModel.Drawings.Charts.SketchOptionsImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.Charts.SketchOptions>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.Charts.SketchOptionsImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  public DocumentModel.Drawings.Charts.PivotSource3? PivotSource
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.PivotSource>();
        if (item != null)
          return new DocumentModel.Drawings.Charts.PivotSource3Impl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.PivotSource>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.Charts.PivotSource3Impl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
}
