namespace DocumentModel.Wordprocessing;

/// <summary>
/// Table Style Conditional Formatting Table Properties.
/// </summary>
public class TableStyleConditionalFormattingTablePropertiesImpl: ModelElementImpl, TableStyleConditionalFormattingTableProperties
{
  public DocumentFormat.OpenXml.Wordprocessing.TableStyleConditionalFormattingTableProperties? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.TableStyleConditionalFormattingTableProperties?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public TableStyleConditionalFormattingTablePropertiesImpl(): base() {}
  
  public TableStyleConditionalFormattingTablePropertiesImpl(DocumentFormat.OpenXml.Wordprocessing.TableStyleConditionalFormattingTableProperties openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
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
  /// TableIndentation.
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
  /// TableBorders.
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
  /// TableCellMarginDefault.
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
  
}
