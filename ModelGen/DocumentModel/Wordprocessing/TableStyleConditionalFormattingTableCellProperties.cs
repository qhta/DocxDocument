namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies the set of table cell properties which shall be applied to all regions within a table which match the conditional formatting type specified on the parent tblStylePr element. These properties are applied in the order specified via the style hierarchy.
/// </summary>
public partial class TableStyleConditionalFormattingTableCellProperties: ModelElement<DXW.TableStyleConditionalFormattingTableCellProperties>
{
  public TableStyleConditionalFormattingTableCellProperties(): base(){ }
  
  public TableStyleConditionalFormattingTableCellProperties(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public TableStyleConditionalFormattingTableCellProperties(DXW.TableStyleConditionalFormattingTableCellProperties openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   TableCellBorders.
  /// </summary>
  [DataMember]
  public DMW.TableCellBorders? TableCellBorders
  {
    get
    {
      return _Element?.GetObject<DMW.TableCellBorders,DXW.TableCellBorders>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.TableCellBorders,DXW.TableCellBorders>(value);
    }
  }
  
  
  /// <summary>
  ///   Shading.
  /// </summary>
  [DataMember]
  public DMW.Shading? Shading
  {
    get
    {
      return _Element?.GetObject<DMW.Shading,DXW.Shading>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.Shading,DXW.Shading>(value);
    }
  }
  
  
  /// <summary>
  ///   NoWrap.
  /// </summary>
  [DataMember]
  public DMW.NoWrap? NoWrap
  {
    get
    {
      return _Element?.GetObject<DMW.NoWrap,DXW.NoWrap>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.NoWrap,DXW.NoWrap>(value);
    }
  }
  
  
  /// <summary>
  ///   TableCellMargin.
  /// </summary>
  [DataMember]
  public DMW.TableCellMargin? TableCellMargin
  {
    get
    {
      return _Element?.GetObject<DMW.TableCellMargin,DXW.TableCellMargin>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.TableCellMargin,DXW.TableCellMargin>(value);
    }
  }
  
  
  /// <summary>
  ///   TableCellVerticalAlignment.
  /// </summary>
  [DataMember]
  public DMW.TableVerticalAlignmentKind? TableCellVerticalAlignment
  {
    get
    {
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.TableVerticalAlignmentValues, DMW.TableVerticalAlignmentKind>(_ExistingElement.GetFirstChild<DXW.TableCellVerticalAlignment>()?.Val?.Value);
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.TableCellVerticalAlignment>();
      if (itemElement != null)
      {
        if (value != null)
          EnumValueConverter.UpdateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.TableVerticalAlignmentValues, DMW.TableVerticalAlignmentKind>(itemElement, (DMW.TableVerticalAlignmentKind)value);
        else
          itemElement.Remove();
      }
      else
      if (value != null)
        _ExistingElement.AddChild(EnumValueConverter.CreateOpenXmlElement<DXW.TableCellVerticalAlignment, DocumentFormat.OpenXml.Wordprocessing.TableVerticalAlignmentValues, DMW.TableVerticalAlignmentKind>((DMW.TableVerticalAlignmentKind)value));
    }
  }
  
}
