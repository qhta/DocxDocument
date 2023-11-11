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
      return _Element?.GetObject<DMW.StyleParagraphProperties,DXW.StyleParagraphProperties>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.StyleParagraphProperties,DXW.StyleParagraphProperties>(value);
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
      return _Element?.GetObject<DMW.RunPropertiesBaseStyle,DXW.RunPropertiesBaseStyle>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.RunPropertiesBaseStyle,DXW.RunPropertiesBaseStyle>(value);
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
      return _Element?.GetObject<DMW.TableStyleConditionalFormattingTableProperties,DXW.TableStyleConditionalFormattingTableProperties>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.TableStyleConditionalFormattingTableProperties,DXW.TableStyleConditionalFormattingTableProperties>(value);
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
      return _Element?.GetObject<DMW.TableStyleConditionalFormattingTableRowProperties,DXW.TableStyleConditionalFormattingTableRowProperties>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.TableStyleConditionalFormattingTableRowProperties,DXW.TableStyleConditionalFormattingTableRowProperties>(value);
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
      return _Element?.GetObject<DMW.TableStyleConditionalFormattingTableCellProperties,DXW.TableStyleConditionalFormattingTableCellProperties>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.TableStyleConditionalFormattingTableCellProperties,DXW.TableStyleConditionalFormattingTableCellProperties>(value);
    }
  }
  
}
