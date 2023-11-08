namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies a set of formatting properties which shall be conditionally applied to the parts of a table which match the requirement specified on the type attribute. These table conditional formats are applied to different regions of the table as follows:
/// </summary>
public partial class TableStyleProperties: ModelElement<DXW.TableStyleProperties>
{
  public TableStyleProperties(): base(){ }
  
  public TableStyleProperties(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public TableStyleProperties(DXW.TableStyleProperties openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Table Style Conditional Formatting Paragraph Properties.
  /// </summary>
  [DataMember]
  public DMW.StyleParagraphProperties? StyleParagraphProperties
  {
    get
    {
      var element = _Element?.GetFirstChild<DXW.StyleParagraphProperties>();
      if (element != null)
        return StyleParagraphPropertiesConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.StyleParagraphProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = StyleParagraphPropertiesConverter.CreateOpenXmlElement<DXW.StyleParagraphProperties>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   Table Style Conditional Formatting Run Properties.
  /// </summary>
  [DataMember]
  public DMW.RunPropertiesBaseStyle? RunPropertiesBaseStyle
  {
    get
    {
      var element = _Element?.GetFirstChild<DXW.RunPropertiesBaseStyle>();
      if (element != null)
        return RunPropertiesBaseStyleConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.RunPropertiesBaseStyle>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = RunPropertiesBaseStyleConverter.CreateOpenXmlElement<DXW.RunPropertiesBaseStyle>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   Table Style Conditional Formatting Table Properties.
  /// </summary>
  [DataMember]
  public DMW.TableStyleConditionalFormattingTableProperties? TableStyleConditionalFormattingTableProperties
  {
    get
    {
      var element = _Element?.GetFirstChild<DXW.TableStyleConditionalFormattingTableProperties>();
      if (element != null)
        return TableStyleConditionalFormattingTablePropertiesConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.TableStyleConditionalFormattingTableProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = TableStyleConditionalFormattingTablePropertiesConverter.CreateOpenXmlElement<DXW.TableStyleConditionalFormattingTableProperties>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   Table Style Conditional Formatting Table Row Properties.
  /// </summary>
  [DataMember]
  public DMW.TableStyleConditionalFormattingTableRowProperties? TableStyleConditionalFormattingTableRowProperties
  {
    get
    {
      var element = _Element?.GetFirstChild<DXW.TableStyleConditionalFormattingTableRowProperties>();
      if (element != null)
        return TableStyleConditionalFormattingTableRowPropertiesConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.TableStyleConditionalFormattingTableRowProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = TableStyleConditionalFormattingTableRowPropertiesConverter.CreateOpenXmlElement<DXW.TableStyleConditionalFormattingTableRowProperties>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   Table Style Conditional Formatting Table Cell Properties.
  /// </summary>
  [DataMember]
  public DMW.TableStyleConditionalFormattingTableCellProperties? TableStyleConditionalFormattingTableCellProperties
  {
    get
    {
      var element = _Element?.GetFirstChild<DXW.TableStyleConditionalFormattingTableCellProperties>();
      if (element != null)
        return TableStyleConditionalFormattingTableCellPropertiesConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.TableStyleConditionalFormattingTableCellProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = TableStyleConditionalFormattingTableCellPropertiesConverter.CreateOpenXmlElement<DXW.TableStyleConditionalFormattingTableCellProperties>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
