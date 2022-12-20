namespace DocumentModel.Drawings;

/// <summary>
/// Text Line Break.
/// </summary>
public partial class BreakImpl: ModelElementImpl, Break
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Drawing.Break? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Break?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public BreakImpl(): base() {}
  
  public BreakImpl(DocumentFormat.OpenXml.Drawing.Break openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Text Run Properties.
  /// </summary>
  public DocumentModel.Drawings.RunProperties? RunProperties
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.RunProperties>();
        if (item != null)
          return new DocumentModel.Drawings.RunPropertiesImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.RunProperties>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.RunPropertiesImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
}
