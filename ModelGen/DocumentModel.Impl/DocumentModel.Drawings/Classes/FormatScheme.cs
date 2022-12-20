namespace DocumentModel.Drawings;

/// <summary>
/// Format Scheme.
/// </summary>
public partial class FormatSchemeImpl: ModelElementImpl, FormatScheme
{
  public DocumentFormat.OpenXml.Drawing.FormatScheme? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.FormatScheme?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public FormatSchemeImpl(): base() {}
  
  public FormatSchemeImpl(DocumentFormat.OpenXml.Drawing.FormatScheme openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Name
  /// </summary>
  public String? Name
  {
    get => (System.String?)OpenXmlElement?.Name?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Name = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Fill Style List.
  /// </summary>
  public DocumentModel.Drawings.FillStyleList? FillStyleList
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.FillStyleList>();
        if (item != null)
          return new DocumentModel.Drawings.FillStyleListImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.FillStyleList>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.FillStyleListImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// Line Style List.
  /// </summary>
  public DocumentModel.Drawings.LineStyleList? LineStyleList
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.LineStyleList>();
        if (item != null)
          return new DocumentModel.Drawings.LineStyleListImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.LineStyleList>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.LineStyleListImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// Effect Style List.
  /// </summary>
  public DocumentModel.Drawings.EffectStyleList? EffectStyleList
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.EffectStyleList>();
        if (item != null)
          return new DocumentModel.Drawings.EffectStyleListImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.EffectStyleList>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.EffectStyleListImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// Background Fill Style List.
  /// </summary>
  public DocumentModel.Drawings.BackgroundFillStyleList? BackgroundFillStyleList
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.BackgroundFillStyleList>();
        if (item != null)
          return new DocumentModel.Drawings.BackgroundFillStyleListImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.BackgroundFillStyleList>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.BackgroundFillStyleListImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
}
