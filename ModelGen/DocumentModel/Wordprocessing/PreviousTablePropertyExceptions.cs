namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies a set of table properties which shall be applied to the contents of this row in place of the table properties specified in the tblPr element.
/// </summary>
public partial class PreviousTablePropertyExceptions: ModelElement<DXW.PreviousTablePropertyExceptions>
{
  public PreviousTablePropertyExceptions(): base(){ }
  
  public PreviousTablePropertyExceptions(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public PreviousTablePropertyExceptions(DXW.PreviousTablePropertyExceptions openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Preferred Table Width Exception.
  /// </summary>
  [DataMember]
  public DMW.TableWidth? TableWidth
  {
    get
    {
      var element = _Element?.GetFirstChild<DXW.TableWidth>();
      if (element != null)
        return TableWidthConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.TableWidth>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = TableWidthConverter.CreateOpenXmlElement<DXW.TableWidth>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   Table Alignment Exception.
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
  ///   Table Cell Spacing Exception.
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
  ///   Table Indent from Leading Margin Exception.
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
  ///   Table Borders Exceptions.
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
  ///   Table Shading Exception.
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
  ///   Table Layout Exception.
  /// </summary>
  [DataMember]
  public DMW.TableLayout? TableLayout
  {
    get
    {
      var element = _Element?.GetFirstChild<DXW.TableLayout>();
      if (element != null)
        return TableLayoutConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.TableLayout>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = TableLayoutConverter.CreateOpenXmlElement<DXW.TableLayout>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   Table Cell Margin Exceptions.
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
  
  
  /// <summary>
  ///   Table Style Conditional Formatting Settings Exception.
  /// </summary>
  [DataMember]
  public DMW.TableLook? TableLook
  {
    get
    {
      var element = _Element?.GetFirstChild<DXW.TableLook>();
      if (element != null)
        return TableLookConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.TableLook>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = TableLookConverter.CreateOpenXmlElement<DXW.TableLook>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
