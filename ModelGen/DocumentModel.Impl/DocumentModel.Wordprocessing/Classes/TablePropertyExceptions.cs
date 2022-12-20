namespace DocumentModel.Wordprocessing;

/// <summary>
/// Table-Level Property Exceptions.
/// </summary>
public partial class TablePropertyExceptionsImpl: ModelElementImpl, TablePropertyExceptions
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Wordprocessing.TablePropertyExceptions? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.TablePropertyExceptions?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
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
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.TableWidthType>();
        if (item != null)
          return new DocumentModel.Wordprocessing.TableWidthTypeImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.TableWidthType>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Wordprocessing.TableWidthTypeImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
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
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.TableWidthType>();
        if (item != null)
          return new DocumentModel.Wordprocessing.TableWidthTypeImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.TableWidthType>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Wordprocessing.TableWidthTypeImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// Table Indent from Leading Margin Exception.
  /// </summary>
  public DocumentModel.Wordprocessing.TableIndentation? TableIndentation
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.TableIndentation>();
        if (item != null)
          return new DocumentModel.Wordprocessing.TableIndentationImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.TableIndentation>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Wordprocessing.TableIndentationImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// Table Borders Exceptions.
  /// </summary>
  public DocumentModel.Wordprocessing.TableBorders? TableBorders
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.TableBorders>();
        if (item != null)
          return new DocumentModel.Wordprocessing.TableBordersImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.TableBorders>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Wordprocessing.TableBordersImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// Table Shading Exception.
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
  /// Table Layout Exception.
  /// </summary>
  public DocumentModel.Wordprocessing.TableLayout? TableLayout
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.TableLayout>();
        if (item != null)
          return new DocumentModel.Wordprocessing.TableLayoutImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.TableLayout>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Wordprocessing.TableLayoutImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// Table Cell Margin Exceptions.
  /// </summary>
  public DocumentModel.Wordprocessing.TableCellMarginDefault? TableCellMarginDefault
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.TableCellMarginDefault>();
        if (item != null)
          return new DocumentModel.Wordprocessing.TableCellMarginDefaultImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.TableCellMarginDefault>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Wordprocessing.TableCellMarginDefaultImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// Table Style Conditional Formatting Settings Exception.
  /// </summary>
  public DocumentModel.Wordprocessing.TableLook? TableLook
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.TableLook>();
        if (item != null)
          return new DocumentModel.Wordprocessing.TableLookImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.TableLook>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Wordprocessing.TableLookImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// Revision Information for Table-Level Property Exceptions.
  /// </summary>
  public DocumentModel.Wordprocessing.TablePropertyExceptionsChange? TablePropertyExceptionsChange
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.TablePropertyExceptionsChange>();
        if (item != null)
          return new DocumentModel.Wordprocessing.TablePropertyExceptionsChangeImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.TablePropertyExceptionsChange>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Wordprocessing.TablePropertyExceptionsChangeImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
}
