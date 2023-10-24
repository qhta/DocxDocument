namespace DocumentModel.Wordprocessing;
public partial class DocxDocument
{

  //#region DocumentSettings
  public bool HasDocumentSettings => WordprocessingDocument.MainDocumentPart?.DocumentSettingsPart?.Settings != null;

  private  DXW.Settings? _DocumentSettings =>
      WordprocessingDocument.MainDocumentPart?.DocumentSettingsPart?.Settings;

  private  DXW.Settings DocumentSettings
  {
    get
    {
      var mainDocumentPart = WordprocessingDocument.MainDocumentPart;
      if (mainDocumentPart == null)
      {
        mainDocumentPart = WordprocessingDocument.AddMainDocumentPart();
      }
      var settingsPart = mainDocumentPart.DocumentSettingsPart;
      if (settingsPart == null)
      {
        settingsPart = mainDocumentPart.AddNewPart<DXP.DocumentSettingsPart>();
      }
      var settings = settingsPart.Settings;
      if (settings == null)
      {
        settings = new  DXW.Settings();
        settingsPart.Settings = settings;
      }
      return settings;
    }
  }

  public DXW.WriteProtection? WriteProtection
  {
    get => _DocumentSettings?.WriteProtection;
    set => DocumentSettings.WriteProtection = value;
  }

  public DXW.ViewValues? View
  {
    get => _DocumentSettings?.View?.Val?.Value;
    set
    {
      if (value!=null)
       DocumentSettings.View = new DXW.View{ Val = value };
      else
       DocumentSettings.View = null;
    }
  }

  public object? Zoom
  {
    get 
    { 
      var zoom = _DocumentSettings?.Zoom;
      if (zoom != null)
      {
        if (zoom.Val!=null)
          return zoom.Val.Value;
        else
        {
          var str = zoom.Percent?.Value;
          if (str!=null)
          {
            str = str.ReplaceEnd("%","");
            if (int.TryParse(str, out var val))
              return val;
          }
        }
      }
      return null;
    }
    set
    {
      if (value != null)
      {
        if (value is DXW.PresetZoomValues preset)
          DocumentSettings.Zoom = new DXW.Zoom { Val = preset };
        else if (value is int n)
          DocumentSettings.Zoom = new DXW.Zoom { Percent = n.ToString()+"%" };
        else
          throw new InvalidCastException("Zoom can be of Integer or PresetZoomValues type");
      }
      else
        DocumentSettings.Zoom = null;
    }
  }

  public Boolean? RemovePersonalInformation
  {
    get => _DocumentSettings?.RemovePersonalInformation?.Val?.AsBoolean();
    set
    {
      if (value!=null)
       DocumentSettings.RemovePersonalInformation = new DXW.RemovePersonalInformation { Val = value };
      else
       DocumentSettings.RemovePersonalInformation = null;
    }
  }

  public Boolean? RemoveDateAndTime
  {
    get => _DocumentSettings?.RemoveDateAndTime?.Val?.AsBoolean();
    set
    {
      if (value!=null)
       DocumentSettings.RemoveDateAndTime = new DXW.RemoveDateAndTime{ Val = value };
      else
       DocumentSettings.RemoveDateAndTime = null;
    }
  }

  public Boolean? DoNotDisplayPageBoundaries
  {
    get => _DocumentSettings?.DoNotDisplayPageBoundaries?.Val?.AsBoolean();
    set
    {
      if (value!=null)
       DocumentSettings.DoNotDisplayPageBoundaries = new DXW.DoNotDisplayPageBoundaries{ Val = value };
      else
       DocumentSettings.DoNotDisplayPageBoundaries = null;
    }
  }

  public Boolean? DisplayBackgroundShape
  {
    get => _DocumentSettings?.DisplayBackgroundShape?.Val?.AsBoolean();
    set
    {
      if (value!=null)
       DocumentSettings.DisplayBackgroundShape = new DXW.DisplayBackgroundShape{ Val = value };
      else
       DocumentSettings.DisplayBackgroundShape = null;
    }
  }

