namespace DocumentModel;


/// <summary>
///   Document Settings.
/// </summary>
public partial class DocumentSettings: ModelElement<DXW.Settings>
{
  public DocumentSettings(): base(){ }
  
  public DocumentSettings(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public DocumentSettings(DXW.Settings openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Write Protection.
  /// </summary>
  [DataMember]
  public DMW.WriteProtection? WriteProtection
  {
    get
    {
      return _Element?.GetObject<DMW.WriteProtection,DXW.WriteProtection>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.WriteProtection,DXW.WriteProtection>(value);
    }
  }
  
  
  /// <summary>
  ///   Document View Setting.
  /// </summary>
  [DataMember]
  public DMW.ViewKind? View
  {
    get
    {
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.ViewValues, DMW.ViewKind>(_ExistingElement.GetFirstChild<DXW.View>()?.Val?.Value);
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.View>();
      if (itemElement != null)
      {
        if (value != null)
          EnumValueConverter.UpdateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.ViewValues, DMW.ViewKind>(itemElement, (DMW.ViewKind)value);
        else
          itemElement.Remove();
      }
      else
      if (value != null)
        _ExistingElement.AddChild(EnumValueConverter.CreateOpenXmlElement<DXW.View, DocumentFormat.OpenXml.Wordprocessing.ViewValues, DMW.ViewKind>((DMW.ViewKind)value));
    }
  }
  
  
  /// <summary>
  ///   Magnification Setting.
  /// </summary>
  [DataMember]
  public DMW.Zoom? Zoom
  {
    get
    {
      return _Element?.GetObject<DMW.Zoom,DXW.Zoom>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.Zoom,DXW.Zoom>(value);
    }
  }
  
  
  /// <summary>
  ///   Remove Personal Information from Document Properties.
  /// </summary>
  [DataMember]
  public DMW.RemovePersonalInformation? RemovePersonalInformation
  {
    get
    {
      return _Element?.GetObject<DMW.RemovePersonalInformation,DXW.RemovePersonalInformation>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.RemovePersonalInformation,DXW.RemovePersonalInformation>(value);
    }
  }
  
  
  /// <summary>
  ///   Remove Date and Time from Annotations.
  /// </summary>
  [DataMember]
  public DMW.RemoveDateAndTime? RemoveDateAndTime
  {
    get
    {
      return _Element?.GetObject<DMW.RemoveDateAndTime,DXW.RemoveDateAndTime>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.RemoveDateAndTime,DXW.RemoveDateAndTime>(value);
    }
  }
  
  
  /// <summary>
  ///   Do Not Display Visual Boundary For Header/Footer or Between Pages.
  /// </summary>
  [DataMember]
  public DMW.DoNotDisplayPageBoundaries? DoNotDisplayPageBoundaries
  {
    get
    {
      return _Element?.GetObject<DMW.DoNotDisplayPageBoundaries,DXW.DoNotDisplayPageBoundaries>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.DoNotDisplayPageBoundaries,DXW.DoNotDisplayPageBoundaries>(value);
    }
  }
  
  
  /// <summary>
  ///   Display Background Objects When Displaying Document.
  /// </summary>
  [DataMember]
  public DMW.DisplayBackgroundShape? DisplayBackgroundShape
  {
    get
    {
      return _Element?.GetObject<DMW.DisplayBackgroundShape,DXW.DisplayBackgroundShape>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.DisplayBackgroundShape,DXW.DisplayBackgroundShape>(value);
    }
  }
  
  
  /// <summary>
  ///   Print PostScript Codes With Document Text.
  /// </summary>
  [DataMember]
  public DMW.PrintPostScriptOverText? PrintPostScriptOverText
  {
    get
    {
      return _Element?.GetObject<DMW.PrintPostScriptOverText,DXW.PrintPostScriptOverText>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.PrintPostScriptOverText,DXW.PrintPostScriptOverText>(value);
    }
  }
  
  
  /// <summary>
  ///   Print Fractional Character Widths.
  /// </summary>
  [DataMember]
  public DMW.PrintFractionalCharacterWidth? PrintFractionalCharacterWidth
  {
    get
    {
      return _Element?.GetObject<DMW.PrintFractionalCharacterWidth,DXW.PrintFractionalCharacterWidth>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.PrintFractionalCharacterWidth,DXW.PrintFractionalCharacterWidth>(value);
    }
  }
  
  
  /// <summary>
  ///   Only Print Form Field Content.
  /// </summary>
  [DataMember]
  public DMW.PrintFormsData? PrintFormsData
  {
    get
    {
      return _Element?.GetObject<DMW.PrintFormsData,DXW.PrintFormsData>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.PrintFormsData,DXW.PrintFormsData>(value);
    }
  }
  
  
  /// <summary>
  ///   Embed TrueType Fonts.
  /// </summary>
  [DataMember]
  public DMW.EmbedTrueTypeFonts? EmbedTrueTypeFonts
  {
    get
    {
      return _Element?.GetObject<DMW.EmbedTrueTypeFonts,DXW.EmbedTrueTypeFonts>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.EmbedTrueTypeFonts,DXW.EmbedTrueTypeFonts>(value);
    }
  }
  
  
  /// <summary>
  ///   Embed Common System Fonts.
  /// </summary>
  [DataMember]
  public DMW.EmbedSystemFonts? EmbedSystemFonts
  {
    get
    {
      return _Element?.GetObject<DMW.EmbedSystemFonts,DXW.EmbedSystemFonts>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.EmbedSystemFonts,DXW.EmbedSystemFonts>(value);
    }
  }
  
  
  /// <summary>
  ///   Subset Fonts When Embedding.
  /// </summary>
  [DataMember]
  public DMW.SaveSubsetFonts? SaveSubsetFonts
  {
    get
    {
      return _Element?.GetObject<DMW.SaveSubsetFonts,DXW.SaveSubsetFonts>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.SaveSubsetFonts,DXW.SaveSubsetFonts>(value);
    }
  }
  
  
  /// <summary>
  ///   Only Save Form Field Content.
  /// </summary>
  [DataMember]
  public DMW.SaveFormsData? SaveFormsData
  {
    get
    {
      return _Element?.GetObject<DMW.SaveFormsData,DXW.SaveFormsData>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.SaveFormsData,DXW.SaveFormsData>(value);
    }
  }
  
  
  /// <summary>
  ///   Mirror Page Margins.
  /// </summary>
  [DataMember]
  public DMW.MirrorMargins? MirrorMargins
  {
    get
    {
      return _Element?.GetObject<DMW.MirrorMargins,DXW.MirrorMargins>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.MirrorMargins,DXW.MirrorMargins>(value);
    }
  }
  
  
  /// <summary>
  ///   Align Paragraph and Table Borders with Page Border.
  /// </summary>
  [DataMember]
  public DMW.AlignBorderAndEdges? AlignBorderAndEdges
  {
    get
    {
      return _Element?.GetObject<DMW.AlignBorderAndEdges,DXW.AlignBorderAndEdges>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.AlignBorderAndEdges,DXW.AlignBorderAndEdges>(value);
    }
  }
  
  
  /// <summary>
  ///   Page Border Excludes Header.
  /// </summary>
  [DataMember]
  public DMW.BordersDoNotSurroundHeader? BordersDoNotSurroundHeader
  {
    get
    {
      return _Element?.GetObject<DMW.BordersDoNotSurroundHeader,DXW.BordersDoNotSurroundHeader>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.BordersDoNotSurroundHeader,DXW.BordersDoNotSurroundHeader>(value);
    }
  }
  
  
  /// <summary>
  ///   Page Border Excludes Footer.
  /// </summary>
  [DataMember]
  public DMW.BordersDoNotSurroundFooter? BordersDoNotSurroundFooter
  {
    get
    {
      return _Element?.GetObject<DMW.BordersDoNotSurroundFooter,DXW.BordersDoNotSurroundFooter>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.BordersDoNotSurroundFooter,DXW.BordersDoNotSurroundFooter>(value);
    }
  }
  
  
  /// <summary>
  ///   Position Gutter At Top of Page.
  /// </summary>
  [DataMember]
  public DMW.GutterAtTop? GutterAtTop
  {
    get
    {
      return _Element?.GetObject<DMW.GutterAtTop,DXW.GutterAtTop>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.GutterAtTop,DXW.GutterAtTop>(value);
    }
  }
  
  
  /// <summary>
  ///   Do Not Display Visual Indication of Spelling Errors.
  /// </summary>
  [DataMember]
  public DMW.HideSpellingErrors? HideSpellingErrors
  {
    get
    {
      return _Element?.GetObject<DMW.HideSpellingErrors,DXW.HideSpellingErrors>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.HideSpellingErrors,DXW.HideSpellingErrors>(value);
    }
  }
  
  
  /// <summary>
  ///   Do Not Display Visual Indication of Grammatical Errors.
  /// </summary>
  [DataMember]
  public DMW.HideGrammaticalErrors? HideGrammaticalErrors
  {
    get
    {
      return _Element?.GetObject<DMW.HideGrammaticalErrors,DXW.HideGrammaticalErrors>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.HideGrammaticalErrors,DXW.HideGrammaticalErrors>(value);
    }
  }
  
  [DataMember]
  public DMW.ProofState? ProofState
  {
    get
    {
      return _Element?.GetObject<DMW.ProofState,DXW.ProofState>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.ProofState,DXW.ProofState>(value);
    }
  }
  
  [DataMember]
  public DMW.FormsDesign? FormsDesign
  {
    get
    {
      return _Element?.GetObject<DMW.FormsDesign,DXW.FormsDesign>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.FormsDesign,DXW.FormsDesign>(value);
    }
  }
  
  [DataMember]
  public DMW.AttachedTemplate? AttachedTemplate
  {
    get
    {
      return _Element?.GetObject<DMW.AttachedTemplate,DXW.AttachedTemplate>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.AttachedTemplate,DXW.AttachedTemplate>(value);
    }
  }
  
  [DataMember]
  public DMW.LinkStyles? LinkStyles
  {
    get
    {
      return _Element?.GetObject<DMW.LinkStyles,DXW.LinkStyles>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.LinkStyles,DXW.LinkStyles>(value);
    }
  }
  
  [DataMember]
  public DMW.StylePaneFormatFilter? StylePaneFormatFilter
  {
    get
    {
      return _Element?.GetObject<DMW.StylePaneFormatFilter,DXW.StylePaneFormatFilter>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.StylePaneFormatFilter,DXW.StylePaneFormatFilter>(value);
    }
  }
  
  [DataMember]
  public DMW.DocumentTypeKind? DocumentType
  {
    get
    {
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.DocumentTypeValues, DMW.DocumentTypeKind>(_ExistingElement.GetFirstChild<DXW.DocumentType>()?.Val?.Value);
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.DocumentType>();
      if (itemElement != null)
      {
        if (value != null)
          EnumValueConverter.UpdateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.DocumentTypeValues, DMW.DocumentTypeKind>(itemElement, (DMW.DocumentTypeKind)value);
        else
          itemElement.Remove();
      }
      else
      if (value != null)
        _ExistingElement.AddChild(EnumValueConverter.CreateOpenXmlElement<DXW.DocumentType, DocumentFormat.OpenXml.Wordprocessing.DocumentTypeValues, DMW.DocumentTypeKind>((DMW.DocumentTypeKind)value));
    }
  }
  
  [DataMember]
  public DMW.MailMerge? MailMerge
  {
    get
    {
      return _Element?.GetObject<DMW.MailMerge,DXW.MailMerge>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.MailMerge,DXW.MailMerge>(value);
    }
  }
  
  [DataMember]
  public DMW.RevisionView? RevisionView
  {
    get
    {
      return _Element?.GetObject<DMW.RevisionView,DXW.RevisionView>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.RevisionView,DXW.RevisionView>(value);
    }
  }
  
  [DataMember]
  public DMW.TrackRevisions? TrackRevisions
  {
    get
    {
      return _Element?.GetObject<DMW.TrackRevisions,DXW.TrackRevisions>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.TrackRevisions,DXW.TrackRevisions>(value);
    }
  }
  
  [DataMember]
  public DMW.DoNotTrackMoves? DoNotTrackMoves
  {
    get
    {
      return _Element?.GetObject<DMW.DoNotTrackMoves,DXW.DoNotTrackMoves>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.DoNotTrackMoves,DXW.DoNotTrackMoves>(value);
    }
  }
  
  [DataMember]
  public DMW.DoNotTrackFormatting? DoNotTrackFormatting
  {
    get
    {
      return _Element?.GetObject<DMW.DoNotTrackFormatting,DXW.DoNotTrackFormatting>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.DoNotTrackFormatting,DXW.DoNotTrackFormatting>(value);
    }
  }
  
  [DataMember]
  public DMW.DocumentProtection? DocumentProtection
  {
    get
    {
      return _Element?.GetObject<DMW.DocumentProtection,DXW.DocumentProtection>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.DocumentProtection,DXW.DocumentProtection>(value);
    }
  }
  
  [DataMember]
  public DMW.AutoFormatOverride? AutoFormatOverride
  {
    get
    {
      return _Element?.GetObject<DMW.AutoFormatOverride,DXW.AutoFormatOverride>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.AutoFormatOverride,DXW.AutoFormatOverride>(value);
    }
  }
  
  [DataMember]
  public DMW.DefaultTabStop? DefaultTabStop
  {
    get
    {
      return _Element?.GetObject<DMW.DefaultTabStop,DXW.DefaultTabStop>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.DefaultTabStop,DXW.DefaultTabStop>(value);
    }
  }
  
  [DataMember]
  public DMW.AutoHyphenation? AutoHyphenation
  {
    get
    {
      return _Element?.GetObject<DMW.AutoHyphenation,DXW.AutoHyphenation>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.AutoHyphenation,DXW.AutoHyphenation>(value);
    }
  }
  
  [DataMember]
  public UInt16? ConsecutiveHyphenLimit
  {
    get
    {
      return SimpleValueConverter.GetValue(_Element?.GetFirstChild<DXW.ConsecutiveHyphenLimit>()?.Val);
    }
    set
    {
      SimpleValueConverter.SetValue<DXW.ConsecutiveHyphenLimit,System.UInt16>(_ExistingElement, value);
    }
  }
  
  [DataMember]
  public DMW.HyphenationZone? HyphenationZone
  {
    get
    {
      return _Element?.GetObject<DMW.HyphenationZone,DXW.HyphenationZone>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.HyphenationZone,DXW.HyphenationZone>(value);
    }
  }
  
  [DataMember]
  public DMW.DoNotHyphenateCaps? DoNotHyphenateCaps
  {
    get
    {
      return _Element?.GetObject<DMW.DoNotHyphenateCaps,DXW.DoNotHyphenateCaps>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.DoNotHyphenateCaps,DXW.DoNotHyphenateCaps>(value);
    }
  }
  
  [DataMember]
  public DMW.ShowEnvelope? ShowEnvelope
  {
    get
    {
      return _Element?.GetObject<DMW.ShowEnvelope,DXW.ShowEnvelope>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.ShowEnvelope,DXW.ShowEnvelope>(value);
    }
  }
  
  [DataMember]
  public Int32? SummaryLength
  {
    get
    {
      return SimpleValueConverter.GetValue(_Element?.GetFirstChild<DXW.SummaryLength>()?.Val);
    }
    set
    {
      SimpleValueConverter.SetValue<DXW.SummaryLength,System.Int32>(_ExistingElement, value);
    }
  }
  
  [DataMember]
  public DMW.ClickAndTypeStyle? ClickAndTypeStyle
  {
    get
    {
      return _Element?.GetObject<DMW.ClickAndTypeStyle,DXW.ClickAndTypeStyle>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.ClickAndTypeStyle,DXW.ClickAndTypeStyle>(value);
    }
  }
  
  [DataMember]
  public DMW.DefaultTableStyle? DefaultTableStyle
  {
    get
    {
      return _Element?.GetObject<DMW.DefaultTableStyle,DXW.DefaultTableStyle>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.DefaultTableStyle,DXW.DefaultTableStyle>(value);
    }
  }
  
  [DataMember]
  public DMW.EvenAndOddHeaders? EvenAndOddHeaders
  {
    get
    {
      return _Element?.GetObject<DMW.EvenAndOddHeaders,DXW.EvenAndOddHeaders>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.EvenAndOddHeaders,DXW.EvenAndOddHeaders>(value);
    }
  }
  
  [DataMember]
  public DMW.BookFoldReversePrinting? BookFoldReversePrinting
  {
    get
    {
      return _Element?.GetObject<DMW.BookFoldReversePrinting,DXW.BookFoldReversePrinting>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.BookFoldReversePrinting,DXW.BookFoldReversePrinting>(value);
    }
  }
  
  [DataMember]
  public DMW.BookFoldPrinting? BookFoldPrinting
  {
    get
    {
      return _Element?.GetObject<DMW.BookFoldPrinting,DXW.BookFoldPrinting>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.BookFoldPrinting,DXW.BookFoldPrinting>(value);
    }
  }
  
  [DataMember]
  public DMW.BookFoldPrintingSheets? BookFoldPrintingSheets
  {
    get
    {
      return _Element?.GetObject<DMW.BookFoldPrintingSheets,DXW.BookFoldPrintingSheets>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.BookFoldPrintingSheets,DXW.BookFoldPrintingSheets>(value);
    }
  }
  
  [DataMember]
  public DMW.DrawingGridHorizontalSpacing? DrawingGridHorizontalSpacing
  {
    get
    {
      return _Element?.GetObject<DMW.DrawingGridHorizontalSpacing,DXW.DrawingGridHorizontalSpacing>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.DrawingGridHorizontalSpacing,DXW.DrawingGridHorizontalSpacing>(value);
    }
  }
  
  [DataMember]
  public DMW.DrawingGridVerticalSpacing? DrawingGridVerticalSpacing
  {
    get
    {
      return _Element?.GetObject<DMW.DrawingGridVerticalSpacing,DXW.DrawingGridVerticalSpacing>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.DrawingGridVerticalSpacing,DXW.DrawingGridVerticalSpacing>(value);
    }
  }
  
  [DataMember]
  public DMW.DisplayHorizontalDrawingGrid? DisplayHorizontalDrawingGrid
  {
    get
    {
      return _Element?.GetObject<DMW.DisplayHorizontalDrawingGrid,DXW.DisplayHorizontalDrawingGrid>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.DisplayHorizontalDrawingGrid,DXW.DisplayHorizontalDrawingGrid>(value);
    }
  }
  
  [DataMember]
  public DMW.DisplayVerticalDrawingGrid? DisplayVerticalDrawingGrid
  {
    get
    {
      return _Element?.GetObject<DMW.DisplayVerticalDrawingGrid,DXW.DisplayVerticalDrawingGrid>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.DisplayVerticalDrawingGrid,DXW.DisplayVerticalDrawingGrid>(value);
    }
  }
  
  [DataMember]
  public DMW.DoNotUseMarginsForDrawingGridOrigin? DoNotUseMarginsForDrawingGridOrigin
  {
    get
    {
      return _Element?.GetObject<DMW.DoNotUseMarginsForDrawingGridOrigin,DXW.DoNotUseMarginsForDrawingGridOrigin>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.DoNotUseMarginsForDrawingGridOrigin,DXW.DoNotUseMarginsForDrawingGridOrigin>(value);
    }
  }
  
  [DataMember]
  public DMW.DrawingGridHorizontalOrigin? DrawingGridHorizontalOrigin
  {
    get
    {
      return _Element?.GetObject<DMW.DrawingGridHorizontalOrigin,DXW.DrawingGridHorizontalOrigin>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.DrawingGridHorizontalOrigin,DXW.DrawingGridHorizontalOrigin>(value);
    }
  }
  
  [DataMember]
  public DMW.DrawingGridVerticalOrigin? DrawingGridVerticalOrigin
  {
    get
    {
      return _Element?.GetObject<DMW.DrawingGridVerticalOrigin,DXW.DrawingGridVerticalOrigin>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.DrawingGridVerticalOrigin,DXW.DrawingGridVerticalOrigin>(value);
    }
  }
  
  [DataMember]
  public DMW.DoNotShadeFormData? DoNotShadeFormData
  {
    get
    {
      return _Element?.GetObject<DMW.DoNotShadeFormData,DXW.DoNotShadeFormData>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.DoNotShadeFormData,DXW.DoNotShadeFormData>(value);
    }
  }
  
  [DataMember]
  public DMW.NoPunctuationKerning? NoPunctuationKerning
  {
    get
    {
      return _Element?.GetObject<DMW.NoPunctuationKerning,DXW.NoPunctuationKerning>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.NoPunctuationKerning,DXW.NoPunctuationKerning>(value);
    }
  }
  
  [DataMember]
  public DMW.CharacterSpacingKind? CharacterSpacingControl
  {
    get
    {
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.CharacterSpacingValues, DMW.CharacterSpacingKind>(_ExistingElement.GetFirstChild<DXW.CharacterSpacingControl>()?.Val?.Value);
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.CharacterSpacingControl>();
      if (itemElement != null)
      {
        if (value != null)
          EnumValueConverter.UpdateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.CharacterSpacingValues, DMW.CharacterSpacingKind>(itemElement, (DMW.CharacterSpacingKind)value);
        else
          itemElement.Remove();
      }
      else
      if (value != null)
        _ExistingElement.AddChild(EnumValueConverter.CreateOpenXmlElement<DXW.CharacterSpacingControl, DocumentFormat.OpenXml.Wordprocessing.CharacterSpacingValues, DMW.CharacterSpacingKind>((DMW.CharacterSpacingKind)value));
    }
  }
  
  [DataMember]
  public DMW.PrintTwoOnOne? PrintTwoOnOne
  {
    get
    {
      return _Element?.GetObject<DMW.PrintTwoOnOne,DXW.PrintTwoOnOne>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.PrintTwoOnOne,DXW.PrintTwoOnOne>(value);
    }
  }
  
  [DataMember]
  public DMW.StrictFirstAndLastChars? StrictFirstAndLastChars
  {
    get
    {
      return _Element?.GetObject<DMW.StrictFirstAndLastChars,DXW.StrictFirstAndLastChars>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.StrictFirstAndLastChars,DXW.StrictFirstAndLastChars>(value);
    }
  }
  
  [DataMember]
  public DMW.NoLineBreaksAfterKinsoku? NoLineBreaksAfterKinsoku
  {
    get
    {
      return _Element?.GetObject<DMW.NoLineBreaksAfterKinsoku,DXW.NoLineBreaksAfterKinsoku>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.NoLineBreaksAfterKinsoku,DXW.NoLineBreaksAfterKinsoku>(value);
    }
  }
  
  [DataMember]
  public DMW.NoLineBreaksBeforeKinsoku? NoLineBreaksBeforeKinsoku
  {
    get
    {
      return _Element?.GetObject<DMW.NoLineBreaksBeforeKinsoku,DXW.NoLineBreaksBeforeKinsoku>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.NoLineBreaksBeforeKinsoku,DXW.NoLineBreaksBeforeKinsoku>(value);
    }
  }
  
  [DataMember]
  public DMW.SavePreviewPicture? SavePreviewPicture
  {
    get
    {
      return _Element?.GetObject<DMW.SavePreviewPicture,DXW.SavePreviewPicture>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.SavePreviewPicture,DXW.SavePreviewPicture>(value);
    }
  }
  
  [DataMember]
  public DMW.DoNotValidateAgainstSchema? DoNotValidateAgainstSchema
  {
    get
    {
      return _Element?.GetObject<DMW.DoNotValidateAgainstSchema,DXW.DoNotValidateAgainstSchema>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.DoNotValidateAgainstSchema,DXW.DoNotValidateAgainstSchema>(value);
    }
  }
  
  [DataMember]
  public DMW.SaveInvalidXml? SaveInvalidXml
  {
    get
    {
      return _Element?.GetObject<DMW.SaveInvalidXml,DXW.SaveInvalidXml>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.SaveInvalidXml,DXW.SaveInvalidXml>(value);
    }
  }
  
  [DataMember]
  public DMW.IgnoreMixedContent? IgnoreMixedContent
  {
    get
    {
      return _Element?.GetObject<DMW.IgnoreMixedContent,DXW.IgnoreMixedContent>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.IgnoreMixedContent,DXW.IgnoreMixedContent>(value);
    }
  }
  
  [DataMember]
  public DMW.AlwaysShowPlaceholderText? AlwaysShowPlaceholderText
  {
    get
    {
      return _Element?.GetObject<DMW.AlwaysShowPlaceholderText,DXW.AlwaysShowPlaceholderText>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.AlwaysShowPlaceholderText,DXW.AlwaysShowPlaceholderText>(value);
    }
  }
  
  [DataMember]
  public DMW.DoNotDemarcateInvalidXml? DoNotDemarcateInvalidXml
  {
    get
    {
      return _Element?.GetObject<DMW.DoNotDemarcateInvalidXml,DXW.DoNotDemarcateInvalidXml>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.DoNotDemarcateInvalidXml,DXW.DoNotDemarcateInvalidXml>(value);
    }
  }
  
  [DataMember]
  public DMW.SaveXmlDataOnly? SaveXmlDataOnly
  {
    get
    {
      return _Element?.GetObject<DMW.SaveXmlDataOnly,DXW.SaveXmlDataOnly>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.SaveXmlDataOnly,DXW.SaveXmlDataOnly>(value);
    }
  }
  
  [DataMember]
  public DMW.UseXsltWhenSaving? UseXsltWhenSaving
  {
    get
    {
      return _Element?.GetObject<DMW.UseXsltWhenSaving,DXW.UseXsltWhenSaving>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.UseXsltWhenSaving,DXW.UseXsltWhenSaving>(value);
    }
  }
  
  [DataMember]
  public DMW.SaveThroughXslt? SaveThroughXslt
  {
    get
    {
      return _Element?.GetObject<DMW.SaveThroughXslt,DXW.SaveThroughXslt>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.SaveThroughXslt,DXW.SaveThroughXslt>(value);
    }
  }
  
  [DataMember]
  public DMW.ShowXmlTags? ShowXmlTags
  {
    get
    {
      return _Element?.GetObject<DMW.ShowXmlTags,DXW.ShowXmlTags>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.ShowXmlTags,DXW.ShowXmlTags>(value);
    }
  }
  
  [DataMember]
  public DMW.AlwaysMergeEmptyNamespace? AlwaysMergeEmptyNamespace
  {
    get
    {
      return _Element?.GetObject<DMW.AlwaysMergeEmptyNamespace,DXW.AlwaysMergeEmptyNamespace>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.AlwaysMergeEmptyNamespace,DXW.AlwaysMergeEmptyNamespace>(value);
    }
  }
  
  [DataMember]
  public DMW.UpdateFieldsOnOpen? UpdateFieldsOnOpen
  {
    get
    {
      return _Element?.GetObject<DMW.UpdateFieldsOnOpen,DXW.UpdateFieldsOnOpen>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.UpdateFieldsOnOpen,DXW.UpdateFieldsOnOpen>(value);
    }
  }
  
  [DataMember]
  public DMW.HeaderShapeDefaults? HeaderShapeDefaults
  {
    get
    {
      return _Element?.GetObject<DMW.HeaderShapeDefaults,DXW.HeaderShapeDefaults>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.HeaderShapeDefaults,DXW.HeaderShapeDefaults>(value);
    }
  }
  
  [DataMember]
  public DMW.FootnoteDocumentWideProperties? FootnoteDocumentWideProperties
  {
    get
    {
      return _Element?.GetObject<DMW.FootnoteDocumentWideProperties,DXW.FootnoteDocumentWideProperties>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.FootnoteDocumentWideProperties,DXW.FootnoteDocumentWideProperties>(value);
    }
  }
  
  [DataMember]
  public DMW.EndnoteDocumentWideProperties? EndnoteDocumentWideProperties
  {
    get
    {
      return _Element?.GetObject<DMW.EndnoteDocumentWideProperties,DXW.EndnoteDocumentWideProperties>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.EndnoteDocumentWideProperties,DXW.EndnoteDocumentWideProperties>(value);
    }
  }
  
  [DataMember]
  public DMW.Compatibility? Compatibility
  {
    get
    {
      return _Element?.GetObject<DMW.Compatibility,DXW.Compatibility>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.Compatibility,DXW.Compatibility>(value);
    }
  }
  
  [DataMember]
  public DMW.DocumentVariables? DocumentVariables
  {
    get
    {
      return _Element?.GetObject<DMW.DocumentVariables,DXW.DocumentVariables>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.DocumentVariables,DXW.DocumentVariables>(value);
    }
  }
  
  [DataMember]
  public DMW.Rsids? Rsids
  {
    get
    {
      return _Element?.GetObject<DMW.Rsids,DXW.Rsids>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.Rsids,DXW.Rsids>(value);
    }
  }
  
  [DataMember]
  public DMM.MathProperties? MathProperties
  {
    get
    {
      return _Element?.GetObject<DMM.MathProperties,DXM.MathProperties>();
    }
    set
    {
      _ExistingElement.SetObject<DMM.MathProperties,DXM.MathProperties>(value);
    }
  }
  
  [DataMember]
  public DMW.UICompatibleWith97To2003? UICompatibleWith97To2003
  {
    get
    {
      return _Element?.GetObject<DMW.UICompatibleWith97To2003,DXW.UICompatibleWith97To2003>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.UICompatibleWith97To2003,DXW.UICompatibleWith97To2003>(value);
    }
  }
  
  [DataMember]
  public DMW.ThemeFontLanguages? ThemeFontLanguages
  {
    get
    {
      return _Element?.GetObject<DMW.ThemeFontLanguages,DXW.ThemeFontLanguages>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.ThemeFontLanguages,DXW.ThemeFontLanguages>(value);
    }
  }
  
  [DataMember]
  public DMW.ColorSchemeMapping? ColorSchemeMapping
  {
    get
    {
      return _Element?.GetObject<DMW.ColorSchemeMapping,DXW.ColorSchemeMapping>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.ColorSchemeMapping,DXW.ColorSchemeMapping>(value);
    }
  }
  
  [DataMember]
  public DMW.DoNotIncludeSubdocsInStats? DoNotIncludeSubdocsInStats
  {
    get
    {
      return _Element?.GetObject<DMW.DoNotIncludeSubdocsInStats,DXW.DoNotIncludeSubdocsInStats>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.DoNotIncludeSubdocsInStats,DXW.DoNotIncludeSubdocsInStats>(value);
    }
  }
  
  [DataMember]
  public DMW.DoNotAutoCompressPictures? DoNotAutoCompressPictures
  {
    get
    {
      return _Element?.GetObject<DMW.DoNotAutoCompressPictures,DXW.DoNotAutoCompressPictures>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.DoNotAutoCompressPictures,DXW.DoNotAutoCompressPictures>(value);
    }
  }
  
  [DataMember]
  public DMW.ForceUpgrade? ForceUpgrade
  {
    get
    {
      return _Element?.GetObject<DMW.ForceUpgrade,DXW.ForceUpgrade>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.ForceUpgrade,DXW.ForceUpgrade>(value);
    }
  }
  
  [DataMember]
  public DMW.Captions? Captions
  {
    get
    {
      return _Element?.GetObject<DMW.Captions,DXW.Captions>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.Captions,DXW.Captions>(value);
    }
  }
  
  [DataMember]
  public DMW.ReadModeInkLockDown? ReadModeInkLockDown
  {
    get
    {
      return _Element?.GetObject<DMW.ReadModeInkLockDown,DXW.ReadModeInkLockDown>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.ReadModeInkLockDown,DXW.ReadModeInkLockDown>(value);
    }
  }
  
  [DataMember]
  public DMCX.SchemaLibrary? SchemaLibrary
  {
    get
    {
      return _Element?.GetObject<DMCX.SchemaLibrary,DXCXSR.SchemaLibrary>();
    }
    set
    {
      _ExistingElement.SetObject<DMCX.SchemaLibrary,DXCXSR.SchemaLibrary>(value);
    }
  }
  
  [DataMember]
  public DMW.ShapeDefaults? ShapeDefaults
  {
    get
    {
      return _Element?.GetObject<DMW.ShapeDefaults,DXW.ShapeDefaults>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.ShapeDefaults,DXW.ShapeDefaults>(value);
    }
  }
  
  [DataMember]
  public DMW.DecimalSymbol? DecimalSymbol
  {
    get
    {
      return _Element?.GetObject<DMW.DecimalSymbol,DXW.DecimalSymbol>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.DecimalSymbol,DXW.DecimalSymbol>(value);
    }
  }
  
  [DataMember]
  public DMW.ListSeparator? ListSeparator
  {
    get
    {
      return _Element?.GetObject<DMW.ListSeparator,DXW.ListSeparator>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.ListSeparator,DXW.ListSeparator>(value);
    }
  }
  
  [DataMember]
  public DM.HexBinary? DocumentId
  {
    get
    {
      return _Element?.GetObject<DM.HexBinary,DXO10W.DocumentId>();
    }
    set
    {
      _ExistingElement.SetObject<DM.HexBinary,DXO10W.DocumentId>(value);
    }
  }
  
  [DataMember]
  public DMW10.DiscardImageEditingData? DiscardImageEditingData
  {
    get
    {
      return _Element?.GetObject<DMW10.DiscardImageEditingData,DXO10W.DiscardImageEditingData>();
    }
    set
    {
      _ExistingElement.SetObject<DMW10.DiscardImageEditingData,DXO10W.DiscardImageEditingData>(value);
    }
  }
  
  [DataMember]
  public Int32? DefaultImageDpi
  {
    get
    {
      return SimpleValueConverter.GetValue(_Element?.GetFirstChild<DXO10W.DefaultImageDpi>()?.Val);
    }
    set
    {
      SimpleValueConverter.SetValue<DXO10W.DefaultImageDpi,System.Int32>(_ExistingElement, value);
    }
  }
  
  [DataMember]
  public DMW10.ConflictMode? ConflictMode
  {
    get
    {
      return _Element?.GetObject<DMW10.ConflictMode,DXO10W.ConflictMode>();
    }
    set
    {
      _ExistingElement.SetObject<DMW10.ConflictMode,DXO10W.ConflictMode>(value);
    }
  }
  
  [DataMember]
  public DMW13.ChartTrackingRefBased? ChartTrackingRefBased
  {
    get
    {
      return _Element?.GetObject<DMW13.ChartTrackingRefBased,DXO13W.ChartTrackingRefBased>();
    }
    set
    {
      _ExistingElement.SetObject<DMW13.ChartTrackingRefBased,DXO13W.ChartTrackingRefBased>(value);
    }
  }
  
  [DataMember]
  public String? PersistentDocumentId
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.GetFirstChild<DXO13W.PersistentDocumentId>()?.Val);
    }
    set
    {
      StringValueConverter.SetValue<DXO13W.PersistentDocumentId>(_ExistingElement, value);
    }
  }
  
}
