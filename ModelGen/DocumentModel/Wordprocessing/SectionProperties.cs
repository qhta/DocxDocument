namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element defines the section properties for the section of the document.
/// </summary>
public partial class SectionProperties: ModelElement<DXW.SectionProperties>
{
  public SectionProperties(): base(){ }
  
  public SectionProperties(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public SectionProperties(DXW.SectionProperties openXmlElement): base(openXmlElement) { }
  
  
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
  
  [DataMember]
  public DMW.SectionPropertiesChange? SectionPropertiesChange
  {
    get
    {
      var element = _Element?.GetFirstChild<DXW.SectionPropertiesChange>();
      if (element != null)
        return SectionPropertiesChangeConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.SectionPropertiesChange>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = SectionPropertiesChangeConverter.CreateOpenXmlElement<DXW.SectionPropertiesChange>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