  public Boolean? PrintPostScriptOverText
  {
    get => _DocumentSettings?.PrintPostScriptOverText?.Val?.AsBoolean();
    set
    {
      if (value!=null)
       DocumentSettings.PrintPostScriptOverText = new DXW.PrintPostScriptOverText{ Val = value };
      else
       DocumentSettings.PrintPostScriptOverText = null;
    }
  }

  public Boolean? PrintFractionalCharacterWidth
  {
    get => _DocumentSettings?.PrintFractionalCharacterWidth?.Val?.AsBoolean();
    set
    {
      if (value!=null)
       DocumentSettings.PrintFractionalCharacterWidth = new DXW.PrintFractionalCharacterWidth{ Val = value };
      else
       DocumentSettings.PrintFractionalCharacterWidth = null;
    }
  }

  public Boolean? PrintFormsData
  {
    get => _DocumentSettings?.PrintFormsData?.Val?.AsBoolean();
    set
    {
      if (value!=null)
       DocumentSettings.PrintFormsData = new DXW.PrintFormsData{ Val = value };
      else
       DocumentSettings.PrintFormsData = null;
    }
  }

  public Boolean? EmbedTrueTypeFonts
  {
    get => _DocumentSettings?.EmbedTrueTypeFonts?.Val?.AsBoolean();
    set
    {
      if (value!=null)
       DocumentSettings.EmbedTrueTypeFonts = new DXW.EmbedTrueTypeFonts{ Val = value };
      else
       DocumentSettings.EmbedTrueTypeFonts = null;
    }
  }

  public Boolean? EmbedSystemFonts
  {
    get => _DocumentSettings?.EmbedSystemFonts?.Val?.AsBoolean();
    set
    {
      if (value!=null)
       DocumentSettings.EmbedSystemFonts = new DXW.EmbedSystemFonts{ Val = value };
      else
       DocumentSettings.EmbedSystemFonts = null;
    }
  }

  public Boolean? SaveSubsetFonts
  {
    get => _DocumentSettings?.SaveSubsetFonts?.Val?.AsBoolean();
    set
    {
      if (value!=null)
       DocumentSettings.SaveSubsetFonts = new DXW.SaveSubsetFonts{ Val = value };
      else
       DocumentSettings.SaveSubsetFonts = null;
    }
  }

  public Boolean? SaveFormsData
  {
    get => _DocumentSettings?.SaveFormsData?.Val?.AsBoolean();
    set
    {
      if (value!=null)
       DocumentSettings.SaveFormsData = new DXW.SaveFormsData{ Val = value };
      else
       DocumentSettings.SaveFormsData = null;
    }
  }

  public Boolean? MirrorMargins
  {
    get => _DocumentSettings?.MirrorMargins?.Val?.AsBoolean();
    set
    {
      if (value!=null)
       DocumentSettings.MirrorMargins = new DXW.MirrorMargins{ Val = value };
      else
       DocumentSettings.MirrorMargins = null;
    }
  }

  public Boolean? AlignBorderAndEdges
  {
    get => _DocumentSettings?.AlignBorderAndEdges?.Val?.AsBoolean();
    set
    {
      if (value!=null)
       DocumentSettings.AlignBorderAndEdges = new DXW.AlignBorderAndEdges{ Val = value };
      else
       DocumentSettings.AlignBorderAndEdges = null;
    }
  }

  public Boolean? BordersDoNotSurroundHeader
  {
    get => _DocumentSettings?.BordersDoNotSurroundHeader?.Val?.AsBoolean();
    set
    {
      if (value!=null)
       DocumentSettings.BordersDoNotSurroundHeader = new DXW.BordersDoNotSurroundHeader{ Val = value };
      else
       DocumentSettings.BordersDoNotSurroundHeader = null;
    }
  }

