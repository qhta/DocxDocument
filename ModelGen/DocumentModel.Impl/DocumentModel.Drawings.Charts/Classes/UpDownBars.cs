namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Defines the UpDownBars Class.
/// </summary>
public partial class UpDownBarsImpl: ModelElementImpl, UpDownBars
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Drawing.Charts.UpDownBars? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.UpDownBars?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public UpDownBarsImpl(): base() {}
  
  public UpDownBarsImpl(DocumentFormat.OpenXml.Drawing.Charts.UpDownBars openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Gap Width.
  /// </summary>
  public UInt16? GapWidth
  {
    get => (System.UInt16?)OpenXmlElement?.GapWidth?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.GapWidth != null)
        {
          if (value is not null)
            OpenXmlElement.GapWidth.Val = (System.UInt16?)value;
          else
            OpenXmlElement.GapWidth = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.GapWidth = new DocumentFormat.OpenXml.Drawing.Charts.GapWidth{ Val = (System.UInt16?)value };
        }
      }
    }
  }
  
  /// <summary>
  /// Up Bars.
  /// </summary>
  public DocumentModel.Drawings.Charts.UpBars? UpBars
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.UpBars>();
        if (item != null)
          return new DocumentModel.Drawings.Charts.UpBarsImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.UpBars>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.Charts.UpBarsImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// Down Bars.
  /// </summary>
  public DocumentModel.Drawings.Charts.DownBars? DownBars
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.DownBars>();
        if (item != null)
          return new DocumentModel.Drawings.Charts.DownBarsImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.DownBars>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.Charts.DownBarsImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// Chart Extensibility.
  /// </summary>
  public DocumentModel.Drawings.Charts.ExtensionList? ExtensionList
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.ExtensionList>();
        if (item != null)
          return new DocumentModel.Drawings.Charts.ExtensionListImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.ExtensionList>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.Charts.ExtensionListImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
}
