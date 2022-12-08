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
  
  /// <summary>
  /// Preferred Table Width Exception.
  /// </summary>
  public TableWidthType? TableWidth
  {
    get;
    set;
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
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.TableJustification>();
        if (openXmlElement != null)
        {
          if (value != null)
            openXmlElement.Val = (DocumentFormat.OpenXml.Wordprocessing.TableRowAlignmentValues?)value;
          else
            openXmlElement.Remove();
        }
        else
        {
          if (value != null)
          {
            openXmlElement = new DocumentFormat.OpenXml.Wordprocessing.TableJustification{ Val = (DocumentFormat.OpenXml.Wordprocessing.TableRowAlignmentValues?)value };
            OpenXmlElement.AddChild(openXmlElement);
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
    get;
    set;
  }
  
  /// <summary>
  /// Table Indent from Leading Margin Exception.
  /// </summary>
  public TableIndentation? TableIndentation
  {
    get;
    set;
  }
  
  /// <summary>
  /// Table Borders Exceptions.
  /// </summary>
  public TableBorders? TableBorders
  {
    get;
    set;
  }
  
  /// <summary>
  /// Table Shading Exception.
  /// </summary>
  public Shading? Shading
  {
    get;
    set;
  }
  
  /// <summary>
  /// Table Layout Exception.
  /// </summary>
  public TableLayout? TableLayout
  {
    get;
    set;
  }
  
  /// <summary>
  /// Table Cell Margin Exceptions.
  /// </summary>
  public TableCellMarginDefault? TableCellMarginDefault
  {
    get;
    set;
  }
  
  /// <summary>
  /// Table Style Conditional Formatting Settings Exception.
  /// </summary>
  public TableLook? TableLook
  {
    get;
    set;
  }
  
}
