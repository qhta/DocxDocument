namespace DocumentModel.Math;

/// <summary>
/// Phantom Function.
/// </summary>
public partial class PhantomImpl: ModelElementImpl, Phantom
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Math.Phantom? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Math.Phantom?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public PhantomImpl(): base() {}
  
  public PhantomImpl(DocumentFormat.OpenXml.Math.Phantom openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Phantom Properties.
  /// </summary>
  public DocumentModel.Math.PhantomProperties? PhantomProperties
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.PhantomProperties>();
        if (item != null)
          return new DocumentModel.Math.PhantomPropertiesImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.PhantomProperties>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Math.PhantomPropertiesImpl)?.OpenXmlElement;
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
