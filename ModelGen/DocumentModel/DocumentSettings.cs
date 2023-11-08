namespace DocumentModel;


/// <summary>
///   Document Settings.
/// </summary>
public partial class DocumentSettings: ModelElement<DXW.DocumentSettings>
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
      var element = _Element?.GetFirstChild<DXW.WriteProtection>();
      if (element != null)
        return WriteProtectionConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.WriteProtection>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = WriteProtectionConverter.CreateOpenXmlElement<DXW.WriteProtection>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXW.Zoom>();
      if (element != null)
        return ZoomConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.Zoom>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ZoomConverter.CreateOpenXmlElement<DXW.Zoom>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXW.RemovePersonalInformation>();
      if (element != null)
        return RemovePersonalInformationConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.RemovePersonalInformation>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = RemovePersonalInformationConverter.CreateOpenXmlElement<DXW.RemovePersonalInformation>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXW.RemoveDateAndTime>();
      if (element != null)
        return RemoveDateAndTimeConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.RemoveDateAndTime>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = RemoveDateAndTimeConverter.CreateOpenXmlElement<DXW.RemoveDateAndTime>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXW.DoNotDisplayPageBoundaries>();
      if (element != null)
        return DoNotDisplayPageBoundariesConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.DoNotDisplayPageBoundaries>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DoNotDisplayPageBoundariesConverter.CreateOpenXmlElement<DXW.DoNotDisplayPageBoundaries>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXW.DisplayBackgroundShape>();
      if (element != null)
        return DisplayBackgroundShapeConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.DisplayBackgroundShape>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DisplayBackgroundShapeConverter.CreateOpenXmlElement<DXW.DisplayBackgroundShape>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXW.PrintPostScriptOverText>();
      if (element != null)
        return PrintPostScriptOverTextConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.PrintPostScriptOverText>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = PrintPostScriptOverTextConverter.CreateOpenXmlElement<DXW.PrintPostScriptOverText>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXW.PrintFractionalCharacterWidth>();
      if (element != null)
        return PrintFractionalCharacterWidthConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.PrintFractionalCharacterWidth>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = PrintFractionalCharacterWidthConverter.CreateOpenXmlElement<DXW.PrintFractionalCharacterWidth>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXW.PrintFormsData>();
      if (element != null)
        return PrintFormsDataConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.PrintFormsData>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = PrintFormsDataConverter.CreateOpenXmlElement<DXW.PrintFormsData>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXW.EmbedTrueTypeFonts>();
      if (element != null)
        return EmbedTrueTypeFontsConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.EmbedTrueTypeFonts>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EmbedTrueTypeFontsConverter.CreateOpenXmlElement<DXW.EmbedTrueTypeFonts>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXW.EmbedSystemFonts>();
      if (element != null)
        return EmbedSystemFontsConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.EmbedSystemFonts>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EmbedSystemFontsConverter.CreateOpenXmlElement<DXW.EmbedSystemFonts>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXW.SaveSubsetFonts>();
      if (element != null)
        return SaveSubsetFontsConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.SaveSubsetFonts>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = SaveSubsetFontsConverter.CreateOpenXmlElement<DXW.SaveSubsetFonts>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXW.SaveFormsData>();
      if (element != null)
        return SaveFormsDataConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.SaveFormsData>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = SaveFormsDataConverter.CreateOpenXmlElement<DXW.SaveFormsData>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXW.MirrorMargins>();
      if (element != null)
        return MirrorMarginsConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.MirrorMargins>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = MirrorMarginsConverter.CreateOpenXmlElement<DXW.MirrorMargins>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXW.AlignBorderAndEdges>();
      if (element != null)
        return AlignBorderAndEdgesConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.AlignBorderAndEdges>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = AlignBorderAndEdgesConverter.CreateOpenXmlElement<DXW.AlignBorderAndEdges>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXW.BordersDoNotSurroundHeader>();
      if (element != null)
        return BordersDoNotSurroundHeaderConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.BordersDoNotSurroundHeader>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = BordersDoNotSurroundHeaderConverter.CreateOpenXmlElement<DXW.BordersDoNotSurroundHeader>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXW.BordersDoNotSurroundFooter>();
      if (element != null)
        return BordersDoNotSurroundFooterConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.BordersDoNotSurroundFooter>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = BordersDoNotSurroundFooterConverter.CreateOpenXmlElement<DXW.BordersDoNotSurroundFooter>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXW.GutterAtTop>();
      if (element != null)
        return GutterAtTopConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.GutterAtTop>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = GutterAtTopConverter.CreateOpenXmlElement<DXW.GutterAtTop>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXW.HideSpellingErrors>();
      if (element != null)
        return HideSpellingErrorsConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.HideSpellingErrors>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = HideSpellingErrorsConverter.CreateOpenXmlElement<DXW.HideSpellingErrors>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXW.HideGrammaticalErrors>();
      if (element != null)
        return HideGrammaticalErrorsConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.HideGrammaticalErrors>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = HideGrammaticalErrorsConverter.CreateOpenXmlElement<DXW.HideGrammaticalErrors>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMW.ProofState? ProofState
  {
    get
    {
      var element = _Element?.GetFirstChild<DXW.ProofState>();
      if (element != null)
        return ProofStateConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.ProofState>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ProofStateConverter.CreateOpenXmlElement<DXW.ProofState>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMW.FormsDesign? FormsDesign
  {
    get
    {
      var element = _Element?.GetFirstChild<DXW.FormsDesign>();
      if (element != null)
        return FormsDesignConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.FormsDesign>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = FormsDesignConverter.CreateOpenXmlElement<DXW.FormsDesign>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMW.AttachedTemplate? AttachedTemplate
  {
    get
    {
      var element = _Element?.GetFirstChild<DXW.AttachedTemplate>();
      if (element != null)
        return AttachedTemplateConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.AttachedTemplate>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = AttachedTemplateConverter.CreateOpenXmlElement<DXW.AttachedTemplate>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMW.LinkStyles? LinkStyles
  {
    get
    {
      var element = _Element?.GetFirstChild<DXW.LinkStyles>();
      if (element != null)
        return LinkStylesConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.LinkStyles>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = LinkStylesConverter.CreateOpenXmlElement<DXW.LinkStyles>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMW.StylePaneFormatFilter? StylePaneFormatFilter
  {
    get
    {
      var element = _Element?.GetFirstChild<DXW.StylePaneFormatFilter>();
      if (element != null)
        return StylePaneFormatFilterConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.StylePaneFormatFilter>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = StylePaneFormatFilterConverter.CreateOpenXmlElement<DXW.StylePaneFormatFilter>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXW.MailMerge>();
      if (element != null)
        return MailMergeConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.MailMerge>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = MailMergeConverter.CreateOpenXmlElement<DXW.MailMerge>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMW.RevisionView? RevisionView
  {
    get
    {
      var element = _Element?.GetFirstChild<DXW.RevisionView>();
      if (element != null)
        return RevisionViewConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.RevisionView>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = RevisionViewConverter.CreateOpenXmlElement<DXW.RevisionView>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMW.TrackRevisions? TrackRevisions
  {
    get
    {
      var element = _Element?.GetFirstChild<DXW.TrackRevisions>();
      if (element != null)
        return TrackRevisionsConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.TrackRevisions>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = TrackRevisionsConverter.CreateOpenXmlElement<DXW.TrackRevisions>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMW.DoNotTrackMoves? DoNotTrackMoves
  {
    get
    {
      var element = _Element?.GetFirstChild<DXW.DoNotTrackMoves>();
      if (element != null)
        return DoNotTrackMovesConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.DoNotTrackMoves>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DoNotTrackMovesConverter.CreateOpenXmlElement<DXW.DoNotTrackMoves>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMW.DoNotTrackFormatting? DoNotTrackFormatting
  {
    get
    {
      var element = _Element?.GetFirstChild<DXW.DoNotTrackFormatting>();
      if (element != null)
        return DoNotTrackFormattingConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.DoNotTrackFormatting>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DoNotTrackFormattingConverter.CreateOpenXmlElement<DXW.DoNotTrackFormatting>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMW.DocumentProtection? DocumentProtection
  {
    get
    {
      var element = _Element?.GetFirstChild<DXW.DocumentProtection>();
      if (element != null)
        return DocumentProtectionConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.DocumentProtection>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentProtectionConverter.CreateOpenXmlElement<DXW.DocumentProtection>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMW.AutoFormatOverride? AutoFormatOverride
  {
    get
    {
      var element = _Element?.GetFirstChild<DXW.AutoFormatOverride>();
      if (element != null)
        return AutoFormatOverrideConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.AutoFormatOverride>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = AutoFormatOverrideConverter.CreateOpenXmlElement<DXW.AutoFormatOverride>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMW.DefaultTabStop? DefaultTabStop
  {
    get
    {
      var element = _Element?.GetFirstChild<DXW.DefaultTabStop>();
      if (element != null)
        return DefaultTabStopConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.DefaultTabStop>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DefaultTabStopConverter.CreateOpenXmlElement<DXW.DefaultTabStop>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMW.AutoHyphenation? AutoHyphenation
  {
    get
    {
      var element = _Element?.GetFirstChild<DXW.AutoHyphenation>();
      if (element != null)
        return AutoHyphenationConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.AutoHyphenation>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = AutoHyphenationConverter.CreateOpenXmlElement<DXW.AutoHyphenation>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      SimpleValueConverter.SetValue<DXW.ConsecutiveHyphenLimit,System.UInt16>(openXmlElement, value);
    }
  }
  
  [DataMember]
  public DMW.HyphenationZone? HyphenationZone
  {
    get
    {
      var element = _Element?.GetFirstChild<DXW.HyphenationZone>();
      if (element != null)
        return HyphenationZoneConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.HyphenationZone>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = HyphenationZoneConverter.CreateOpenXmlElement<DXW.HyphenationZone>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMW.DoNotHyphenateCaps? DoNotHyphenateCaps
  {
    get
    {
      var element = _Element?.GetFirstChild<DXW.DoNotHyphenateCaps>();
      if (element != null)
        return DoNotHyphenateCapsConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.DoNotHyphenateCaps>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DoNotHyphenateCapsConverter.CreateOpenXmlElement<DXW.DoNotHyphenateCaps>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMW.ShowEnvelope? ShowEnvelope
  {
    get
    {
      var element = _Element?.GetFirstChild<DXW.ShowEnvelope>();
      if (element != null)
        return ShowEnvelopeConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.ShowEnvelope>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ShowEnvelopeConverter.CreateOpenXmlElement<DXW.ShowEnvelope>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      SimpleValueConverter.SetValue<DXW.SummaryLength,System.Int32>(openXmlElement, value);
    }
  }
  
  [DataMember]
  public DMW.ClickAndTypeStyle? ClickAndTypeStyle
  {
    get
    {
      var element = _Element?.GetFirstChild<DXW.ClickAndTypeStyle>();
      if (element != null)
        return ClickAndTypeStyleConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.ClickAndTypeStyle>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ClickAndTypeStyleConverter.CreateOpenXmlElement<DXW.ClickAndTypeStyle>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMW.DefaultTableStyle? DefaultTableStyle
  {
    get
    {
      var element = _Element?.GetFirstChild<DXW.DefaultTableStyle>();
      if (element != null)
        return DefaultTableStyleConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.DefaultTableStyle>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DefaultTableStyleConverter.CreateOpenXmlElement<DXW.DefaultTableStyle>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMW.EvenAndOddHeaders? EvenAndOddHeaders
  {
    get
    {
      var element = _Element?.GetFirstChild<DXW.EvenAndOddHeaders>();
      if (element != null)
        return EvenAndOddHeadersConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.EvenAndOddHeaders>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EvenAndOddHeadersConverter.CreateOpenXmlElement<DXW.EvenAndOddHeaders>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMW.BookFoldReversePrinting? BookFoldReversePrinting
  {
    get
    {
      var element = _Element?.GetFirstChild<DXW.BookFoldReversePrinting>();
      if (element != null)
        return BookFoldReversePrintingConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.BookFoldReversePrinting>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = BookFoldReversePrintingConverter.CreateOpenXmlElement<DXW.BookFoldReversePrinting>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMW.BookFoldPrinting? BookFoldPrinting
  {
    get
    {
      var element = _Element?.GetFirstChild<DXW.BookFoldPrinting>();
      if (element != null)
        return BookFoldPrintingConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.BookFoldPrinting>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = BookFoldPrintingConverter.CreateOpenXmlElement<DXW.BookFoldPrinting>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMW.BookFoldPrintingSheets? BookFoldPrintingSheets
  {
    get
    {
      var element = _Element?.GetFirstChild<DXW.BookFoldPrintingSheets>();
      if (element != null)
        return BookFoldPrintingSheetsConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.BookFoldPrintingSheets>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = BookFoldPrintingSheetsConverter.CreateOpenXmlElement<DXW.BookFoldPrintingSheets>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMW.DrawingGridHorizontalSpacing? DrawingGridHorizontalSpacing
  {
    get
    {
      var element = _Element?.GetFirstChild<DXW.DrawingGridHorizontalSpacing>();
      if (element != null)
        return DrawingGridHorizontalSpacingConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.DrawingGridHorizontalSpacing>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DrawingGridHorizontalSpacingConverter.CreateOpenXmlElement<DXW.DrawingGridHorizontalSpacing>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMW.DrawingGridVerticalSpacing? DrawingGridVerticalSpacing
  {
    get
    {
      var element = _Element?.GetFirstChild<DXW.DrawingGridVerticalSpacing>();
      if (element != null)
        return DrawingGridVerticalSpacingConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.DrawingGridVerticalSpacing>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DrawingGridVerticalSpacingConverter.CreateOpenXmlElement<DXW.DrawingGridVerticalSpacing>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMW.DisplayHorizontalDrawingGrid? DisplayHorizontalDrawingGrid
  {
    get
    {
      var element = _Element?.GetFirstChild<DXW.DisplayHorizontalDrawingGrid>();
      if (element != null)
        return DisplayHorizontalDrawingGridConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.DisplayHorizontalDrawingGrid>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DisplayHorizontalDrawingGridConverter.CreateOpenXmlElement<DXW.DisplayHorizontalDrawingGrid>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMW.DisplayVerticalDrawingGrid? DisplayVerticalDrawingGrid
  {
    get
    {
      var element = _Element?.GetFirstChild<DXW.DisplayVerticalDrawingGrid>();
      if (element != null)
        return DisplayVerticalDrawingGridConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.DisplayVerticalDrawingGrid>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DisplayVerticalDrawingGridConverter.CreateOpenXmlElement<DXW.DisplayVerticalDrawingGrid>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMW.DoNotUseMarginsForDrawingGridOrigin? DoNotUseMarginsForDrawingGridOrigin
  {
    get
    {
      var element = _Element?.GetFirstChild<DXW.DoNotUseMarginsForDrawingGridOrigin>();
      if (element != null)
        return DoNotUseMarginsForDrawingGridOriginConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.DoNotUseMarginsForDrawingGridOrigin>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DoNotUseMarginsForDrawingGridOriginConverter.CreateOpenXmlElement<DXW.DoNotUseMarginsForDrawingGridOrigin>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMW.DrawingGridHorizontalOrigin? DrawingGridHorizontalOrigin
  {
    get
    {
      var element = _Element?.GetFirstChild<DXW.DrawingGridHorizontalOrigin>();
      if (element != null)
        return DrawingGridHorizontalOriginConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.DrawingGridHorizontalOrigin>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DrawingGridHorizontalOriginConverter.CreateOpenXmlElement<DXW.DrawingGridHorizontalOrigin>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMW.DrawingGridVerticalOrigin? DrawingGridVerticalOrigin
  {
    get
    {
      var element = _Element?.GetFirstChild<DXW.DrawingGridVerticalOrigin>();
      if (element != null)
        return DrawingGridVerticalOriginConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.DrawingGridVerticalOrigin>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DrawingGridVerticalOriginConverter.CreateOpenXmlElement<DXW.DrawingGridVerticalOrigin>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMW.DoNotShadeFormData? DoNotShadeFormData
  {
    get
    {
      var element = _Element?.GetFirstChild<DXW.DoNotShadeFormData>();
      if (element != null)
        return DoNotShadeFormDataConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.DoNotShadeFormData>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DoNotShadeFormDataConverter.CreateOpenXmlElement<DXW.DoNotShadeFormData>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMW.NoPunctuationKerning? NoPunctuationKerning
  {
    get
    {
      var element = _Element?.GetFirstChild<DXW.NoPunctuationKerning>();
      if (element != null)
        return NoPunctuationKerningConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.NoPunctuationKerning>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = NoPunctuationKerningConverter.CreateOpenXmlElement<DXW.NoPunctuationKerning>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXW.PrintTwoOnOne>();
      if (element != null)
        return PrintTwoOnOneConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.PrintTwoOnOne>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = PrintTwoOnOneConverter.CreateOpenXmlElement<DXW.PrintTwoOnOne>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMW.StrictFirstAndLastChars? StrictFirstAndLastChars
  {
    get
    {
      var element = _Element?.GetFirstChild<DXW.StrictFirstAndLastChars>();
      if (element != null)
        return StrictFirstAndLastCharsConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.StrictFirstAndLastChars>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = StrictFirstAndLastCharsConverter.CreateOpenXmlElement<DXW.StrictFirstAndLastChars>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMW.NoLineBreaksAfterKinsoku? NoLineBreaksAfterKinsoku
  {
    get
    {
      var element = _Element?.GetFirstChild<DXW.NoLineBreaksAfterKinsoku>();
      if (element != null)
        return NoLineBreaksAfterKinsokuConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.NoLineBreaksAfterKinsoku>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = NoLineBreaksAfterKinsokuConverter.CreateOpenXmlElement<DXW.NoLineBreaksAfterKinsoku>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMW.NoLineBreaksBeforeKinsoku? NoLineBreaksBeforeKinsoku
  {
    get
    {
      var element = _Element?.GetFirstChild<DXW.NoLineBreaksBeforeKinsoku>();
      if (element != null)
        return NoLineBreaksBeforeKinsokuConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.NoLineBreaksBeforeKinsoku>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = NoLineBreaksBeforeKinsokuConverter.CreateOpenXmlElement<DXW.NoLineBreaksBeforeKinsoku>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMW.SavePreviewPicture? SavePreviewPicture
  {
    get
    {
      var element = _Element?.GetFirstChild<DXW.SavePreviewPicture>();
      if (element != null)
        return SavePreviewPictureConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.SavePreviewPicture>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = SavePreviewPictureConverter.CreateOpenXmlElement<DXW.SavePreviewPicture>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMW.DoNotValidateAgainstSchema? DoNotValidateAgainstSchema
  {
    get
    {
      var element = _Element?.GetFirstChild<DXW.DoNotValidateAgainstSchema>();
      if (element != null)
        return DoNotValidateAgainstSchemaConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.DoNotValidateAgainstSchema>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DoNotValidateAgainstSchemaConverter.CreateOpenXmlElement<DXW.DoNotValidateAgainstSchema>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMW.SaveInvalidXml? SaveInvalidXml
  {
    get
    {
      var element = _Element?.GetFirstChild<DXW.SaveInvalidXml>();
      if (element != null)
        return SaveInvalidXmlConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.SaveInvalidXml>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = SaveInvalidXmlConverter.CreateOpenXmlElement<DXW.SaveInvalidXml>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMW.IgnoreMixedContent? IgnoreMixedContent
  {
    get
    {
      var element = _Element?.GetFirstChild<DXW.IgnoreMixedContent>();
      if (element != null)
        return IgnoreMixedContentConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.IgnoreMixedContent>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = IgnoreMixedContentConverter.CreateOpenXmlElement<DXW.IgnoreMixedContent>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMW.AlwaysShowPlaceholderText? AlwaysShowPlaceholderText
  {
    get
    {
      var element = _Element?.GetFirstChild<DXW.AlwaysShowPlaceholderText>();
      if (element != null)
        return AlwaysShowPlaceholderTextConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.AlwaysShowPlaceholderText>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = AlwaysShowPlaceholderTextConverter.CreateOpenXmlElement<DXW.AlwaysShowPlaceholderText>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMW.DoNotDemarcateInvalidXml? DoNotDemarcateInvalidXml
  {
    get
    {
      var element = _Element?.GetFirstChild<DXW.DoNotDemarcateInvalidXml>();
      if (element != null)
        return DoNotDemarcateInvalidXmlConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.DoNotDemarcateInvalidXml>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DoNotDemarcateInvalidXmlConverter.CreateOpenXmlElement<DXW.DoNotDemarcateInvalidXml>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMW.SaveXmlDataOnly? SaveXmlDataOnly
  {
    get
    {
      var element = _Element?.GetFirstChild<DXW.SaveXmlDataOnly>();
      if (element != null)
        return SaveXmlDataOnlyConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.SaveXmlDataOnly>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = SaveXmlDataOnlyConverter.CreateOpenXmlElement<DXW.SaveXmlDataOnly>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMW.UseXsltWhenSaving? UseXsltWhenSaving
  {
    get
    {
      var element = _Element?.GetFirstChild<DXW.UseXsltWhenSaving>();
      if (element != null)
        return UseXsltWhenSavingConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.UseXsltWhenSaving>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = UseXsltWhenSavingConverter.CreateOpenXmlElement<DXW.UseXsltWhenSaving>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMW.SaveThroughXslt? SaveThroughXslt
  {
    get
    {
      var element = _Element?.GetFirstChild<DXW.SaveThroughXslt>();
      if (element != null)
        return SaveThroughXsltConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.SaveThroughXslt>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = SaveThroughXsltConverter.CreateOpenXmlElement<DXW.SaveThroughXslt>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMW.ShowXmlTags? ShowXmlTags
  {
    get
    {
      var element = _Element?.GetFirstChild<DXW.ShowXmlTags>();
      if (element != null)
        return ShowXmlTagsConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.ShowXmlTags>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ShowXmlTagsConverter.CreateOpenXmlElement<DXW.ShowXmlTags>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMW.AlwaysMergeEmptyNamespace? AlwaysMergeEmptyNamespace
  {
    get
    {
      var element = _Element?.GetFirstChild<DXW.AlwaysMergeEmptyNamespace>();
      if (element != null)
        return AlwaysMergeEmptyNamespaceConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.AlwaysMergeEmptyNamespace>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = AlwaysMergeEmptyNamespaceConverter.CreateOpenXmlElement<DXW.AlwaysMergeEmptyNamespace>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMW.UpdateFieldsOnOpen? UpdateFieldsOnOpen
  {
    get
    {
      var element = _Element?.GetFirstChild<DXW.UpdateFieldsOnOpen>();
      if (element != null)
        return UpdateFieldsOnOpenConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.UpdateFieldsOnOpen>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = UpdateFieldsOnOpenConverter.CreateOpenXmlElement<DXW.UpdateFieldsOnOpen>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMW.HeaderShapeDefaults? HeaderShapeDefaults
  {
    get
    {
      var element = _Element?.GetFirstChild<DXW.HeaderShapeDefaults>();
      if (element != null)
        return HeaderShapeDefaultsConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.HeaderShapeDefaults>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = HeaderShapeDefaultsConverter.CreateOpenXmlElement<DXW.HeaderShapeDefaults>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMW.FootnoteDocumentWideProperties? FootnoteDocumentWideProperties
  {
    get
    {
      var element = _Element?.GetFirstChild<DXW.FootnoteDocumentWideProperties>();
      if (element != null)
        return FootnoteDocumentWidePropertiesConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.FootnoteDocumentWideProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = FootnoteDocumentWidePropertiesConverter.CreateOpenXmlElement<DXW.FootnoteDocumentWideProperties>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMW.EndnoteDocumentWideProperties? EndnoteDocumentWideProperties
  {
    get
    {
      var element = _Element?.GetFirstChild<DXW.EndnoteDocumentWideProperties>();
      if (element != null)
        return EndnoteDocumentWidePropertiesConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.EndnoteDocumentWideProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EndnoteDocumentWidePropertiesConverter.CreateOpenXmlElement<DXW.EndnoteDocumentWideProperties>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMW.Compatibility? Compatibility
  {
    get
    {
      var element = _Element?.GetFirstChild<DXW.Compatibility>();
      if (element != null)
        return CompatibilityConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.Compatibility>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = CompatibilityConverter.CreateOpenXmlElement<DXW.Compatibility>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMW.DocumentVariables? DocumentVariables
  {
    get
    {
      var element = _Element?.GetFirstChild<DXW.DocumentVariables>();
      if (element != null)
        return DocumentVariablesConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.DocumentVariables>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentVariablesConverter.CreateOpenXmlElement<DXW.DocumentVariables>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMW.Rsids? Rsids
  {
    get
    {
      var element = _Element?.GetFirstChild<DXW.Rsids>();
      if (element != null)
        return RsidsConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.Rsids>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = RsidsConverter.CreateOpenXmlElement<DXW.Rsids>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMM.MathProperties? MathProperties
  {
    get
    {
      var element = _Element?.GetFirstChild<DXM.MathProperties>();
      if (element != null)
        return MathPropertiesConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXM.MathProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = MathPropertiesConverter.CreateOpenXmlElement<DXM.MathProperties>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMW.UICompatibleWith97To2003? UICompatibleWith97To2003
  {
    get
    {
      var element = _Element?.GetFirstChild<DXW.UICompatibleWith97To2003>();
      if (element != null)
        return UICompatibleWith97To2003Converter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.UICompatibleWith97To2003>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = UICompatibleWith97To2003Converter.CreateOpenXmlElement<DXW.UICompatibleWith97To2003>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMW.ThemeFontLanguages? ThemeFontLanguages
  {
    get
    {
      var element = _Element?.GetFirstChild<DXW.ThemeFontLanguages>();
      if (element != null)
        return ThemeFontLanguagesConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.ThemeFontLanguages>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ThemeFontLanguagesConverter.CreateOpenXmlElement<DXW.ThemeFontLanguages>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMW.ColorSchemeMapping? ColorSchemeMapping
  {
    get
    {
      var element = _Element?.GetFirstChild<DXW.ColorSchemeMapping>();
      if (element != null)
        return ColorSchemeMappingConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.ColorSchemeMapping>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ColorSchemeMappingConverter.CreateOpenXmlElement<DXW.ColorSchemeMapping>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMW.DoNotIncludeSubdocsInStats? DoNotIncludeSubdocsInStats
  {
    get
    {
      var element = _Element?.GetFirstChild<DXW.DoNotIncludeSubdocsInStats>();
      if (element != null)
        return DoNotIncludeSubdocsInStatsConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.DoNotIncludeSubdocsInStats>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DoNotIncludeSubdocsInStatsConverter.CreateOpenXmlElement<DXW.DoNotIncludeSubdocsInStats>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMW.DoNotAutoCompressPictures? DoNotAutoCompressPictures
  {
    get
    {
      var element = _Element?.GetFirstChild<DXW.DoNotAutoCompressPictures>();
      if (element != null)
        return DoNotAutoCompressPicturesConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.DoNotAutoCompressPictures>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DoNotAutoCompressPicturesConverter.CreateOpenXmlElement<DXW.DoNotAutoCompressPictures>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMW.ForceUpgrade? ForceUpgrade
  {
    get
    {
      var element = _Element?.GetFirstChild<DXW.ForceUpgrade>();
      if (element != null)
        return ForceUpgradeConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.ForceUpgrade>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ForceUpgradeConverter.CreateOpenXmlElement<DXW.ForceUpgrade>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMW.Captions? Captions
  {
    get
    {
      var element = _Element?.GetFirstChild<DXW.Captions>();
      if (element != null)
        return CaptionsConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.Captions>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = CaptionsConverter.CreateOpenXmlElement<DXW.Captions>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMW.ReadModeInkLockDown? ReadModeInkLockDown
  {
    get
    {
      var element = _Element?.GetFirstChild<DXW.ReadModeInkLockDown>();
      if (element != null)
        return ReadModeInkLockDownConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.ReadModeInkLockDown>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ReadModeInkLockDownConverter.CreateOpenXmlElement<DXW.ReadModeInkLockDown>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMCX.SchemaLibrary? SchemaLibrary
  {
    get
    {
      var element = _Element?.GetFirstChild<DXCXSR.SchemaLibrary>();
      if (element != null)
        return SchemaLibraryConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXCXSR.SchemaLibrary>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = SchemaLibraryConverter.CreateOpenXmlElement<DXCXSR.SchemaLibrary>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMW.ShapeDefaults? ShapeDefaults
  {
    get
    {
      var element = _Element?.GetFirstChild<DXW.ShapeDefaults>();
      if (element != null)
        return ShapeDefaultsConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.ShapeDefaults>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ShapeDefaultsConverter.CreateOpenXmlElement<DXW.ShapeDefaults>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMW.DecimalSymbol? DecimalSymbol
  {
    get
    {
      var element = _Element?.GetFirstChild<DXW.DecimalSymbol>();
      if (element != null)
        return DecimalSymbolConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.DecimalSymbol>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DecimalSymbolConverter.CreateOpenXmlElement<DXW.DecimalSymbol>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMW.ListSeparator? ListSeparator
  {
    get
    {
      var element = _Element?.GetFirstChild<DXW.ListSeparator>();
      if (element != null)
        return ListSeparatorConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.ListSeparator>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ListSeparatorConverter.CreateOpenXmlElement<DXW.ListSeparator>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DM.HexBinary? DocumentId
  {
    get
    {
      var element = _Element?.GetFirstChild<DXO10W.DocumentId>();
      if (element != null)
        return DMX.HexBinaryConverter.GetValue(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO10W.DocumentId>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = HexBinaryConverter.CreateOpenXmlElement<DXO10W.DocumentId>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMW10.DiscardImageEditingData? DiscardImageEditingData
  {
    get
    {
      var element = _Element?.GetFirstChild<DXO10W.DiscardImageEditingData>();
      if (element != null)
        return DiscardImageEditingDataConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO10W.DiscardImageEditingData>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DiscardImageEditingDataConverter.CreateOpenXmlElement<DXO10W.DiscardImageEditingData>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      SimpleValueConverter.SetValue<DXO10W.DefaultImageDpi,System.Int32>(openXmlElement, value);
    }
  }
  
  [DataMember]
  public DMW10.ConflictMode? ConflictMode
  {
    get
    {
      var element = _Element?.GetFirstChild<DXO10W.ConflictMode>();
      if (element != null)
        return ConflictModeConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO10W.ConflictMode>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ConflictModeConverter.CreateOpenXmlElement<DXO10W.ConflictMode>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMW13.ChartTrackingRefBased? ChartTrackingRefBased
  {
    get
    {
      var element = _Element?.GetFirstChild<DXO13W.ChartTrackingRefBased>();
      if (element != null)
        return ChartTrackingRefBasedConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO13W.ChartTrackingRefBased>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ChartTrackingRefBasedConverter.CreateOpenXmlElement<DXO13W.ChartTrackingRefBased>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      StringValueConverter.SetValue<DXO13W.PersistentDocumentId>(openXmlElement, value);
    }
  }
  
}
