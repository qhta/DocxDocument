namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies a previous set of table properties, the modifications to which shall be attributed to a revision by a particular author and at a particular time. This element contains the table property settings which were previously in place before a specific set of revisions by one author. These properties affect the appearance of all rows and cells within the parent table but can be overridden by individual table-level exception, row, and cell level properties, as defined by each property.
/// </summary>
public partial class PreviousTableProperties: ModelElement<DXW.PreviousTableProperties>
{
  public PreviousTableProperties(): base(){ }
  
  public PreviousTableProperties(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public PreviousTableProperties(DXW.PreviousTableProperties openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   TableStyle.
  /// </summary>
  [DataMember]
  public DMW.TableStyle? TableStyle
  {
    get
    {
      var element = _Element?.GetFirstChild<DXW.TableStyle>();
      if (element != null)
        return TableStyleConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.TableStyle>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = TableStyleConverter.CreateOpenXmlElement<DXW.TableStyle>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   TablePositionProperties.
  /// </summary>
  [DataMember]
  public DMW.TablePositionProperties? TablePositionProperties
  {
    get
    {
      var element = _Element?.GetFirstChild<DXW.TablePositionProperties>();
      if (element != null)
        return TablePositionPropertiesConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.TablePositionProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = TablePositionPropertiesConverter.CreateOpenXmlElement<DXW.TablePositionProperties>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   TableOverlap.
  /// </summary>
  [DataMember]
  public DMW.TableOverlapKind? TableOverlap
  {
    get
    {
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.TableOverlapValues, DMW.TableOverlapKind>(_ExistingElement.GetFirstChild<DXW.TableOverlap>()?.Val?.Value);
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.TableOverlap>();
      if (itemElement != null)
      {
        if (value != null)
          EnumValueConverter.UpdateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.TableOverlapValues, DMW.TableOverlapKind>(itemElement, (DMW.TableOverlapKind)value);
        else
          itemElement.Remove();
      }
      else
      if (value != null)
        _ExistingElement.AddChild(EnumValueConverter.CreateOpenXmlElement<DXW.TableOverlap, DocumentFormat.OpenXml.Wordprocessing.TableOverlapValues, DMW.TableOverlapKind>((DMW.TableOverlapKind)value));
    }
  }
  
  
  /// <summary>
  ///   BiDiVisual.
  /// </summary>
  [DataMember]
  public DMW.BiDiVisual? BiDiVisual
  {
    get
    {
      var element = _Element?.GetFirstChild<DXW.BiDiVisual>();
      if (element != null)
        return BiDiVisualConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.BiDiVisual>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = BiDiVisualConverter.CreateOpenXmlElement<DXW.BiDiVisual>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   TableWidth.
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
  ///   TableLayout.
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
  
  
  /// <summary>
  ///   TableLook.
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
  
  
  /// <summary>
  ///   TableCaption, this property is only available in Office 2010 and later..
  /// </summary>
  [DataMember]
  public DMW.TableCaption? TableCaption
  {
    get
    {
      var element = _Element?.GetFirstChild<DXW.TableCaption>();
      if (element != null)
        return TableCaptionConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.TableCaption>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = TableCaptionConverter.CreateOpenXmlElement<DXW.TableCaption>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   TableDescription, this property is only available in Office 2010 and later..
  /// </summary>
  [DataMember]
  public DMW.TableDescription? TableDescription
  {
    get
    {
      var element = _Element?.GetFirstChild<DXW.TableDescription>();
      if (element != null)
        return TableDescriptionConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.TableDescription>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = TableDescriptionConverter.CreateOpenXmlElement<DXW.TableDescription>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
