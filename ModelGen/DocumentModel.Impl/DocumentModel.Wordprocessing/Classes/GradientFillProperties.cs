namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the GradientFillProperties Class.
/// </summary>
public class GradientFillPropertiesImpl: ModelElementImpl, GradientFillProperties
{
  public DocumentFormat.OpenXml.Office2010.Word.GradientFillProperties? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2010.Word.GradientFillProperties?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public GradientFillPropertiesImpl(): base() {}
  
  public GradientFillPropertiesImpl(DocumentFormat.OpenXml.Office2010.Word.GradientFillProperties openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// GradientStopList.
  /// </summary>
  public DocumentModel.Wordprocessing.GradientStopList? GradientStopList
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.GradientStopList>();
        if (item != null)
          return new DocumentModel.Wordprocessing.GradientStopListImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.GradientStopList>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Wordprocessing.GradientStopListImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  public DocumentModel.Wordprocessing.LinearShadeProperties? LinearShadeProperties
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.LinearShadeProperties>();
        if (item != null)
          return new DocumentModel.Wordprocessing.LinearShadePropertiesImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.LinearShadeProperties>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Wordprocessing.LinearShadePropertiesImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  public DocumentModel.Wordprocessing.PathShadeProperties? PathShadeProperties
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.PathShadeProperties>();
        if (item != null)
          return new DocumentModel.Wordprocessing.PathShadePropertiesImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.PathShadeProperties>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Wordprocessing.PathShadePropertiesImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
}
