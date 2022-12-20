namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Defines the BubbleSize Class.
/// </summary>
public partial class BubbleSizeImpl: DocumentModel.Drawings.Charts.NumberDataSourceTypeImpl, BubbleSize
{
  [XmlIgnore]
  public new DocumentFormat.OpenXml.Drawing.Charts.BubbleSize? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.BubbleSize?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public BubbleSizeImpl(): base() {}
  
  public BubbleSizeImpl(DocumentFormat.OpenXml.Drawing.Charts.BubbleSize openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public new DocumentModel.Drawings.Charts.NumberReference? NumberReference
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.NumberReference>();
        if (item != null)
          return new DocumentModel.Drawings.Charts.NumberReferenceImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.NumberReference>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.Charts.NumberReferenceImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  public new DocumentModel.Drawings.Charts.NumberLiteral? NumberLiteral
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.NumberLiteral>();
        if (item != null)
          return new DocumentModel.Drawings.Charts.NumberLiteralImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.NumberLiteral>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.Charts.NumberLiteralImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
}