  public Boolean? BordersDoNotSurroundFooter
  {
    get => _DocumentSettings?.BordersDoNotSurroundFooter?.Val?.AsBoolean();
    set
    {
      if (value!=null)
       DocumentSettings.BordersDoNotSurroundFooter = new DXW.BordersDoNotSurroundFooter{ Val = value };
      else
       DocumentSettings.BordersDoNotSurroundFooter = null;
    }
  }

  public Boolean? GutterAtTop
  {
    get => _DocumentSettings?.GutterAtTop?.Val?.AsBoolean();
    set
    {
      if (value!=null)
       DocumentSettings.GutterAtTop = new DXW.GutterAtTop{ Val = value };
      else
       DocumentSettings.GutterAtTop = null;
    }
  }

  public Boolean? HideSpellingErrors
  {
    get => _DocumentSettings?.HideSpellingErrors?.Val?.AsBoolean();
    set
    {
      if (value!=null)
       DocumentSettings.HideSpellingErrors = new DXW.HideSpellingErrors{ Val = value };
      else
       DocumentSettings.HideSpellingErrors = null;
    }
  }

  public Boolean? HideGrammaticalErrors
  {
    get => _DocumentSettings?.HideGrammaticalErrors?.Val?.AsBoolean();
    set
    {
      if (value!=null)
       DocumentSettings.HideGrammaticalErrors = new DXW.HideGrammaticalErrors{ Val = value };
      else
       DocumentSettings.HideGrammaticalErrors = null;
    }
  }

    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.MathProperties" /> <c>&lt;m:mathPr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.CustomXmlSchemaReferences.SchemaLibrary" /> <c>&lt;sl:schemaLibrary></c></description></item>
    ///   <item><description><see cref=" DXW.Captions" /> <c>&lt;w:captions></c></description></item>
    ///   <item><description><see cref=" DXW.CharacterSpacingControl" /> <c>&lt;w:characterSpacingControl></c></description></item>
    ///   <item><description><see cref=" DXW.ColorSchemeMapping" /> <c>&lt;w:clrSchemeMapping></c></description></item>
    ///   <item><description><see cref=" DXW.Compatibility" /> <c>&lt;w:compat></c></description></item>
    ///   <item><description><see cref=" DXW.DocumentProtection" /> <c>&lt;w:documentProtection></c></description></item>
    ///   <item><description><see cref=" DXW.Rsids" /> <c>&lt;w:rsids></c></description></item>
    ///   <item><description><see cref=" DXW.DocumentType" /> <c>&lt;w:documentType></c></description></item>
    ///   <item><description><see cref=" DXW.DocumentVariables" /> <c>&lt;w:docVars></c></description></item>
    ///   <item><description><see cref=" DXW.EndnoteDocumentWideProperties" /> <c>&lt;w:endnotePr></c></description></item>
    ///   <item><description><see cref=" DXW.ForceUpgrade" /> <c>&lt;w:forceUpgrade></c></description></item>
    ///   <item><description><see cref=" DXW.FootnoteDocumentWideProperties" /> <c>&lt;w:footnotePr></c></description></item>
    ///   <item><description><see cref=" DXW.NoLineBreaksAfterKinsoku" /> <c>&lt;w:noLineBreaksAfter></c></description></item>
    ///   <item><description><see cref=" DXW.NoLineBreaksBeforeKinsoku" /> <c>&lt;w:noLineBreaksBefore></c></description></item>
    ///   <item><description><see cref=" DXW.ThemeFontLanguages" /> <c>&lt;w:themeFontLang></c></description></item>
    ///   <item><description><see cref=" DXW.MailMerge" /> <c>&lt;w:mailMerge></c></description></item>
    ///   <item><description><see cref=" DXW.DefaultTabStop" /> <c>&lt;w:defaultTabStop></c></description></item>
    ///   <item><description><see cref=" DXW.BookFoldPrintingSheets" /> <c>&lt;w:bookFoldPrintingSheets></c></description></item>
    ///   <item><description><see cref=" DXW.RemovePersonalInformation" /> <c>&lt;w:removePersonalInformation></c></description></item>
    ///   <item><description><see cref=" DXW.RemoveDateAndTime" /> <c>&lt;w:removeDateAndTime></c></description></item>
    ///   <item><description><see cref=" DXW.DoNotDisplayPageBoundaries" /> <c>&lt;w:doNotDisplayPageBoundaries></c></description></item>
    ///   <item><description><see cref=" DXW.DisplayBackgroundShape" /> <c>&lt;w:displayBackgroundShape></c></description></item>
    ///   <item><description><see cref=" DXW.PrintPostScriptOverText" /> <c>&lt;w:printPostScriptOverText></c></description></item>
    ///   <item><description><see cref=" DXW.PrintFractionalCharacterWidth" /> <c>&lt;w:printFractionalCharacterWidth></c></description></item>
    ///   <item><description><see cref=" DXW.PrintFormsData" /> <c>&lt;w:printFormsData></c></description></item>
    ///   <item><description><see cref=" DXW.EmbedTrueTypeFonts" /> <c>&lt;w:embedTrueTypeFonts></c></description></item>
    ///   <item><description><see cref=" DXW.EmbedSystemFonts" /> <c>&lt;w:embedSystemFonts></c></description></item>
    ///   <item><description><see cref=" DXW.SaveSubsetFonts" /> <c>&lt;w:saveSubsetFonts></c></description></item>
    ///   <item><description><see cref=" DXW.SaveFormsData" /> <c>&lt;w:saveFormsData></c></description></item>
    ///   <item><description><see cref=" DXW.MirrorMargins" /> <c>&lt;w:mirrorMargins></c></description></item>
    ///   <item><description><see cref=" DXW.AlignBorderAndEdges" /> <c>&lt;w:alignBordersAndEdges></c></description></item>
    ///   <item><description><see cref=" DXW.BordersDoNotSurroundHeader" /> <c>&lt;w:bordersDoNotSurroundHeader></c></description></item>
    ///   <item><description><see cref=" DXW.BordersDoNotSurroundFooter" /> <c>&lt;w:bordersDoNotSurroundFooter></c></description></item>
    ///   <item><description><see cref=" DXW.GutterAtTop" /> <c>&lt;w:gutterAtTop></c></description></item>
    ///   <item><description><see cref=" DXW.HideSpellingErrors" /> <c>&lt;w:hideSpellingErrors></c></description></item>
    ///   <item><description><see cref=" DXW.HideGrammaticalErrors" /> <c>&lt;w:hideGrammaticalErrors></c></description></item>
    ///   <item><description><see cref=" DXW.FormsDesign" /> <c>&lt;w:formsDesign></c></description></item>
    ///   <item><description><see cref=" DXW.LinkStyles" /> <c>&lt;w:linkStyles></c></description></item>
    ///   <item><description><see cref=" DXW.TrackRevisions" /> <c>&lt;w:trackRevisions></c></description></item>
    ///   <item><description><see cref=" DXW.DoNotTrackMoves" /> <c>&lt;w:doNotTrackMoves></c></description></item>
    ///   <item><description><see cref=" DXW.DoNotTrackFormatting" /> <c>&lt;w:doNotTrackFormatting></c></description></item>
    ///   <item><description><see cref=" DXW.AutoFormatOverride" /> <c>&lt;w:autoFormatOverride></c></description></item>
    ///   <item><description><see cref=" DXW.StyleLockThemesPart" /> <c>&lt;w:styleLockTheme></c></description></item>
    ///   <item><description><see cref=" DXW.StyleLockStylesPart" /> <c>&lt;w:styleLockQFSet></c></description></item>
    ///   <item><description><see cref=" DXW.AutoHyphenation" /> <c>&lt;w:autoHyphenation></c></description></item>
    ///   <item><description><see cref=" DXW.DoNotHyphenateCaps" /> <c>&lt;w:doNotHyphenateCaps></c></description></item>
    ///   <item><description><see cref=" DXW.ShowEnvelope" /> <c>&lt;w:showEnvelope></c></description></item>
    ///   <item><description><see cref=" DXW.EvenAndOddHeaders" /> <c>&lt;w:evenAndOddHeaders></c></description></item>
    ///   <item><description><see cref=" DXW.BookFoldReversePrinting" /> <c>&lt;w:bookFoldRevPrinting></c></description></item>
    ///   <item><description><see cref=" DXW.BookFoldPrinting" /> <c>&lt;w:bookFoldPrinting></c></description></item>
    ///   <item><description><see cref=" DXW.DoNotUseMarginsForDrawingGridOrigin" /> <c>&lt;w:doNotUseMarginsForDrawingGridOrigin></c></description></item>
    ///   <item><description><see cref=" DXW.DoNotShadeFormData" /> <c>&lt;w:doNotShadeFormData></c></description></item>
    ///   <item><description><see cref=" DXW.NoPunctuationKerning" /> <c>&lt;w:noPunctuationKerning></c></description></item>
    ///   <item><description><see cref=" DXW.PrintTwoOnOne" /> <c>&lt;w:printTwoOnOne></c></description></item>
    ///   <item><description><see cref=" DXW.StrictFirstAndLastChars" /> <c>&lt;w:strictFirstAndLastChars></c></description></item>
    ///   <item><description><see cref=" DXW.SavePreviewPicture" /> <c>&lt;w:savePreviewPicture></c></description></item>
    ///   <item><description><see cref=" DXW.DoNotValidateAgainstSchema" /> <c>&lt;w:doNotValidateAgainstSchema></c></description></item>
    ///   <item><description><see cref=" DXW.SaveInvalidXml" /> <c>&lt;w:saveInvalidXml></c></description></item>
    ///   <item><description><see cref=" DXW.IgnoreMixedContent" /> <c>&lt;w:ignoreMixedContent></c></description></item>
    ///   <item><description><see cref=" DXW.AlwaysShowPlaceholderText" /> <c>&lt;w:alwaysShowPlaceholderText></c></description></item>
    ///   <item><description><see cref=" DXW.DoNotDemarcateInvalidXml" /> <c>&lt;w:doNotDemarcateInvalidXml></c></description></item>
    ///   <item><description><see cref=" DXW.SaveXmlDataOnly" /> <c>&lt;w:saveXmlDataOnly></c></description></item>
    ///   <item><description><see cref=" DXW.UseXsltWhenSaving" /> <c>&lt;w:useXSLTWhenSaving></c></description></item>
    ///   <item><description><see cref=" DXW.ShowXmlTags" /> <c>&lt;w:showXMLTags></c></description></item>
    ///   <item><description><see cref=" DXW.AlwaysMergeEmptyNamespace" /> <c>&lt;w:alwaysMergeEmptyNamespace></c></description></item>
    ///   <item><description><see cref=" DXW.UpdateFieldsOnOpen" /> <c>&lt;w:updateFields></c></description></item>
    ///   <item><description><see cref=" DXW.UICompatibleWith97To2003" /> <c>&lt;w:uiCompat97To2003></c></description></item>
    ///   <item><description><see cref=" DXW.DoNotIncludeSubdocsInStats" /> <c>&lt;w:doNotIncludeSubdocsInStats></c></description></item>
    ///   <item><description><see cref=" DXW.DoNotAutoCompressPictures" /> <c>&lt;w:doNotAutoCompressPictures></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Word.ChartTrackingRefBased" /> <c>&lt;w15:chartTrackingRefBased></c></description></item>
    ///   <item><description><see cref=" DXW.ProofState" /> <c>&lt;w:proofState></c></description></item>
    ///   <item><description><see cref=" DXW.ReadModeInkLockDown" /> <c>&lt;w:readModeInkLockDown></c></description></item>
    ///   <item><description><see cref=" DXW.AttachedTemplate" /> <c>&lt;w:attachedTemplate></c></description></item>
    ///   <item><description><see cref=" DXW.SaveThroughXslt" /> <c>&lt;w:saveThroughXslt></c></description></item>
    ///   <item><description><see cref=" DXW.HeaderShapeDefaults" /> <c>&lt;w:hdrShapeDefaults></c></description></item>
    ///   <item><description><see cref=" DXW.ShapeDefaults" /> <c>&lt;w:shapeDefaults></c></description></item>
    ///   <item><description><see cref=" DXW.AttachedSchema" /> <c>&lt;w:attachedSchema></c></description></item>
    ///   <item><description><see cref=" DXW.DecimalSymbol" /> <c>&lt;w:decimalSymbol></c></description></item>
    ///   <item><description><see cref=" DXW.ListSeparator" /> <c>&lt;w:listSeparator></c></description></item>
    ///   <item><description><see cref=" DXW.ClickAndTypeStyle" /> <c>&lt;w:clickAndTypeStyle></c></description></item>
    ///   <item><description><see cref=" DXW.DefaultTableStyle" /> <c>&lt;w:defaultTableStyle></c></description></item>
    ///   <item><description><see cref=" DXW.StylePaneFormatFilter" /> <c>&lt;w:stylePaneFormatFilter></c></description></item>
    ///   <item><description><see cref=" DXW.StylePaneSortMethods" /> <c>&lt;w:stylePaneSortMethod></c></description></item>
    ///   <item><description><see cref=" DXW.RevisionView" /> <c>&lt;w:revisionView></c></description></item>
    ///   <item><description><see cref=" DXW.HyphenationZone" /> <c>&lt;w:hyphenationZone></c></description></item>
    ///   <item><description><see cref=" DXW.DrawingGridHorizontalSpacing" /> <c>&lt;w:drawingGridHorizontalSpacing></c></description></item>
    ///   <item><description><see cref=" DXW.DrawingGridVerticalSpacing" /> <c>&lt;w:drawingGridVerticalSpacing></c></description></item>
    ///   <item><description><see cref=" DXW.DrawingGridHorizontalOrigin" /> <c>&lt;w:drawingGridHorizontalOrigin></c></description></item>
    ///   <item><description><see cref=" DXW.DrawingGridVerticalOrigin" /> <c>&lt;w:drawingGridVerticalOrigin></c></description></item>
    ///   <item><description><see cref=" DXW.SummaryLength" /> <c>&lt;w:summaryLength></c></description></item>
    ///   <item><description><see cref=" DXW.DisplayHorizontalDrawingGrid" /> <c>&lt;w:displayHorizontalDrawingGridEvery></c></description></item>
    ///   <item><description><see cref=" DXW.DisplayVerticalDrawingGrid" /> <c>&lt;w:displayVerticalDrawingGridEvery></c></description></item>
    ///   <item><description><see cref=" DXW.ConsecutiveHyphenLimit" /> <c>&lt;w:consecutiveHyphenLimit></c></description></item>
    ///   <item><description><see cref=" DXW.View" /> <c>&lt;w:view></c></description></item>
    ///   <item><description><see cref=" DXW.WriteProtection" /> <c>&lt;w:writeProtection></c></description></item>
    ///   <item><description><see cref=" DXW.ActiveWritingStyle" /> <c>&lt;w:activeWritingStyle></c></description></item>
    ///   <item><description><see cref=" DXW.Zoom" /> <c>&lt;w:zoom></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.Word.DefaultImageDpi" /> <c>&lt;w14:defaultImageDpi></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.Word.DocumentId" /> <c>&lt;w14:docId></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.Word.DiscardImageEditingData" /> <c>&lt;w14:discardImageEditingData></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.Word.ConflictMode" /> <c>&lt;w14:conflictMode></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Word.PersistentDocumentId" /> <c>&lt;w15:docId></c></description></item>

  //#endregion
}


