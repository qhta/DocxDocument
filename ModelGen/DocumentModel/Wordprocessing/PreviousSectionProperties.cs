namespace DocumentModel.Wordprocessing;


/// <summary>
///   When specified as a child element of sectPrChange, the sectPr element specifies a set of section properties that were modified when the document was set to track all revisions.
/// </summary>
public partial class PreviousSectionProperties: ModelElement<DXW.PreviousSectionProperties>
{
  public PreviousSectionProperties(): base(){ }
  
  public PreviousSectionProperties(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public PreviousSectionProperties(DXW.PreviousSectionProperties openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Physical Section Mark Character Revision ID
  /// </summary>
  [DataMember]
  public DM.HexBinary? RsidRPr
  {
    get
    {
      if (_Element?.RsidRPr?.Value != null)
        return HexIntConverter.GetValue(_ExistingElement.RsidRPr.Value);
      return null;
    }
    set
    {
      if (value != null)
        _ExistingElement.RsidRPr = value.ToString();
      else
        _ExistingElement.RsidRPr = null;
    }
  }
  
  
  /// <summary>
  ///   Section Deletion Revision ID
  /// </summary>
  [DataMember]
  public DM.HexBinary? RsidDel
  {
    get
    {
      if (_Element?.RsidDel?.Value != null)
        return HexIntConverter.GetValue(_ExistingElement.RsidDel.Value);
      return null;
    }
    set
    {
      if (value != null)
        _ExistingElement.RsidDel = value.ToString();
      else
        _ExistingElement.RsidDel = null;
    }
  }
  
  
  /// <summary>
  ///   Section Addition Revision ID
  /// </summary>
  [DataMember]
  public DM.HexBinary? RsidR
  {
    get
    {
      if (_Element?.RsidR?.Value != null)
        return HexIntConverter.GetValue(_ExistingElement.RsidR.Value);
      return null;
    }
    set
    {
      if (value != null)
        _ExistingElement.RsidR = value.ToString();
      else
        _ExistingElement.RsidR = null;
    }
  }
  
  
  /// <summary>
  ///   Section Properties Revision ID
  /// </summary>
  [DataMember]
  public DM.HexBinary? RsidSect
  {
    get
    {
      if (_Element?.RsidSect?.Value != null)
        return HexIntConverter.GetValue(_ExistingElement.RsidSect.Value);
      return null;
    }
    set
    {
      if (value != null)
        _ExistingElement.RsidSect = value.ToString();
      else
        _ExistingElement.RsidSect = null;
    }
  }
  
  
  /// <summary>
  ///   FootnoteProperties.
  /// </summary>
  [DataMember]
  public DMW.FootnoteProperties? FootnoteProperties
  {
    get
    {
      var element = _Element?.GetFirstChild<DXW.FootnoteProperties>();
      if (element != null)
        return FootnotePropertiesConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.FootnoteProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = FootnotePropertiesConverter.CreateOpenXmlElement<DXW.FootnoteProperties>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   EndnoteProperties.
  /// </summary>
  [DataMember]
  public DMW.EndnoteProperties? EndnoteProperties
  {
    get
    {
      var element = _Element?.GetFirstChild<DXW.EndnoteProperties>();
      if (element != null)
        return EndnotePropertiesConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.EndnoteProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EndnotePropertiesConverter.CreateOpenXmlElement<DXW.EndnoteProperties>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   SectionType.
  /// </summary>
  [DataMember]
  public DMW.SectionMarkKind? SectionType
  {
    get
    {
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.SectionMarkValues, DMW.SectionMarkKind>(_ExistingElement.GetFirstChild<DXW.SectionType>()?.Val?.Value);
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.SectionType>();
      if (itemElement != null)
      {
        if (value != null)
          EnumValueConverter.UpdateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.SectionMarkValues, DMW.SectionMarkKind>(itemElement, (DMW.SectionMarkKind)value);
        else
          itemElement.Remove();
      }
      else
      if (value != null)
        _ExistingElement.AddChild(EnumValueConverter.CreateOpenXmlElement<DXW.SectionType, DocumentFormat.OpenXml.Wordprocessing.SectionMarkValues, DMW.SectionMarkKind>((DMW.SectionMarkKind)value));
    }
  }
  
  
  /// <summary>
  ///   PageSize.
  /// </summary>
  [DataMember]
  public DMW.PageSize? PageSize
  {
    get
    {
      var element = _Element?.GetFirstChild<DXW.PageSize>();
      if (element != null)
        return PageSizeConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.PageSize>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = PageSizeConverter.CreateOpenXmlElement<DXW.PageSize>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   PageMargin.
  /// </summary>
  [DataMember]
  public DMW.PageMargin? PageMargin
  {
    get
    {
      var element = _Element?.GetFirstChild<DXW.PageMargin>();
      if (element != null)
        return PageMarginConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.PageMargin>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = PageMarginConverter.CreateOpenXmlElement<DXW.PageMargin>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   PaperSource.
  /// </summary>
  [DataMember]
  public DMW.PaperSource? PaperSource
  {
    get
    {
      var element = _Element?.GetFirstChild<DXW.PaperSource>();
      if (element != null)
        return PaperSourceConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.PaperSource>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = PaperSourceConverter.CreateOpenXmlElement<DXW.PaperSource>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   PageBorders.
  /// </summary>
  [DataMember]
  public DMW.PageBorders? PageBorders
  {
    get
    {
      var element = _Element?.GetFirstChild<DXW.PageBorders>();
      if (element != null)
        return PageBordersConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.PageBorders>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = PageBordersConverter.CreateOpenXmlElement<DXW.PageBorders>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   LineNumberType.
  /// </summary>
  [DataMember]
  public DMW.LineNumberType? LineNumberType
  {
    get
    {
      var element = _Element?.GetFirstChild<DXW.LineNumberType>();
      if (element != null)
        return LineNumberTypeConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.LineNumberType>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = LineNumberTypeConverter.CreateOpenXmlElement<DXW.LineNumberType>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   PageNumberType.
  /// </summary>
  [DataMember]
  public DMW.PageNumberType? PageNumberType
  {
    get
    {
      var element = _Element?.GetFirstChild<DXW.PageNumberType>();
      if (element != null)
        return PageNumberTypeConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.PageNumberType>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = PageNumberTypeConverter.CreateOpenXmlElement<DXW.PageNumberType>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   Columns.
  /// </summary>
  [DataMember]
  public DMW.Columns? Columns
  {
    get
    {
      var element = _Element?.GetFirstChild<DXW.Columns>();
      if (element != null)
        return ColumnsConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.Columns>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ColumnsConverter.CreateOpenXmlElement<DXW.Columns>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   FormProtection.
  /// </summary>
  [DataMember]
  public DMW.FormProtection? FormProtection
  {
    get
    {
      var element = _Element?.GetFirstChild<DXW.FormProtection>();
      if (element != null)
        return FormProtectionConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.FormProtection>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = FormProtectionConverter.CreateOpenXmlElement<DXW.FormProtection>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   VerticalTextAlignmentOnPage.
  /// </summary>
  [DataMember]
  public DMW.VerticalJustificationKind? VerticalTextAlignmentOnPage
  {
    get
    {
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.VerticalJustificationValues, DMW.VerticalJustificationKind>(_ExistingElement.GetFirstChild<DXW.VerticalTextAlignmentOnPage>()?.Val?.Value);
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.VerticalTextAlignmentOnPage>();
      if (itemElement != null)
      {
        if (value != null)
          EnumValueConverter.UpdateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.VerticalJustificationValues, DMW.VerticalJustificationKind>(itemElement, (DMW.VerticalJustificationKind)value);
        else
          itemElement.Remove();
      }
      else
      if (value != null)
        _ExistingElement.AddChild(EnumValueConverter.CreateOpenXmlElement<DXW.VerticalTextAlignmentOnPage, DocumentFormat.OpenXml.Wordprocessing.VerticalJustificationValues, DMW.VerticalJustificationKind>((DMW.VerticalJustificationKind)value));
    }
  }
  
  
  /// <summary>
  ///   NoEndnote.
  /// </summary>
  [DataMember]
  public DMW.NoEndnote? NoEndnote
  {
    get
    {
      var element = _Element?.GetFirstChild<DXW.NoEndnote>();
      if (element != null)
        return NoEndnoteConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.NoEndnote>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = NoEndnoteConverter.CreateOpenXmlElement<DXW.NoEndnote>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   TitlePage.
  /// </summary>
  [DataMember]
  public DMW.TitlePage? TitlePage
  {
    get
    {
      var element = _Element?.GetFirstChild<DXW.TitlePage>();
      if (element != null)
        return TitlePageConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.TitlePage>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = TitlePageConverter.CreateOpenXmlElement<DXW.TitlePage>(value);
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
  ///   BiDi.
  /// </summary>
  [DataMember]
  public DMW.BiDi? BiDi
  {
    get
    {
      var element = _Element?.GetFirstChild<DXW.BiDi>();
      if (element != null)
        return BiDiConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.BiDi>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = BiDiConverter.CreateOpenXmlElement<DXW.BiDi>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   GutterOnRight.
  /// </summary>
  [DataMember]
  public DMW.GutterOnRight? GutterOnRight
  {
    get
    {
      var element = _Element?.GetFirstChild<DXW.GutterOnRight>();
      if (element != null)
        return GutterOnRightConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.GutterOnRight>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = GutterOnRightConverter.CreateOpenXmlElement<DXW.GutterOnRight>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   DocGrid.
  /// </summary>
  [DataMember]
  public DMW.DocGrid? DocGrid
  {
    get
    {
      var element = _Element?.GetFirstChild<DXW.DocGrid>();
      if (element != null)
        return DocGridConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.DocGrid>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocGridConverter.CreateOpenXmlElement<DXW.DocGrid>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   PrinterSettingsReference.
  /// </summary>
  [DataMember]
  public DMW.PrinterSettingsReference? PrinterSettingsReference
  {
    get
    {
      var element = _Element?.GetFirstChild<DXW.PrinterSettingsReference>();
      if (element != null)
        return PrinterSettingsReferenceConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.PrinterSettingsReference>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = PrinterSettingsReferenceConverter.CreateOpenXmlElement<DXW.PrinterSettingsReference>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   FootnoteColumns, this property is only available in Office 2013 and later..
  /// </summary>
  [DataMember]
  public Int32? FootnoteColumns
  {
    get
    {
      return SimpleValueConverter.GetValue(_Element?.GetFirstChild<DXO13W.FootnoteColumns>()?.Val);
    }
    set
    {
      SimpleValueConverter.SetValue<DXO13W.FootnoteColumns,System.Int32>(openXmlElement, value);
    }
  }
  
}
