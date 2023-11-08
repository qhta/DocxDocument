namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies the set of table properties which shall be applied to all regions within a table which match the conditional formatting type specified on the parent tblStylePr element. These properties are applied in the order specified via the style hierarchy.
/// </summary>
public partial class TableStyleConditionalFormattingTableProperties: ModelElement<DXW.TableStyleConditionalFormattingTableProperties>
{
  public TableStyleConditionalFormattingTableProperties(): base(){ }
  
  public TableStyleConditionalFormattingTableProperties(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public TableStyleConditionalFormattingTableProperties(DXW.TableStyleConditionalFormattingTableProperties openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   TableJustification.
  /// </summary>
  [DataMember]
  public DMW.TableRowAlignmentKind? TableJustification
  {
    get
    {
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.TableRowAlignmentValues, DMW.TableRowAlignmentKind>(_ExistingElement.GetFirstChild<DXW.TableJustification>()?.Val?.Value);
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.TableJustification>();
      if (itemElement != null)
      {
        if (value != null)
          EnumValueConverter.UpdateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.TableRowAlignmentValues, DMW.TableRowAlignmentKind>(itemElement, (DMW.TableRowAlignmentKind)value);
        else
          itemElement.Remove();
      }
      else
      if (value != null)
        _ExistingElement.AddChild(EnumValueConverter.CreateOpenXmlElement<DXW.TableJustification, DocumentFormat.OpenXml.Wordprocessing.TableRowAlignmentValues, DMW.TableRowAlignmentKind>((DMW.TableRowAlignmentKind)value));
    }
  }
  
  
  /// <summary>
  ///   TableCellSpacing.
  /// </summary>
  [DataMember]
  public DMW.TableCellSpacing? TableCellSpacing
  {
    get
    {
      var element = _Element?.GetFirstChild<DXW.TableCellSpacing>();
      if (element != null)
        return TableCellSpacingConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.TableCellSpacing>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = TableCellSpacingConverter.CreateOpenXmlElement<DXW.TableCellSpacing>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   TableIndentation.
  /// </summary>
  [DataMember]
  public DMW.TableIndentation? TableIndentation
  {
    get
    {
      var element = _Element?.GetFirstChild<DXW.TableIndentation>();
      if (element != null)
        return TableIndentationConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.TableIndentation>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = TableIndentationConverter.CreateOpenXmlElement<DXW.TableIndentation>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   TableBorders.
  /// </summary>
  [DataMember]
  public DMW.TableBorders? TableBorders
  {
    get
    {
      var element = _Element?.GetFirstChild<DXW.TableBorders>();
      if (element != null)
        return TableBordersConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.TableBorders>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = TableBordersConverter.CreateOpenXmlElement<DXW.TableBorders>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXW.Shading>();
      if (element != null)
        return ShadingConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.Shading>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ShadingConverter.CreateOpenXmlElement<DXW.Shading>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   TableCellMarginDefault.
  /// </summary>
  [DataMember]
  public DMW.TableCellMarginDefault? TableCellMarginDefault
  {
    get
    {
      var element = _Element?.GetFirstChild<DXW.TableCellMarginDefault>();
      if (element != null)
        return TableCellMarginDefaultConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.TableCellMarginDefault>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = TableCellMarginDefaultConverter.CreateOpenXmlElement<DXW.TableCellMarginDefault>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
