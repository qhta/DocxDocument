namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Defines the StringReference Class.
/// </summary>
public class StringReferenceImpl: ModelElementImpl, StringReference
{
  public DocumentFormat.OpenXml.Drawing.Charts.StringReference? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.StringReference?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public StringReferenceImpl(): base() {}
  
  public StringReferenceImpl(DocumentFormat.OpenXml.Drawing.Charts.StringReference openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Formula.
  /// </summary>
  public String? Formula
  {
    get => (System.String?)OpenXmlElement?.Formula?.Text;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.Formula != null)
        {
          if (value is not null)
            OpenXmlElement.Formula.Text = value;
          else
            OpenXmlElement.Formula = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.Formula = new DocumentFormat.OpenXml.Drawing.Charts.Formula{ Text = value };
        }
      }
    }
  }
  
  /// <summary>
  /// StringCache.
  /// </summary>
  public DocumentModel.Drawings.Charts.StringCache? StringCache
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.StringCache>();
        if (item != null)
          return new DocumentModel.Drawings.Charts.StringCacheImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.StringCache>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.Charts.StringCacheImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// StrRefExtensionList.
  /// </summary>
  public DocumentModel.Drawings.Charts.StrRefExtensionList? StrRefExtensionList
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.StrRefExtensionList>();
        if (item != null)
          return new DocumentModel.Drawings.Charts.StrRefExtensionListImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.StrRefExtensionList>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.Charts.StrRefExtensionListImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
}
