namespace DocumentModel.Drawings;

/// <summary>
/// Defines the FontCollectionType Class.
/// </summary>
public class FontCollectionTypeImpl: ModelElementImpl, FontCollectionType
{
  public DocumentFormat.OpenXml.Drawing.FontCollectionType? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.FontCollectionType?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public FontCollectionTypeImpl(): base() {}
  
  public FontCollectionTypeImpl(DocumentFormat.OpenXml.Drawing.FontCollectionType openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Latin Font.
  /// </summary>
  public virtual DocumentModel.Drawings.TextFontType? LatinFont
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.TextFontType>();
        if (item != null)
          return new DocumentModel.Drawings.TextFontTypeImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.TextFontType>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.TextFontTypeImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// East Asian Font.
  /// </summary>
  public virtual DocumentModel.Drawings.TextFontType? EastAsianFont
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.TextFontType>();
        if (item != null)
          return new DocumentModel.Drawings.TextFontTypeImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.TextFontType>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.TextFontTypeImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// Complex Script Font.
  /// </summary>
  public virtual DocumentModel.Drawings.TextFontType? ComplexScriptFont
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.TextFontType>();
        if (item != null)
          return new DocumentModel.Drawings.TextFontTypeImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.TextFontType>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.TextFontTypeImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
}
