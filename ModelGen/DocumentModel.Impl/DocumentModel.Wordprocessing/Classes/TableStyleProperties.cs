namespace DocumentModel.Wordprocessing;

/// <summary>
/// Style Conditional Table Formatting Properties.
/// </summary>
public partial class TableStylePropertiesImpl: ModelElementImpl, TableStyleProperties
{
  public DocumentFormat.OpenXml.Wordprocessing.TableStyleProperties? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.TableStyleProperties?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public TableStylePropertiesImpl(): base() {}
  
  public TableStylePropertiesImpl(DocumentFormat.OpenXml.Wordprocessing.TableStyleProperties openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Table Style Conditional Formatting Type
  /// </summary>
  public DocumentModel.Wordprocessing.TableStyleOverrideKind? Type
  {
    get => (DocumentModel.Wordprocessing.TableStyleOverrideKind?)OpenXmlElement?.Type?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Type = (DocumentFormat.OpenXml.Wordprocessing.TableStyleOverrideValues?)value;
    }
  }
  
  /// <summary>
  /// Table Style Conditional Formatting Paragraph Properties.
  /// </summary>
  public DocumentModel.Wordprocessing.StyleParagraphProperties? StyleParagraphProperties
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.StyleParagraphProperties>();
        if (item != null)
          return new DocumentModel.Wordprocessing.StyleParagraphPropertiesImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.StyleParagraphProperties>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Wordprocessing.StyleParagraphPropertiesImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// Table Style Conditional Formatting Run Properties.
  /// </summary>
  public DocumentModel.Wordprocessing.RunPropertiesBaseStyle? RunPropertiesBaseStyle
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.RunPropertiesBaseStyle>();
        if (item != null)
          return new DocumentModel.Wordprocessing.RunPropertiesBaseStyleImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.RunPropertiesBaseStyle>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Wordprocessing.RunPropertiesBaseStyleImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// Table Style Conditional Formatting Table Properties.
  /// </summary>
  public DocumentModel.Wordprocessing.TableStyleConditionalFormattingTableProperties? TableStyleConditionalFormattingTableProperties
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.TableStyleConditionalFormattingTableProperties>();
        if (item != null)
          return new DocumentModel.Wordprocessing.TableStyleConditionalFormattingTablePropertiesImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.TableStyleConditionalFormattingTableProperties>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Wordprocessing.TableStyleConditionalFormattingTablePropertiesImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// Table Style Conditional Formatting Table Row Properties.
  /// </summary>
  public DocumentModel.Wordprocessing.TableStyleConditionalFormattingTableRowProperties? TableStyleConditionalFormattingTableRowProperties
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.TableStyleConditionalFormattingTableRowProperties>();
        if (item != null)
          return new DocumentModel.Wordprocessing.TableStyleConditionalFormattingTableRowPropertiesImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.TableStyleConditionalFormattingTableRowProperties>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Wordprocessing.TableStyleConditionalFormattingTableRowPropertiesImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// Table Style Conditional Formatting Table Cell Properties.
  /// </summary>
  public DocumentModel.Wordprocessing.TableStyleConditionalFormattingTableCellProperties? TableStyleConditionalFormattingTableCellProperties
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.TableStyleConditionalFormattingTableCellProperties>();
        if (item != null)
          return new DocumentModel.Wordprocessing.TableStyleConditionalFormattingTableCellPropertiesImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.TableStyleConditionalFormattingTableCellProperties>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Wordprocessing.TableStyleConditionalFormattingTableCellPropertiesImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
}
