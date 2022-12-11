namespace DocumentModel.Wordprocessing;

/// <summary>
/// Previous Table-Level Property Exceptions.
/// </summary>
public class PreviousTablePropertyExceptionsImpl: ModelElementImpl, PreviousTablePropertyExceptions
{
  public DocumentFormat.OpenXml.Wordprocessing.PreviousTablePropertyExceptions? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.PreviousTablePropertyExceptions?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public PreviousTablePropertyExceptionsImpl(): base() {}
  
  public PreviousTablePropertyExceptionsImpl(DocumentFormat.OpenXml.Wordprocessing.PreviousTablePropertyExceptions openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Preferred Table Width Exception.
  /// </summary>
  public TableWidthType? TableWidth
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Table Alignment Exception.
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
  /// Table Cell Spacing Exception.
  /// </summary>
  public TableWidthType? TableCellSpacing
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Table Indent from Leading Margin Exception.
  /// </summary>
  public TableIndentation? TableIndentation
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Table Borders Exceptions.
  /// </summary>
  public TableBorders? TableBorders
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Table Shading Exception.
  /// </summary>
  public Shading? Shading
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Table Layout Exception.
  /// </summary>
  public TableLayout? TableLayout
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Table Cell Margin Exceptions.
  /// </summary>
  public TableCellMarginDefault? TableCellMarginDefault
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Table Style Conditional Formatting Settings Exception.
  /// </summary>
  public TableLook? TableLook
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
