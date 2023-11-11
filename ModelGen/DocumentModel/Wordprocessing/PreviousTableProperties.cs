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
      return _Element?.GetObject<DMW.TableStyle,DXW.TableStyle>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.TableStyle,DXW.TableStyle>(value);
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
      return _Element?.GetObject<DMW.TablePositionProperties,DXW.TablePositionProperties>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.TablePositionProperties,DXW.TablePositionProperties>(value);
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
      return _Element?.GetObject<DMW.BiDiVisual,DXW.BiDiVisual>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.BiDiVisual,DXW.BiDiVisual>(value);
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
      return _Element?.GetObject<DMW.TableWidth,DXW.TableWidth>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.TableWidth,DXW.TableWidth>(value);
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
      return _Element?.GetObject<DMW.TableCellSpacing,DXW.TableCellSpacing>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.TableCellSpacing,DXW.TableCellSpacing>(value);
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
      return _Element?.GetObject<DMW.TableIndentation,DXW.TableIndentation>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.TableIndentation,DXW.TableIndentation>(value);
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
      return _Element?.GetObject<DMW.TableBorders,DXW.TableBorders>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.TableBorders,DXW.TableBorders>(value);
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
  ///   TableLayout.
  /// </summary>
  [DataMember]
  public DMW.TableLayout? TableLayout
  {
    get
    {
      return _Element?.GetObject<DMW.TableLayout,DXW.TableLayout>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.TableLayout,DXW.TableLayout>(value);
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
      return _Element?.GetObject<DMW.TableCellMarginDefault,DXW.TableCellMarginDefault>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.TableCellMarginDefault,DXW.TableCellMarginDefault>(value);
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
      return _Element?.GetObject<DMW.TableLook,DXW.TableLook>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.TableLook,DXW.TableLook>(value);
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
      return _Element?.GetObject<DMW.TableCaption,DXW.TableCaption>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.TableCaption,DXW.TableCaption>(value);
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
      return _Element?.GetObject<DMW.TableDescription,DXW.TableDescription>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.TableDescription,DXW.TableDescription>(value);
    }
  }
  
}
