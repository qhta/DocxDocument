namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Defines the ChartText Class.
/// </summary>
public partial class ChartTextImpl: ModelElementImpl, ChartText
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Drawing.Charts.ChartText? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.ChartText?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public ChartTextImpl(): base() {}
  
  public ChartTextImpl(DocumentFormat.OpenXml.Drawing.Charts.ChartText openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// String Reference.
  /// </summary>
  public DocumentModel.Drawings.Charts.StringReference? StringReference
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.StringReference>();
        if (item != null)
          return new DocumentModel.Drawings.Charts.StringReferenceImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.StringReference>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.Charts.StringReferenceImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// Rich Text.
  /// </summary>
  public DocumentModel.Drawings.Charts.RichText? RichText
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.RichText>();
        if (item != null)
          return new DocumentModel.Drawings.Charts.RichTextImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.RichText>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.Charts.RichTextImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// String Literal.
  /// </summary>
  public DocumentModel.Drawings.Charts.StringLiteral? StringLiteral
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.StringLiteral>();
        if (item != null)
          return new DocumentModel.Drawings.Charts.StringLiteralImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.StringLiteral>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.Charts.StringLiteralImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
}
