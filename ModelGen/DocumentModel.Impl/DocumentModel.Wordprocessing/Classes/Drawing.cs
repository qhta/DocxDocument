namespace DocumentModel.Wordprocessing;

/// <summary>
/// DrawingML Object.
/// </summary>
public partial class DrawingImpl: ModelElementImpl, Drawing
{
  public DocumentFormat.OpenXml.Wordprocessing.Drawing? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.Drawing?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public DrawingImpl(): base() {}
  
  public DrawingImpl(DocumentFormat.OpenXml.Wordprocessing.Drawing openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Drawing Element Anchor.
  /// </summary>
  public DocumentModel.Drawings.Wordprocessing.Anchor? Anchor
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Wordprocessing.Anchor>();
        if (item != null)
          return new DocumentModel.Drawings.Wordprocessing.AnchorImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Wordprocessing.Anchor>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.Wordprocessing.AnchorImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// Inline Drawing Object.
  /// </summary>
  public DocumentModel.Drawings.Wordprocessing.Inline? Inline
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Wordprocessing.Inline>();
        if (item != null)
          return new DocumentModel.Drawings.Wordprocessing.InlineImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Wordprocessing.Inline>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.Wordprocessing.InlineImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
}
