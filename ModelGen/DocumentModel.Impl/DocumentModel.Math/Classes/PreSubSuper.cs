namespace DocumentModel.Math;

/// <summary>
/// Pre-Sub-Superscript Function.
/// </summary>
public partial class PreSubSuperImpl: ModelElementImpl, PreSubSuper
{
  public DocumentFormat.OpenXml.Math.PreSubSuper? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Math.PreSubSuper?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public PreSubSuperImpl(): base() {}
  
  public PreSubSuperImpl(DocumentFormat.OpenXml.Math.PreSubSuper openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Pre-Sub-Superscript Properties.
  /// </summary>
  public DocumentModel.Math.PreSubSuperProperties? PreSubSuperProperties
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.PreSubSuperProperties>();
        if (item != null)
          return new DocumentModel.Math.PreSubSuperPropertiesImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.PreSubSuperProperties>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Math.PreSubSuperPropertiesImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// Subscript (Pre-Sub-Superscript).
  /// </summary>
  public DocumentModel.Math.SubArgument? SubArgument
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.SubArgument>();
        if (item != null)
          return new DocumentModel.Math.SubArgumentImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.SubArgument>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Math.SubArgumentImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// Superscript(Pre-Sub-Superscript function).
  /// </summary>
  public DocumentModel.Math.SuperArgument? SuperArgument
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.SuperArgument>();
        if (item != null)
          return new DocumentModel.Math.SuperArgumentImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.SuperArgument>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Math.SuperArgumentImpl)?.OpenXmlElement;
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
