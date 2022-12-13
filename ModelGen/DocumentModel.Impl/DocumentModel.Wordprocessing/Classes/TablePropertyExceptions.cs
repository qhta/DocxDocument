namespace DocumentModel.Wordprocessing;

/// <summary>
/// Table-Level Property Exceptions.
/// </summary>
public class TablePropertyExceptionsImpl: ModelElementImpl, TablePropertyExceptions
{
  public DocumentFormat.OpenXml.Wordprocessing.TablePropertyExceptions? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.TablePropertyExceptions?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public TablePropertyExceptionsImpl(): base() {}
  
  public TablePropertyExceptionsImpl(DocumentFormat.OpenXml.Wordprocessing.TablePropertyExceptions openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Preferred Table Width Exception.
  /// </summary>
  public DocumentModel.Wordprocessing.TableWidthType? TableWidth
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Table Alignment Exception.
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
  /// Table Cell Spacing Exception.
  /// </summary>
  public DocumentModel.Wordprocessing.TableWidthType? TableCellSpacing
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Table Indent from Leading Margin Exception.
  /// </summary>
  public DocumentModel.Wordprocessing.TableIndentation? TableIndentation
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Table Borders Exceptions.
  /// </summary>
  public DocumentModel.Wordprocessing.TableBorders? TableBorders
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Table Shading Exception.
  /// </summary>
  public DocumentModel.Wordprocessing.Shading? Shading
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Table Layout Exception.
  /// </summary>
  public DocumentModel.Wordprocessing.TableLayout? TableLayout
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Table Cell Margin Exceptions.
  /// </summary>
  public DocumentModel.Wordprocessing.TableCellMarginDefault? TableCellMarginDefault
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Table Style Conditional Formatting Settings Exception.
  /// </summary>
  public DocumentModel.Wordprocessing.TableLook? TableLook
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Revision Information for Table-Level Property Exceptions.
  /// </summary>
  public DocumentModel.Wordprocessing.TablePropertyExceptionsChange? TablePropertyExceptionsChange
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
