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
        return HexIntConverter.GetValue(_Element?.RsidRPr.Value);
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
        return HexIntConverter.GetValue(_Element?.RsidDel.Value);
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
        return HexIntConverter.GetValue(_Element?.RsidR.Value);
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
        return HexIntConverter.GetValue(_Element?.RsidSect.Value);
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
      return _Element?.GetObject<DMW.FootnoteProperties,DXW.FootnoteProperties>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.FootnoteProperties,DXW.FootnoteProperties>(value);
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
      return _Element?.GetObject<DMW.EndnoteProperties,DXW.EndnoteProperties>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.EndnoteProperties,DXW.EndnoteProperties>(value);
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
      return _Element?.GetObject<DMW.PageSize,DXW.PageSize>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.PageSize,DXW.PageSize>(value);
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
      return _Element?.GetObject<DMW.PageMargin,DXW.PageMargin>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.PageMargin,DXW.PageMargin>(value);
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
      return _Element?.GetObject<DMW.PaperSource,DXW.PaperSource>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.PaperSource,DXW.PaperSource>(value);
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
      return _Element?.GetObject<DMW.PageBorders,DXW.PageBorders>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.PageBorders,DXW.PageBorders>(value);
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
      return _Element?.GetObject<DMW.LineNumberType,DXW.LineNumberType>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.LineNumberType,DXW.LineNumberType>(value);
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
      return _Element?.GetObject<DMW.PageNumberType,DXW.PageNumberType>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.PageNumberType,DXW.PageNumberType>(value);
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
      return _Element?.GetObject<DMW.Columns,DXW.Columns>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.Columns,DXW.Columns>(value);
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
      return _Element?.GetObject<DMW.FormProtection,DXW.FormProtection>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.FormProtection,DXW.FormProtection>(value);
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
      return _Element?.GetObject<DMW.NoEndnote,DXW.NoEndnote>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.NoEndnote,DXW.NoEndnote>(value);
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
      return _Element?.GetObject<DMW.TitlePage,DXW.TitlePage>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.TitlePage,DXW.TitlePage>(value);
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
      return _Element?.GetObject<DMW.BiDi,DXW.BiDi>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.BiDi,DXW.BiDi>(value);
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
      return _Element?.GetObject<DMW.GutterOnRight,DXW.GutterOnRight>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.GutterOnRight,DXW.GutterOnRight>(value);
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
      return _Element?.GetObject<DMW.DocGrid,DXW.DocGrid>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.DocGrid,DXW.DocGrid>(value);
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
      return _Element?.GetObject<DMW.PrinterSettingsReference,DXW.PrinterSettingsReference>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.PrinterSettingsReference,DXW.PrinterSettingsReference>(value);
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
      SimpleValueConverter.SetValue<DXO13W.FootnoteColumns,System.Int32>(_ExistingElement, value);
    }
  }
  
}
