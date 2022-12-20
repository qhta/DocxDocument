namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Layout.
/// </summary>
public partial class LayoutImpl: ModelElementImpl, Layout
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Drawing.Charts.Layout? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.Layout?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public LayoutImpl(): base() {}
  
  public LayoutImpl(DocumentFormat.OpenXml.Drawing.Charts.Layout openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Manual Layout.
  /// </summary>
  public DocumentModel.Drawings.Charts.ManualLayout? ManualLayout
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.ManualLayout>();
        if (item != null)
          return new DocumentModel.Drawings.Charts.ManualLayoutImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.ManualLayout>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.Charts.ManualLayoutImpl)?.OpenXmlElement;
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
