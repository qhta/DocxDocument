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
    get
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.TableStyleRowBandSize>();
        return (Int32?)openXmlElement?.Val?.Value;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.TableStyleRowBandSize>();
        if (item != null)
        {
          if (value is not null)
            item.Val = (System.Int32?)value;
          else
            item.Remove();
        }
        else
        {
          if (value is not null)
          {
            item = new DocumentFormat.OpenXml.Wordprocessing.TableStyleRowBandSize{ Val = (System.Int32?)value };
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  /// <summary>
  /// TableStyleColumnBandSize.
  /// </summary>
  public Int32? TableStyleColumnBandSize
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.TableStyleColumnBandSize>();
        return (Int32?)openXmlElement?.Val?.Value;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.TableStyleColumnBandSize>();
        if (item != null)
        {
          if (value is not null)
            item.Val = (System.Int32?)value;
          else
            item.Remove();
        }
        else
        {
          if (value is not null)
          {
            item = new DocumentFormat.OpenXml.Wordprocessing.TableStyleColumnBandSize{ Val = (System.Int32?)value };
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  /// <summary>
  /// TableJustification.
  /// </summary>
  public TableRowAlignmentKind? TableJustification
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.TableJustification>();
        return (TableRowAlignmentKind?)openXmlElement?.Val?.Value;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.TableJustification>();
        if (item != null)
        {
          if (value is not null)
            item.Val = (DocumentFormat.OpenXml.Wordprocessing.TableRowAlignmentValues?)value;
          else
            item.Remove();
        }
        else
        {
          if (value is not null)
          {
            item = new DocumentFormat.OpenXml.Wordprocessing.TableJustification{ Val = (DocumentFormat.OpenXml.Wordprocessing.TableRowAlignmentValues?)value };
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  /// <summary>
  /// TableCellSpacing.
  /// </summary>
  public TableWidthType? TableCellSpacing
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// TableIndentation.
  /// </summary>
  public TableIndentation? TableIndentation
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// TableBorders.
  /// </summary>
  public TableBorders? TableBorders
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Shading.
  /// </summary>
  public Shading? Shading
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// TableCellMarginDefault.
  /// </summary>
  public TableCellMarginDefault? TableCellMarginDefault
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
