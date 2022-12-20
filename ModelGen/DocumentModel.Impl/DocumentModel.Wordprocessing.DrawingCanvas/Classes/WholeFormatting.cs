namespace DocumentModel.Wordprocessing.DrawingCanvas;

/// <summary>
/// Defines the WholeFormatting Class.
/// </summary>
public partial class WholeFormattingImpl: ModelElementImpl, WholeFormatting
{
  public DocumentFormat.OpenXml.Office2010.Word.DrawingCanvas.WholeFormatting? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2010.Word.DrawingCanvas.WholeFormatting?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public WholeFormattingImpl(): base() {}
  
  public WholeFormattingImpl(DocumentFormat.OpenXml.Office2010.Word.DrawingCanvas.WholeFormatting openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Outline.
  /// </summary>
  public DocumentModel.Drawings.Outline? Outline
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Outline>();
        if (item != null)
          return new DocumentModel.Drawings.OutlineImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Outline>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.OutlineImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  public DocumentModel.Drawings.EffectList? EffectList
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.EffectList>();
        if (item != null)
          return new DocumentModel.Drawings.EffectListImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.EffectList>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.EffectListImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  public DocumentModel.Drawings.EffectDag? EffectDag
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.EffectDag>();
        if (item != null)
          return new DocumentModel.Drawings.EffectDagImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.EffectDag>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.EffectDagImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
}
