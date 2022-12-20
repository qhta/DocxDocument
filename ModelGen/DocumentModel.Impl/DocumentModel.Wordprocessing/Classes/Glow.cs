namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the Glow Class.
/// </summary>
public partial class GlowImpl: ModelElementImpl, Glow
{
  public DocumentFormat.OpenXml.Office2010.Word.Glow? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2010.Word.Glow?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public GlowImpl(): base() {}
  
  public GlowImpl(DocumentFormat.OpenXml.Office2010.Word.Glow openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// rad, this property is only available in Office 2010 and later.
  /// </summary>
  public Int64? GlowRadius
  {
    get => (System.Int64?)OpenXmlElement?.GlowRadius?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.GlowRadius = (System.Int64?)value;
    }
  }
  
  /// <summary>
  /// RgbColorModelHex.
  /// </summary>
  public DocumentModel.Wordprocessing.RgbColorModelHex? RgbColorModelHex
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
  
  /// <summary>
  /// SchemeColor.
  /// </summary>
  public DocumentModel.Wordprocessing.SchemeColor? SchemeColor
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
