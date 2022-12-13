namespace DocumentModel.Wordprocessing;

/// <summary>
/// Style Table Properties.
/// </summary>
public class StyleTablePropertiesImpl: ModelElementImpl, StyleTableProperties
{
  public DocumentFormat.OpenXml.Wordprocessing.StyleTableProperties? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.StyleTableProperties?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public StyleTablePropertiesImpl(): base() {}
  
  public StyleTablePropertiesImpl(DocumentFormat.OpenXml.Wordprocessing.StyleTableProperties openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// TableStyleRowBandSize.
  /// </summary>
  public Int32? TableStyleRowBandSize
  {
    get => (System.Int32?)OpenXmlElement?.TableStyleRowBandSize?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.TableStyleRowBandSize != null)
        {
          if (value is not null)
            OpenXmlElement.TableStyleRowBandSize.Val = (System.Int32?)value;
          else
            OpenXmlElement.TableStyleRowBandSize = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.TableStyleRowBandSize = new DocumentFormat.OpenXml.Wordprocessing.TableStyleRowBandSize{ Val = (System.Int32?)value };
        }
      }
    }
  }
  
  /// <summary>
  /// TableStyleColumnBandSize.
  /// </summary>
  public Int32? TableStyleColumnBandSize
  {
    get => (System.Int32?)OpenXmlElement?.TableStyleColumnBandSize?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.TableStyleColumnBandSize != null)
        {
          if (value is not null)
            OpenXmlElement.TableStyleColumnBandSize.Val = (System.Int32?)value;
          else
            OpenXmlElement.TableStyleColumnBandSize = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.TableStyleColumnBandSize = new DocumentFormat.OpenXml.Wordprocessing.TableStyleColumnBandSize{ Val = (System.Int32?)value };
        }
      }
    }
  }
  
  /// <summary>
  /// TableJustification.
  /// </summary>
  public DocumentModel.Wordprocessing.TableRowAlignmentKind? TableJustification
  {
    get => (DocumentModel.Wordprocessing.TableRowAlignmentKind?)OpenXmlElement?.TableJustification?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.TableJustification != null)
        {
          if (value is not null)
            OpenXmlElement.TableJustification.Val = (DocumentFormat.OpenXml.Wordprocessing.TableRowAlignmentValues?)value;
          else
            OpenXmlElement.TableJustification = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.TableJustification = new DocumentFormat.OpenXml.Wordprocessing.TableJustification{ Val = (DocumentFormat.OpenXml.Wordprocessing.TableRowAlignmentValues?)value };
        }
      }
    }
  }
  
  /// <summary>
  /// TableCellSpacing.
  /// </summary>
  public DocumentModel.Wordprocessing.TableWidthType? TableCellSpacing
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// TableIndentation.
  /// </summary>
  public DocumentModel.Wordprocessing.TableIndentation? TableIndentation
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// TableBorders.
  /// </summary>
  public DocumentModel.Wordprocessing.TableBorders? TableBorders
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
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
  /// TableCellMarginDefault.
  /// </summary>
  public DocumentModel.Wordprocessing.TableCellMarginDefault? TableCellMarginDefault
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
