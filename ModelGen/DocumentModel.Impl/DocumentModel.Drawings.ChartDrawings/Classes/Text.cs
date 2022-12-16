namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
/// Defines the Text Class.
/// </summary>
public class TextImpl: ModelElementImpl, Text
{
  public DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Text? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Text?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public TextImpl(): base() {}
  
  public TextImpl(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Text openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// TextData.
  /// </summary>
  public DocumentModel.Drawings.ChartDrawings.TextData? TextData
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.TextData>();
        if (item != null)
          return new DocumentModel.Drawings.ChartDrawings.TextDataImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.TextData>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.ChartDrawings.TextDataImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// RichTextBody.
  /// </summary>
  public DocumentModel.Drawings.ChartDrawings.RichTextBody? RichTextBody
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.RichTextBody>();
        if (item != null)
          return new DocumentModel.Drawings.ChartDrawings.RichTextBodyImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.RichTextBody>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.ChartDrawings.RichTextBodyImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
}
