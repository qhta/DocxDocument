namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Defines the ChartText Class.
/// </summary>
public partial class ChartText3Impl: ModelElementImpl, ChartText3
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Office2013.Drawing.Chart.ChartText? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2013.Drawing.Chart.ChartText?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public ChartText3Impl(): base() {}
  
  public ChartText3Impl(DocumentFormat.OpenXml.Office2013.Drawing.Chart.ChartText openXmlElement): base(openXmlElement)
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
