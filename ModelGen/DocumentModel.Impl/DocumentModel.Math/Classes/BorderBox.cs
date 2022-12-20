namespace DocumentModel.Math;

/// <summary>
/// Border-Box Function.
/// </summary>
public partial class BorderBoxImpl: ModelElementImpl, BorderBox
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Math.BorderBox? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Math.BorderBox?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public BorderBoxImpl(): base() {}
  
  public BorderBoxImpl(DocumentFormat.OpenXml.Math.BorderBox openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Border Box Properties.
  /// </summary>
  public DocumentModel.Math.BorderBoxProperties? BorderBoxProperties
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.BorderBoxProperties>();
        if (item != null)
          return new DocumentModel.Math.BorderBoxPropertiesImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.BorderBoxProperties>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Math.BorderBoxPropertiesImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// Base.
  /// </summary>
  public DocumentModel.Math.Base? Base
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.Base>();
        if (item != null)
          return new DocumentModel.Math.BaseImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.Base>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Math.BaseImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
}
