namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the ExtrusionColor Class.
/// </summary>
public partial class ExtrusionColorImpl: DocumentModel.Wordprocessing.ColorTypeImpl, ExtrusionColor
{
  [XmlIgnore]
  public new DocumentFormat.OpenXml.Office2010.Word.ExtrusionColor? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2010.Word.ExtrusionColor?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public ExtrusionColorImpl(): base() {}
  
  public ExtrusionColorImpl(DocumentFormat.OpenXml.Office2010.Word.ExtrusionColor openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public new DocumentModel.Wordprocessing.RgbColorModelHex? RgbColorModelHex
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.RgbColorModelHex>();
        if (item != null)
          return new DocumentModel.Wordprocessing.RgbColorModelHexImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.RgbColorModelHex>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Wordprocessing.RgbColorModelHexImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  public new DocumentModel.Wordprocessing.SchemeColor? SchemeColor
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.SchemeColor>();
        if (item != null)
          return new DocumentModel.Wordprocessing.SchemeColorImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.SchemeColor>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Wordprocessing.SchemeColorImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
}
