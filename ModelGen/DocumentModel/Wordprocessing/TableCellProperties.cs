namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies the set of properties which shall be applied a specific table cell. Each unique property is specified by a child element of this element. In any instance where there is a conflict between the table level, table-level exception, or row level properties with a corresponding table cell property, these properties shall overwrite the table or row wide properties.
/// </summary>
public partial class TableCellProperties: ModelElement<DXW.TableCellProperties>
{
  public TableCellProperties(): base(){ }
  
  public TableCellProperties(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public TableCellProperties(DXW.TableCellProperties openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   ConditionalFormatStyle.
  /// </summary>
  [DataMember]
  public DMW.ConditionalFormatStyle? ConditionalFormatStyle
  {
    get
    {
      var element = _Element?.GetFirstChild<DXW.ConditionalFormatStyle>();
      if (element != null)
        return ConditionalFormatStyleConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.ConditionalFormatStyle>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ConditionalFormatStyleConverter.CreateOpenXmlElement<DXW.ConditionalFormatStyle>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   TableCellWidth.
  /// </summary>
  [DataMember]
  public DMW.TableCellWidth? TableCellWidth
  {
    get
    {
      var element = _Element?.GetFirstChild<DXW.TableCellWidth>();
      if (element != null)
        return TableCellWidthConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.TableCellWidth>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = TableCellWidthConverter.CreateOpenXmlElement<DXW.TableCellWidth>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   GridSpan.
  /// </summary>
  [DataMember]
  public DMW.GridSpan? GridSpan
  {
    get
    {
      var element = _Element?.GetFirstChild<DXW.GridSpan>();
      if (element != null)
        return GridSpanConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.GridSpan>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = GridSpanConverter.CreateOpenXmlElement<DXW.GridSpan>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   HorizontalMerge.
  /// </summary>
  [DataMember]
  public DMW.MergedCellKind? HorizontalMerge
  {
    get
    {
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.MergedCellValues, DMW.MergedCellKind>(_ExistingElement.GetFirstChild<DXW.HorizontalMerge>()?.Val?.Value);
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.HorizontalMerge>();
      if (itemElement != null)
      {
        if (value != null)
          EnumValueConverter.UpdateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.MergedCellValues, DMW.MergedCellKind>(itemElement, (DMW.MergedCellKind)value);
        else
          itemElement.Remove();
      }
      else
      if (value != null)
        _ExistingElement.AddChild(EnumValueConverter.CreateOpenXmlElement<DXW.HorizontalMerge, DocumentFormat.OpenXml.Wordprocessing.MergedCellValues, DMW.MergedCellKind>((DMW.MergedCellKind)value));
    }
  }
  
  
  /// <summary>
  ///   VerticalMerge.
  /// </summary>
  [DataMember]
  public DMW.MergedCellKind? VerticalMerge
  {
    get
    {
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.MergedCellValues, DMW.MergedCellKind>(_ExistingElement.GetFirstChild<DXW.VerticalMerge>()?.Val?.Value);
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.VerticalMerge>();
      if (itemElement != null)
      {
        if (value != null)
          EnumValueConverter.UpdateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.MergedCellValues, DMW.MergedCellKind>(itemElement, (DMW.MergedCellKind)value);
        else
          itemElement.Remove();
      }
      else
      if (value != null)
        _ExistingElement.AddChild(EnumValueConverter.CreateOpenXmlElement<DXW.VerticalMerge, DocumentFormat.OpenXml.Wordprocessing.MergedCellValues, DMW.MergedCellKind>((DMW.MergedCellKind)value));
    }
  }
  
  
  /// <summary>
  ///   TableCellBorders.
  /// </summary>
  [DataMember]
  public DMW.TableCellBorders? TableCellBorders
  {
    get
    {
      var element = _Element?.GetFirstChild<DXW.TableCellBorders>();
      if (element != null)
        return TableCellBordersConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.TableCellBorders>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = TableCellBordersConverter.CreateOpenXmlElement<DXW.TableCellBorders>(value);
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
  ///   NoWrap.
  /// </summary>
  [DataMember]
  public DMW.NoWrap? NoWrap
  {
    get
    {
      var element = _Element?.GetFirstChild<DXW.NoWrap>();
      if (element != null)
        return NoWrapConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.NoWrap>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = NoWrapConverter.CreateOpenXmlElement<DXW.NoWrap>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXW.TableCellMargin>();
      if (element != null)
        return TableCellMarginConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.TableCellMargin>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = TableCellMarginConverter.CreateOpenXmlElement<DXW.TableCellMargin>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   TextDirection.
  /// </summary>
  [DataMember]
  public DMW.TextDirectionKind? TextDirection
  {
    get
    {
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.TextDirectionValues, DMW.TextDirectionKind>(_ExistingElement.GetFirstChild<DXW.TextDirection>()?.Val?.Value);
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.TextDirection>();
      if (itemElement != null)
      {
        if (value != null)
          EnumValueConverter.UpdateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.TextDirectionValues, DMW.TextDirectionKind>(itemElement, (DMW.TextDirectionKind)value);
        else
          itemElement.Remove();
      }
      else
      if (value != null)
        _ExistingElement.AddChild(EnumValueConverter.CreateOpenXmlElement<DXW.TextDirection, DocumentFormat.OpenXml.Wordprocessing.TextDirectionValues, DMW.TextDirectionKind>((DMW.TextDirectionKind)value));
    }
  }
  
  
  /// <summary>
  ///   TableCellFitText.
  /// </summary>
  [DataMember]
  public DMW.TableCellFitText? TableCellFitText
  {
    get
    {
      var element = _Element?.GetFirstChild<DXW.TableCellFitText>();
      if (element != null)
        return TableCellFitTextConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.TableCellFitText>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = TableCellFitTextConverter.CreateOpenXmlElement<DXW.TableCellFitText>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
  
  
  /// <summary>
  ///   HideMark.
  /// </summary>
  [DataMember]
  public DMW.HideMark? HideMark
  {
    get
    {
      var element = _Element?.GetFirstChild<DXW.HideMark>();
      if (element != null)
        return HideMarkConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.HideMark>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = HideMarkConverter.CreateOpenXmlElement<DXW.HideMark>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMW.CellInsertion? CellInsertion
  {
    get
    {
      var element = _Element?.GetFirstChild<DXW.CellInsertion>();
      if (element != null)
        return CellInsertionConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.CellInsertion>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = CellInsertionConverter.CreateOpenXmlElement<DXW.CellInsertion>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMW.CellDeletion? CellDeletion
  {
    get
    {
      var element = _Element?.GetFirstChild<DXW.CellDeletion>();
      if (element != null)
        return CellDeletionConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.CellDeletion>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = CellDeletionConverter.CreateOpenXmlElement<DXW.CellDeletion>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMW.CellMerge? CellMerge
  {
    get
    {
      var element = _Element?.GetFirstChild<DXW.CellMerge>();
      if (element != null)
        return CellMergeConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.CellMerge>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = CellMergeConverter.CreateOpenXmlElement<DXW.CellMerge>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMW.TableCellPropertiesChange? TableCellPropertiesChange
  {
    get
    {
      var element = _Element?.GetFirstChild<DXW.TableCellPropertiesChange>();
      if (element != null)
        return TableCellPropertiesChangeConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.TableCellPropertiesChange>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = TableCellPropertiesChangeConverter.CreateOpenXmlElement<DXW.TableCellPropertiesChange>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
