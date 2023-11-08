namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies the set of table properties which shall be applied to the table. These properties are not conditional and shall always be applied (although they are applied before all conditional formatting properties).
/// </summary>
public partial class StyleTableProperties: ModelElement<DXW.StyleTableProperties>
{
  public StyleTableProperties(): base(){ }
  
  public StyleTableProperties(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public StyleTableProperties(DXW.StyleTableProperties openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   TableStyleRowBandSize.
  /// </summary>
  [DataMember]
  public DMW.TableStyleRowBandSize? TableStyleRowBandSize
  {
    get
    {
      var element = _Element?.GetFirstChild<DXW.TableStyleRowBandSize>();
      if (element != null)
        return TableStyleRowBandSizeConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.TableStyleRowBandSize>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = TableStyleRowBandSizeConverter.CreateOpenXmlElement<DXW.TableStyleRowBandSize>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   TableStyleColumnBandSize.
  /// </summary>
  [DataMember]
  public DMW.TableStyleColumnBandSize? TableStyleColumnBandSize
  {
    get
    {
      var element = _Element?.GetFirstChild<DXW.TableStyleColumnBandSize>();
      if (element != null)
        return TableStyleColumnBandSizeConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.TableStyleColumnBandSize>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = TableStyleColumnBandSizeConverter.CreateOpenXmlElement<DXW.TableStyleColumnBandSize>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
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
