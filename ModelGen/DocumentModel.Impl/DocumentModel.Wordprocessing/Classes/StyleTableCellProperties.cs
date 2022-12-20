namespace DocumentModel.Wordprocessing;

/// <summary>
/// Style Table Cell Properties.
/// </summary>
public partial class StyleTableCellPropertiesImpl: ModelElementImpl, StyleTableCellProperties
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Wordprocessing.StyleTableCellProperties? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.StyleTableCellProperties?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public StyleTableCellPropertiesImpl(): base() {}
  
  public StyleTableCellPropertiesImpl(DocumentFormat.OpenXml.Wordprocessing.StyleTableCellProperties openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Shading.
  /// </summary>
  public DocumentModel.Wordprocessing.Shading? Shading
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Shading>();
        if (item != null)
          return new DocumentModel.Wordprocessing.ShadingImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Shading>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Wordprocessing.ShadingImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// NoWrap.
  /// </summary>
  public DocumentModel.Wordprocessing.OnOffOnlyKind? NoWrap
  {
    get => (DocumentModel.Wordprocessing.OnOffOnlyKind?)OpenXmlElement?.NoWrap?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.NoWrap != null)
        {
          if (value is not null)
            OpenXmlElement.NoWrap.Val = (DocumentFormat.OpenXml.Wordprocessing.OnOffOnlyValues?)value;
          else
            OpenXmlElement.NoWrap = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.NoWrap = new DocumentFormat.OpenXml.Wordprocessing.NoWrap{ Val = (DocumentFormat.OpenXml.Wordprocessing.OnOffOnlyValues?)value };
        }
      }
    }
  }
  
  /// <summary>
  /// TableCellMargin.
  /// </summary>
  public DocumentModel.Wordprocessing.TableCellMargin? TableCellMargin
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.TableCellMargin>();
        if (item != null)
          return new DocumentModel.Wordprocessing.TableCellMarginImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.TableCellMargin>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Wordprocessing.TableCellMarginImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// TableCellVerticalAlignment.
  /// </summary>
  public DocumentModel.Wordprocessing.TableVerticalAlignmentKind? TableCellVerticalAlignment
  {
    get => (DocumentModel.Wordprocessing.TableVerticalAlignmentKind?)OpenXmlElement?.TableCellVerticalAlignment?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.TableCellVerticalAlignment != null)
        {
          if (value is not null)
            OpenXmlElement.TableCellVerticalAlignment.Val = (DocumentFormat.OpenXml.Wordprocessing.TableVerticalAlignmentValues?)value;
          else
            OpenXmlElement.TableCellVerticalAlignment = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.TableCellVerticalAlignment = new DocumentFormat.OpenXml.Wordprocessing.TableCellVerticalAlignment{ Val = (DocumentFormat.OpenXml.Wordprocessing.TableVerticalAlignmentValues?)value };
        }
      }
    }
  }
  
}
