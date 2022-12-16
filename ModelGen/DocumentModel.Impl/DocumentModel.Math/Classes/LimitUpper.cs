namespace DocumentModel.Math;

/// <summary>
/// Upper-Limit Function.
/// </summary>
public class LimitUpperImpl: ModelElementImpl, LimitUpper
{
  public DocumentFormat.OpenXml.Math.LimitUpper? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Math.LimitUpper?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public LimitUpperImpl(): base() {}
  
  public LimitUpperImpl(DocumentFormat.OpenXml.Math.LimitUpper openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Upper Limit Properties.
  /// </summary>
  public DocumentModel.Math.LimitUpperProperties? LimitUpperProperties
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.LimitUpperProperties>();
        if (item != null)
          return new DocumentModel.Math.LimitUpperPropertiesImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.LimitUpperProperties>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Math.LimitUpperPropertiesImpl)?.OpenXmlElement;
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
  
  /// <summary>
  /// Limit (Upper).
  /// </summary>
  public DocumentModel.Math.Limit? Limit
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.Limit>();
        if (item != null)
          return new DocumentModel.Math.LimitImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.Limit>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Math.LimitImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
}
