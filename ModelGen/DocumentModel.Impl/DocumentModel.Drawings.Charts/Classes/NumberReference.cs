namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Number Reference.
/// </summary>
public partial class NumberReferenceImpl: ModelElementImpl, NumberReference
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Drawing.Charts.NumberReference? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.NumberReference?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public NumberReferenceImpl(): base() {}
  
  public NumberReferenceImpl(DocumentFormat.OpenXml.Drawing.Charts.NumberReference openXmlElement): base(openXmlElement)
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
  /// NumberingCache.
  /// </summary>
  public DocumentModel.Drawings.Charts.NumberingCache? NumberingCache
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.NumberingCache>();
        if (item != null)
          return new DocumentModel.Drawings.Charts.NumberingCacheImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.NumberingCache>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.Charts.NumberingCacheImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// NumRefExtensionList.
  /// </summary>
  public DocumentModel.Drawings.Charts.NumRefExtensionList? NumRefExtensionList
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.NumRefExtensionList>();
        if (item != null)
          return new DocumentModel.Drawings.Charts.NumRefExtensionListImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.NumRefExtensionList>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.Charts.NumRefExtensionListImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
}
