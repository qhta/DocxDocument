namespace DocumentModel.Wordprocessing;

/// <summary>
/// Style Table Cell Properties.
/// </summary>
public class StyleTableCellPropertiesImpl: ModelElementImpl, StyleTableCellProperties
{
  public DocumentFormat.OpenXml.Wordprocessing.StyleTableCellProperties? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.StyleTableCellProperties?)_OpenXmlElement;
    set => _OpenXmlElement = value;
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
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
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
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
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
