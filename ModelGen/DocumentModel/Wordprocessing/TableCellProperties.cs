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
      return _Element?.GetObject<DMW.ConditionalFormatStyle,DXW.ConditionalFormatStyle>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.ConditionalFormatStyle,DXW.ConditionalFormatStyle>(value);
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
      return _Element?.GetObject<DMW.TableCellWidth,DXW.TableCellWidth>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.TableCellWidth,DXW.TableCellWidth>(value);
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
      return _Element?.GetObject<DMW.GridSpan,DXW.GridSpan>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.GridSpan,DXW.GridSpan>(value);
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
      return _Element?.GetObject<DMW.TableCellFitText,DXW.TableCellFitText>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.TableCellFitText,DXW.TableCellFitText>(value);
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
      return _Element?.GetObject<DMW.HideMark,DXW.HideMark>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.HideMark,DXW.HideMark>(value);
    }
  }
  
  [DataMember]
  public DMW.CellInsertion? CellInsertion
  {
    get
    {
      return _Element?.GetObject<DMW.CellInsertion,DXW.CellInsertion>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.CellInsertion,DXW.CellInsertion>(value);
    }
  }
  
  [DataMember]
  public DMW.CellDeletion? CellDeletion
  {
    get
    {
      return _Element?.GetObject<DMW.CellDeletion,DXW.CellDeletion>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.CellDeletion,DXW.CellDeletion>(value);
    }
  }
  
  [DataMember]
  public DMW.CellMerge? CellMerge
  {
    get
    {
      return _Element?.GetObject<DMW.CellMerge,DXW.CellMerge>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.CellMerge,DXW.CellMerge>(value);
    }
  }
  
  [DataMember]
  public DMW.TableCellPropertiesChange? TableCellPropertiesChange
  {
    get
    {
      return _Element?.GetObject<DMW.TableCellPropertiesChange,DXW.TableCellPropertiesChange>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.TableCellPropertiesChange,DXW.TableCellPropertiesChange>(value);
    }
  }
  
}
