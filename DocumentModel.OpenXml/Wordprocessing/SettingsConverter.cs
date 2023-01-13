namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Document Settings.
/// </summary>
public static class SettingsConverter
{
  /// <summary>
  /// Write Protection.
  /// </summary>
  public static DocumentModel.Wordprocessing.WriteProtection? GetWriteProtection(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.WriteProtection>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.WriteProtectionConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetWriteProtection(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement, DocumentModel.Wordprocessing.WriteProtection? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.WriteProtection>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Wordprocessing.WriteProtectionConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.WriteProtection>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// Document View Setting.
  /// </summary>
  public static DocumentModel.Wordprocessing.ViewKind? GetView(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.View>();
      if (itemElement?.Val?.Value != null)
      {
        return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.ViewValues, DocumentModel.Wordprocessing.ViewKind>(itemElement.Val.Value);
      }
    }
    return null;
  }
  
  public static void SetView(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement, DocumentModel.Wordprocessing.ViewKind? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.View>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EnumValueConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.View, DocumentFormat.OpenXml.Wordprocessing.ViewValues, DocumentModel.Wordprocessing.ViewKind>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// Magnification Setting.
  /// </summary>
  public static DocumentModel.Wordprocessing.Zoom? GetZoom(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Zoom>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.ZoomConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetZoom(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement, DocumentModel.Wordprocessing.Zoom? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Zoom>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Wordprocessing.ZoomConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.Zoom>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// Remove Personal Information from Document Properties.
  /// </summary>
  public static Boolean? GetRemovePersonalInformation(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.RemovePersonalInformation>();
      return itemElement != null;
    }
    return null;
  }
  
  public static void SetRemovePersonalInformation(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.RemovePersonalInformation>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new DocumentFormat.OpenXml.Wordprocessing.RemovePersonalInformation();
        openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// Remove Date and Time from Annotations.
  /// </summary>
  public static Boolean? GetRemoveDateAndTime(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.RemoveDateAndTime>();
      return itemElement != null;
    }
    return null;
  }
  
  public static void SetRemoveDateAndTime(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.RemoveDateAndTime>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new DocumentFormat.OpenXml.Wordprocessing.RemoveDateAndTime();
        openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// Do Not Display Visual Boundary For Header/Footer or Between Pages.
  /// </summary>
  public static Boolean? GetDoNotDisplayPageBoundaries(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DoNotDisplayPageBoundaries>();
      return itemElement != null;
    }
    return null;
  }
  
  public static void SetDoNotDisplayPageBoundaries(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DoNotDisplayPageBoundaries>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new DocumentFormat.OpenXml.Wordprocessing.DoNotDisplayPageBoundaries();
        openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// Display Background Objects When Displaying Document.
  /// </summary>
  public static Boolean? GetDisplayBackgroundShape(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DisplayBackgroundShape>();
      return itemElement != null;
    }
    return null;
  }
  
  public static void SetDisplayBackgroundShape(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DisplayBackgroundShape>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new DocumentFormat.OpenXml.Wordprocessing.DisplayBackgroundShape();
        openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// Print PostScript Codes With Document Text.
  /// </summary>
  public static Boolean? GetPrintPostScriptOverText(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.PrintPostScriptOverText>();
      return itemElement != null;
    }
    return null;
  }
  
  public static void SetPrintPostScriptOverText(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.PrintPostScriptOverText>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new DocumentFormat.OpenXml.Wordprocessing.PrintPostScriptOverText();
        openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// Print Fractional Character Widths.
  /// </summary>
  public static Boolean? GetPrintFractionalCharacterWidth(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.PrintFractionalCharacterWidth>();
      return itemElement != null;
    }
    return null;
  }
  
  public static void SetPrintFractionalCharacterWidth(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.PrintFractionalCharacterWidth>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new DocumentFormat.OpenXml.Wordprocessing.PrintFractionalCharacterWidth();
        openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// Only Print Form Field Content.
  /// </summary>
  public static Boolean? GetPrintFormsData(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.PrintFormsData>();
      return itemElement != null;
    }
    return null;
  }
  
  public static void SetPrintFormsData(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.PrintFormsData>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new DocumentFormat.OpenXml.Wordprocessing.PrintFormsData();
        openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// Embed TrueType Fonts.
  /// </summary>
  public static Boolean? GetEmbedTrueTypeFonts(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.EmbedTrueTypeFonts>();
      return itemElement != null;
    }
    return null;
  }
  
  public static void SetEmbedTrueTypeFonts(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.EmbedTrueTypeFonts>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new DocumentFormat.OpenXml.Wordprocessing.EmbedTrueTypeFonts();
        openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// Embed Common System Fonts.
  /// </summary>
  public static Boolean? GetEmbedSystemFonts(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.EmbedSystemFonts>();
      return itemElement != null;
    }
    return null;
  }
  
  public static void SetEmbedSystemFonts(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.EmbedSystemFonts>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new DocumentFormat.OpenXml.Wordprocessing.EmbedSystemFonts();
        openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// Subset Fonts When Embedding.
  /// </summary>
  public static Boolean? GetSaveSubsetFonts(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.SaveSubsetFonts>();
      return itemElement != null;
    }
    return null;
  }
  
  public static void SetSaveSubsetFonts(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.SaveSubsetFonts>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new DocumentFormat.OpenXml.Wordprocessing.SaveSubsetFonts();
        openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// Only Save Form Field Content.
  /// </summary>
  public static Boolean? GetSaveFormsData(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.SaveFormsData>();
      return itemElement != null;
    }
    return null;
  }
  
  public static void SetSaveFormsData(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.SaveFormsData>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new DocumentFormat.OpenXml.Wordprocessing.SaveFormsData();
        openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// Mirror Page Margins.
  /// </summary>
  public static Boolean? GetMirrorMargins(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.MirrorMargins>();
      return itemElement != null;
    }
    return null;
  }
  
  public static void SetMirrorMargins(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.MirrorMargins>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new DocumentFormat.OpenXml.Wordprocessing.MirrorMargins();
        openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// Align Paragraph and Table Borders with Page Border.
  /// </summary>
  public static Boolean? GetAlignBorderAndEdges(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.AlignBorderAndEdges>();
      return itemElement != null;
    }
    return null;
  }
  
  public static void SetAlignBorderAndEdges(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.AlignBorderAndEdges>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new DocumentFormat.OpenXml.Wordprocessing.AlignBorderAndEdges();
        openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// Page Border Excludes Header.
  /// </summary>
  public static Boolean? GetBordersDoNotSurroundHeader(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.BordersDoNotSurroundHeader>();
      return itemElement != null;
    }
    return null;
  }
  
  public static void SetBordersDoNotSurroundHeader(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.BordersDoNotSurroundHeader>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new DocumentFormat.OpenXml.Wordprocessing.BordersDoNotSurroundHeader();
        openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// Page Border Excludes Footer.
  /// </summary>
  public static Boolean? GetBordersDoNotSurroundFooter(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.BordersDoNotSurroundFooter>();
      return itemElement != null;
    }
    return null;
  }
  
  public static void SetBordersDoNotSurroundFooter(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.BordersDoNotSurroundFooter>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new DocumentFormat.OpenXml.Wordprocessing.BordersDoNotSurroundFooter();
        openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// Position Gutter At Top of Page.
  /// </summary>
  public static Boolean? GetGutterAtTop(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.GutterAtTop>();
      return itemElement != null;
    }
    return null;
  }
  
  public static void SetGutterAtTop(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.GutterAtTop>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new DocumentFormat.OpenXml.Wordprocessing.GutterAtTop();
        openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// Do Not Display Visual Indication of Spelling Errors.
  /// </summary>
  public static Boolean? GetHideSpellingErrors(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.HideSpellingErrors>();
      return itemElement != null;
    }
    return null;
  }
  
  public static void SetHideSpellingErrors(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.HideSpellingErrors>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new DocumentFormat.OpenXml.Wordprocessing.HideSpellingErrors();
        openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// Do Not Display Visual Indication of Grammatical Errors.
  /// </summary>
  public static Boolean? GetHideGrammaticalErrors(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.HideGrammaticalErrors>();
      return itemElement != null;
    }
    return null;
  }
  
  public static void SetHideGrammaticalErrors(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.HideGrammaticalErrors>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new DocumentFormat.OpenXml.Wordprocessing.HideGrammaticalErrors();
        openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static System.Collections.ObjectModel.Collection<DocumentModel.Wordprocessing.ActiveWritingStyle>? GetActiveWritingStyles(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new System.Collections.ObjectModel.Collection<DocumentModel.Wordprocessing.ActiveWritingStyle>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Wordprocessing.ActiveWritingStyle>())
      {
        var newItem = DocumentModel.OpenXml.Wordprocessing.ActiveWritingStyleConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }
  
  public static void SetActiveWritingStyles(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement, System.Collections.ObjectModel.Collection<DocumentModel.Wordprocessing.ActiveWritingStyle>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Wordprocessing.ActiveWritingStyle>();
      if (value != null)
      {
        foreach (var item in value)
        {
          var newItem = DocumentModel.OpenXml.Wordprocessing.ActiveWritingStyleConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.ActiveWritingStyle>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
      }
    }
  }
  
  public static DocumentModel.Wordprocessing.ProofState? GetProofState(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.ProofState>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.ProofStateConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetProofState(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement, DocumentModel.Wordprocessing.ProofState? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.ProofState>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Wordprocessing.ProofStateConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.ProofState>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static Boolean? GetFormsDesign(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.FormsDesign>();
      return itemElement != null;
    }
    return null;
  }
  
  public static void SetFormsDesign(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.FormsDesign>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new DocumentFormat.OpenXml.Wordprocessing.FormsDesign();
        openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Wordprocessing.RelationshipType? GetAttachedTemplate(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.AttachedTemplate>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.RelationshipTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetAttachedTemplate(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement, DocumentModel.Wordprocessing.RelationshipType? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.AttachedTemplate>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Wordprocessing.RelationshipTypeConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.AttachedTemplate>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static Boolean? GetLinkStyles(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.LinkStyles>();
      return itemElement != null;
    }
    return null;
  }
  
  public static void SetLinkStyles(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.LinkStyles>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new DocumentFormat.OpenXml.Wordprocessing.LinkStyles();
        openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Wordprocessing.StylePaneFormatFilter? GetStylePaneFormatFilter(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.StylePaneFormatFilter>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.StylePaneFormatFilterConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetStylePaneFormatFilter(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement, DocumentModel.Wordprocessing.StylePaneFormatFilter? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.StylePaneFormatFilter>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Wordprocessing.StylePaneFormatFilterConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.StylePaneFormatFilter>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static String? GetStylePaneSortMethods(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.StylePaneSortMethods>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  public static void SetStylePaneSortMethods(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement, String? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.StylePaneSortMethods>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new DocumentFormat.OpenXml.Wordprocessing.StylePaneSortMethods { Val = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Wordprocessing.DocumentKind? GetDocumentType(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DocumentType>();
      if (itemElement?.Val?.Value != null)
      {
        return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.DocumentTypeValues, DocumentModel.Wordprocessing.DocumentKind>(itemElement.Val.Value);
      }
    }
    return null;
  }
  
  public static void SetDocumentType(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement, DocumentModel.Wordprocessing.DocumentKind? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DocumentType>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EnumValueConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.DocumentType, DocumentFormat.OpenXml.Wordprocessing.DocumentTypeValues, DocumentModel.Wordprocessing.DocumentKind>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Wordprocessing.MailMerge? GetMailMerge(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.MailMerge>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.MailMergeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetMailMerge(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement, DocumentModel.Wordprocessing.MailMerge? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.MailMerge>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Wordprocessing.MailMergeConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.MailMerge>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Wordprocessing.RevisionView? GetRevisionView(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.RevisionView>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.RevisionViewConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetRevisionView(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement, DocumentModel.Wordprocessing.RevisionView? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.RevisionView>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Wordprocessing.RevisionViewConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.RevisionView>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static Boolean? GetTrackRevisions(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.TrackRevisions>();
      return itemElement != null;
    }
    return null;
  }
  
  public static void SetTrackRevisions(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.TrackRevisions>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new DocumentFormat.OpenXml.Wordprocessing.TrackRevisions();
        openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static Boolean? GetDoNotTrackMoves(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DoNotTrackMoves>();
      return itemElement != null;
    }
    return null;
  }
  
  public static void SetDoNotTrackMoves(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DoNotTrackMoves>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new DocumentFormat.OpenXml.Wordprocessing.DoNotTrackMoves();
        openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static Boolean? GetDoNotTrackFormatting(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DoNotTrackFormatting>();
      return itemElement != null;
    }
    return null;
  }
  
  public static void SetDoNotTrackFormatting(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DoNotTrackFormatting>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new DocumentFormat.OpenXml.Wordprocessing.DoNotTrackFormatting();
        openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Wordprocessing.DocumentProtection? GetDocumentProtection(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DocumentProtection>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.DocumentProtectionConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetDocumentProtection(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement, DocumentModel.Wordprocessing.DocumentProtection? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DocumentProtection>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Wordprocessing.DocumentProtectionConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.DocumentProtection>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static Boolean? GetAutoFormatOverride(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.AutoFormatOverride>();
      return itemElement != null;
    }
    return null;
  }
  
  public static void SetAutoFormatOverride(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.AutoFormatOverride>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new DocumentFormat.OpenXml.Wordprocessing.AutoFormatOverride();
        openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static Int16? GetDefaultTabStop(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DefaultTabStop>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  public static void SetDefaultTabStop(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement, Int16? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DefaultTabStop>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new DocumentFormat.OpenXml.Wordprocessing.DefaultTabStop{ Val = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static Boolean? GetAutoHyphenation(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.AutoHyphenation>();
      return itemElement != null;
    }
    return null;
  }
  
  public static void SetAutoHyphenation(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.AutoHyphenation>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new DocumentFormat.OpenXml.Wordprocessing.AutoHyphenation();
        openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static UInt16? GetConsecutiveHyphenLimit(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.ConsecutiveHyphenLimit>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  public static void SetConsecutiveHyphenLimit(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement, UInt16? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.ConsecutiveHyphenLimit>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new DocumentFormat.OpenXml.Wordprocessing.ConsecutiveHyphenLimit{ Val = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static String? GetHyphenationZone(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.HyphenationZone>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  public static void SetHyphenationZone(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement, String? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.HyphenationZone>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new DocumentFormat.OpenXml.Wordprocessing.HyphenationZone { Val = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static Boolean? GetDoNotHyphenateCaps(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DoNotHyphenateCaps>();
      return itemElement != null;
    }
    return null;
  }
  
  public static void SetDoNotHyphenateCaps(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DoNotHyphenateCaps>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new DocumentFormat.OpenXml.Wordprocessing.DoNotHyphenateCaps();
        openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static Boolean? GetShowEnvelope(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.ShowEnvelope>();
      return itemElement != null;
    }
    return null;
  }
  
  public static void SetShowEnvelope(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.ShowEnvelope>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new DocumentFormat.OpenXml.Wordprocessing.ShowEnvelope();
        openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static Int32? GetSummaryLength(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.SummaryLength>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  public static void SetSummaryLength(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.SummaryLength>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new DocumentFormat.OpenXml.Wordprocessing.SummaryLength{ Val = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static String? GetClickAndTypeStyle(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.ClickAndTypeStyle>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  public static void SetClickAndTypeStyle(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement, String? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.ClickAndTypeStyle>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new DocumentFormat.OpenXml.Wordprocessing.ClickAndTypeStyle { Val = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static String? GetDefaultTableStyle(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DefaultTableStyle>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  public static void SetDefaultTableStyle(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement, String? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DefaultTableStyle>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new DocumentFormat.OpenXml.Wordprocessing.DefaultTableStyle { Val = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static Boolean? GetEvenAndOddHeaders(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.EvenAndOddHeaders>();
      return itemElement != null;
    }
    return null;
  }
  
  public static void SetEvenAndOddHeaders(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.EvenAndOddHeaders>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new DocumentFormat.OpenXml.Wordprocessing.EvenAndOddHeaders();
        openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static Boolean? GetBookFoldReversePrinting(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.BookFoldReversePrinting>();
      return itemElement != null;
    }
    return null;
  }
  
  public static void SetBookFoldReversePrinting(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.BookFoldReversePrinting>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new DocumentFormat.OpenXml.Wordprocessing.BookFoldReversePrinting();
        openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static Boolean? GetBookFoldPrinting(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.BookFoldPrinting>();
      return itemElement != null;
    }
    return null;
  }
  
  public static void SetBookFoldPrinting(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.BookFoldPrinting>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new DocumentFormat.OpenXml.Wordprocessing.BookFoldPrinting();
        openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static Int16? GetBookFoldPrintingSheets(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.BookFoldPrintingSheets>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  public static void SetBookFoldPrintingSheets(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement, Int16? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.BookFoldPrintingSheets>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new DocumentFormat.OpenXml.Wordprocessing.BookFoldPrintingSheets{ Val = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static String? GetDrawingGridHorizontalSpacing(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DrawingGridHorizontalSpacing>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  public static void SetDrawingGridHorizontalSpacing(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement, String? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DrawingGridHorizontalSpacing>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new DocumentFormat.OpenXml.Wordprocessing.DrawingGridHorizontalSpacing { Val = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static String? GetDrawingGridVerticalSpacing(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DrawingGridVerticalSpacing>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  public static void SetDrawingGridVerticalSpacing(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement, String? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DrawingGridVerticalSpacing>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new DocumentFormat.OpenXml.Wordprocessing.DrawingGridVerticalSpacing { Val = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static Int32? GetDisplayHorizontalDrawingGrid(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DisplayHorizontalDrawingGrid>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  public static void SetDisplayHorizontalDrawingGrid(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DisplayHorizontalDrawingGrid>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new DocumentFormat.OpenXml.Wordprocessing.DisplayHorizontalDrawingGrid{ Val = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static Int32? GetDisplayVerticalDrawingGrid(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DisplayVerticalDrawingGrid>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  public static void SetDisplayVerticalDrawingGrid(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DisplayVerticalDrawingGrid>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new DocumentFormat.OpenXml.Wordprocessing.DisplayVerticalDrawingGrid{ Val = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static Boolean? GetDoNotUseMarginsForDrawingGridOrigin(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DoNotUseMarginsForDrawingGridOrigin>();
      return itemElement != null;
    }
    return null;
  }
  
  public static void SetDoNotUseMarginsForDrawingGridOrigin(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DoNotUseMarginsForDrawingGridOrigin>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new DocumentFormat.OpenXml.Wordprocessing.DoNotUseMarginsForDrawingGridOrigin();
        openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static String? GetDrawingGridHorizontalOrigin(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DrawingGridHorizontalOrigin>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  public static void SetDrawingGridHorizontalOrigin(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement, String? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DrawingGridHorizontalOrigin>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new DocumentFormat.OpenXml.Wordprocessing.DrawingGridHorizontalOrigin { Val = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static String? GetDrawingGridVerticalOrigin(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DrawingGridVerticalOrigin>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  public static void SetDrawingGridVerticalOrigin(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement, String? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DrawingGridVerticalOrigin>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new DocumentFormat.OpenXml.Wordprocessing.DrawingGridVerticalOrigin { Val = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static Boolean? GetDoNotShadeFormData(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DoNotShadeFormData>();
      return itemElement != null;
    }
    return null;
  }
  
  public static void SetDoNotShadeFormData(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DoNotShadeFormData>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new DocumentFormat.OpenXml.Wordprocessing.DoNotShadeFormData();
        openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static Boolean? GetNoPunctuationKerning(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.NoPunctuationKerning>();
      return itemElement != null;
    }
    return null;
  }
  
  public static void SetNoPunctuationKerning(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.NoPunctuationKerning>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new DocumentFormat.OpenXml.Wordprocessing.NoPunctuationKerning();
        openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Wordprocessing.CharacterSpacingKind? GetCharacterSpacingControl(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.CharacterSpacingControl>();
      if (itemElement?.Val?.Value != null)
      {
        return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.CharacterSpacingValues, DocumentModel.Wordprocessing.CharacterSpacingKind>(itemElement.Val.Value);
      }
    }
    return null;
  }
  
  public static void SetCharacterSpacingControl(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement, DocumentModel.Wordprocessing.CharacterSpacingKind? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.CharacterSpacingControl>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EnumValueConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.CharacterSpacingControl, DocumentFormat.OpenXml.Wordprocessing.CharacterSpacingValues, DocumentModel.Wordprocessing.CharacterSpacingKind>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static Boolean? GetPrintTwoOnOne(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.PrintTwoOnOne>();
      return itemElement != null;
    }
    return null;
  }
  
  public static void SetPrintTwoOnOne(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.PrintTwoOnOne>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new DocumentFormat.OpenXml.Wordprocessing.PrintTwoOnOne();
        openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static Boolean? GetStrictFirstAndLastChars(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.StrictFirstAndLastChars>();
      return itemElement != null;
    }
    return null;
  }
  
  public static void SetStrictFirstAndLastChars(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.StrictFirstAndLastChars>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new DocumentFormat.OpenXml.Wordprocessing.StrictFirstAndLastChars();
        openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Wordprocessing.NoLineBreaksAfterKinsoku? GetNoLineBreaksAfterKinsoku(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.NoLineBreaksAfterKinsoku>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.NoLineBreaksAfterKinsokuConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetNoLineBreaksAfterKinsoku(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement, DocumentModel.Wordprocessing.NoLineBreaksAfterKinsoku? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.NoLineBreaksAfterKinsoku>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Wordprocessing.NoLineBreaksAfterKinsokuConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.NoLineBreaksAfterKinsoku>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Wordprocessing.NoLineBreaksBeforeKinsoku? GetNoLineBreaksBeforeKinsoku(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.NoLineBreaksBeforeKinsoku>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.NoLineBreaksBeforeKinsokuConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetNoLineBreaksBeforeKinsoku(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement, DocumentModel.Wordprocessing.NoLineBreaksBeforeKinsoku? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.NoLineBreaksBeforeKinsoku>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Wordprocessing.NoLineBreaksBeforeKinsokuConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.NoLineBreaksBeforeKinsoku>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static Boolean? GetSavePreviewPicture(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.SavePreviewPicture>();
      return itemElement != null;
    }
    return null;
  }
  
  public static void SetSavePreviewPicture(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.SavePreviewPicture>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new DocumentFormat.OpenXml.Wordprocessing.SavePreviewPicture();
        openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static Boolean? GetDoNotValidateAgainstSchema(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DoNotValidateAgainstSchema>();
      return itemElement != null;
    }
    return null;
  }
  
  public static void SetDoNotValidateAgainstSchema(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DoNotValidateAgainstSchema>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new DocumentFormat.OpenXml.Wordprocessing.DoNotValidateAgainstSchema();
        openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static Boolean? GetSaveInvalidXml(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.SaveInvalidXml>();
      return itemElement != null;
    }
    return null;
  }
  
  public static void SetSaveInvalidXml(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.SaveInvalidXml>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new DocumentFormat.OpenXml.Wordprocessing.SaveInvalidXml();
        openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static Boolean? GetIgnoreMixedContent(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.IgnoreMixedContent>();
      return itemElement != null;
    }
    return null;
  }
  
  public static void SetIgnoreMixedContent(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.IgnoreMixedContent>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new DocumentFormat.OpenXml.Wordprocessing.IgnoreMixedContent();
        openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static Boolean? GetAlwaysShowPlaceholderText(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.AlwaysShowPlaceholderText>();
      return itemElement != null;
    }
    return null;
  }
  
  public static void SetAlwaysShowPlaceholderText(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.AlwaysShowPlaceholderText>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new DocumentFormat.OpenXml.Wordprocessing.AlwaysShowPlaceholderText();
        openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static Boolean? GetDoNotDemarcateInvalidXml(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DoNotDemarcateInvalidXml>();
      return itemElement != null;
    }
    return null;
  }
  
  public static void SetDoNotDemarcateInvalidXml(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DoNotDemarcateInvalidXml>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new DocumentFormat.OpenXml.Wordprocessing.DoNotDemarcateInvalidXml();
        openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static Boolean? GetSaveXmlDataOnly(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.SaveXmlDataOnly>();
      return itemElement != null;
    }
    return null;
  }
  
  public static void SetSaveXmlDataOnly(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.SaveXmlDataOnly>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new DocumentFormat.OpenXml.Wordprocessing.SaveXmlDataOnly();
        openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static Boolean? GetUseXsltWhenSaving(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.UseXsltWhenSaving>();
      return itemElement != null;
    }
    return null;
  }
  
  public static void SetUseXsltWhenSaving(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.UseXsltWhenSaving>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new DocumentFormat.OpenXml.Wordprocessing.UseXsltWhenSaving();
        openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Wordprocessing.SaveThroughXslt? GetSaveThroughXslt(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.SaveThroughXslt>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.SaveThroughXsltConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetSaveThroughXslt(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement, DocumentModel.Wordprocessing.SaveThroughXslt? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.SaveThroughXslt>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Wordprocessing.SaveThroughXsltConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.SaveThroughXslt>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static Boolean? GetShowXmlTags(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.ShowXmlTags>();
      return itemElement != null;
    }
    return null;
  }
  
  public static void SetShowXmlTags(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.ShowXmlTags>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new DocumentFormat.OpenXml.Wordprocessing.ShowXmlTags();
        openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static Boolean? GetAlwaysMergeEmptyNamespace(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.AlwaysMergeEmptyNamespace>();
      return itemElement != null;
    }
    return null;
  }
  
  public static void SetAlwaysMergeEmptyNamespace(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.AlwaysMergeEmptyNamespace>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new DocumentFormat.OpenXml.Wordprocessing.AlwaysMergeEmptyNamespace();
        openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static Boolean? GetUpdateFieldsOnOpen(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.UpdateFieldsOnOpen>();
      return itemElement != null;
    }
    return null;
  }
  
  public static void SetUpdateFieldsOnOpen(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.UpdateFieldsOnOpen>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new DocumentFormat.OpenXml.Wordprocessing.UpdateFieldsOnOpen();
        openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Wordprocessing.HeaderShapeDefaults? GetHeaderShapeDefaults(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.HeaderShapeDefaults>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.HeaderShapeDefaultsConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetHeaderShapeDefaults(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement, DocumentModel.Wordprocessing.HeaderShapeDefaults? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.HeaderShapeDefaults>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Wordprocessing.HeaderShapeDefaultsConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.HeaderShapeDefaults>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Wordprocessing.FootnoteDocumentWideProperties? GetFootnoteDocumentWideProperties(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.FootnoteDocumentWideProperties>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.FootnoteDocumentWidePropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetFootnoteDocumentWideProperties(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement, DocumentModel.Wordprocessing.FootnoteDocumentWideProperties? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.FootnoteDocumentWideProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Wordprocessing.FootnoteDocumentWidePropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.FootnoteDocumentWideProperties>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Wordprocessing.EndnoteDocumentWideProperties? GetEndnoteDocumentWideProperties(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.EndnoteDocumentWideProperties>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.EndnoteDocumentWidePropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetEndnoteDocumentWideProperties(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement, DocumentModel.Wordprocessing.EndnoteDocumentWideProperties? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.EndnoteDocumentWideProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Wordprocessing.EndnoteDocumentWidePropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.EndnoteDocumentWideProperties>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Wordprocessing.Compatibility? GetCompatibility(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Compatibility>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.CompatibilityConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetCompatibility(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement, DocumentModel.Wordprocessing.Compatibility? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Compatibility>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Wordprocessing.CompatibilityConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.Compatibility>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Wordprocessing.DocumentVariables? GetDocumentVariables(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DocumentVariables>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.DocumentVariablesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetDocumentVariables(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement, DocumentModel.Wordprocessing.DocumentVariables? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DocumentVariables>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Wordprocessing.DocumentVariablesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.DocumentVariables>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Wordprocessing.Rsids? GetRsids(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Rsids>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.RsidsConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetRsids(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement, DocumentModel.Wordprocessing.Rsids? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Rsids>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Wordprocessing.RsidsConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.Rsids>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Math.MathProperties? GetMathProperties(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Math.MathProperties>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Math.MathPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetMathProperties(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement, DocumentModel.Math.MathProperties? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.MathProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Math.MathPropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Math.MathProperties>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static Boolean? GetUICompatibleWith97To2003(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.UICompatibleWith97To2003>();
      return itemElement != null;
    }
    return null;
  }
  
  public static void SetUICompatibleWith97To2003(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.UICompatibleWith97To2003>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new DocumentFormat.OpenXml.Wordprocessing.UICompatibleWith97To2003();
        openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static System.Collections.ObjectModel.Collection<String>? GetAttachedSchemas(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new System.Collections.ObjectModel.Collection<String>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Wordprocessing.AttachedSchema>())
      {
        var newItem = StringValueConverter.GetValue(item);
        if (newItem != null)
          collection.Add((string)newItem);
      }
      return collection;
    }
    return null;
  }
  
  public static void SetAttachedSchemas(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement, System.Collections.ObjectModel.Collection<String>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Wordprocessing.AttachedSchema>();
      if (value != null)
      {
        foreach (var item in value)
        {
          var newItem = StringValueConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.AttachedSchema>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
      }
    }
  }
  
  public static DocumentModel.Wordprocessing.LanguageType? GetThemeFontLanguages(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.ThemeFontLanguages>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.LanguageTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetThemeFontLanguages(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement, DocumentModel.Wordprocessing.LanguageType? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.ThemeFontLanguages>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Wordprocessing.LanguageTypeConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.ThemeFontLanguages>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Wordprocessing.ColorSchemeMapping? GetColorSchemeMapping(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.ColorSchemeMapping>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.ColorSchemeMappingConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetColorSchemeMapping(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement, DocumentModel.Wordprocessing.ColorSchemeMapping? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.ColorSchemeMapping>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Wordprocessing.ColorSchemeMappingConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.ColorSchemeMapping>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static Boolean? GetDoNotIncludeSubdocsInStats(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DoNotIncludeSubdocsInStats>();
      return itemElement != null;
    }
    return null;
  }
  
  public static void SetDoNotIncludeSubdocsInStats(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DoNotIncludeSubdocsInStats>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new DocumentFormat.OpenXml.Wordprocessing.DoNotIncludeSubdocsInStats();
        openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static Boolean? GetDoNotAutoCompressPictures(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DoNotAutoCompressPictures>();
      return itemElement != null;
    }
    return null;
  }
  
  public static void SetDoNotAutoCompressPictures(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DoNotAutoCompressPictures>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new DocumentFormat.OpenXml.Wordprocessing.DoNotAutoCompressPictures();
        openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static Boolean? GetForceUpgrade(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.ForceUpgrade>();
      return itemElement != null;
    }
    return null;
  }
  
  public static void SetForceUpgrade(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.ForceUpgrade>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new DocumentFormat.OpenXml.Wordprocessing.ForceUpgrade();
        openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Wordprocessing.Captions? GetCaptions(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Captions>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.CaptionsConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetCaptions(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement, DocumentModel.Wordprocessing.Captions? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Captions>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Wordprocessing.CaptionsConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.Captions>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Wordprocessing.ReadModeInkLockDown? GetReadModeInkLockDown(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.ReadModeInkLockDown>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.ReadModeInkLockDownConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetReadModeInkLockDown(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement, DocumentModel.Wordprocessing.ReadModeInkLockDown? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.ReadModeInkLockDown>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Wordprocessing.ReadModeInkLockDownConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.ReadModeInkLockDown>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.CustomXml.SchemaLibrary? GetSchemaLibrary(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.CustomXmlSchemaReferences.SchemaLibrary>();
    if (itemElement != null)
      return DocumentModel.OpenXml.CustomXml.SchemaLibraryConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetSchemaLibrary(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement, DocumentModel.CustomXml.SchemaLibrary? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.CustomXmlSchemaReferences.SchemaLibrary>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.CustomXml.SchemaLibraryConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.CustomXmlSchemaReferences.SchemaLibrary>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Wordprocessing.ShapeDefaults? GetShapeDefaults(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.ShapeDefaults>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.ShapeDefaultsConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetShapeDefaults(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement, DocumentModel.Wordprocessing.ShapeDefaults? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.ShapeDefaults>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Wordprocessing.ShapeDefaultsConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.ShapeDefaults>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static String? GetDecimalSymbol(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DecimalSymbol>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  public static void SetDecimalSymbol(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement, String? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DecimalSymbol>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new DocumentFormat.OpenXml.Wordprocessing.DecimalSymbol { Val = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static String? GetListSeparator(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.ListSeparator>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  public static void SetListSeparator(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement, String? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.ListSeparator>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new DocumentFormat.OpenXml.Wordprocessing.ListSeparator { Val = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static Byte[]? GetDocumentId(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.DocumentId>();
    if (itemElement != null)
      return ByteArrayConverter.GetValue(itemElement);
    return null;
  }
  
  public static void SetDocumentId(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement, Byte[]? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.DocumentId>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ByteArrayConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.Word.DocumentId>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Wordprocessing.OnOffKind? GetDiscardImageEditingData(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.DiscardImageEditingData>();
      if (itemElement?.Val?.Value != null)
      {
        return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office2010.Word.OnOffValues, DocumentModel.Wordprocessing.OnOffKind>(itemElement.Val.Value);
      }
    }
    return null;
  }
  
  public static void SetDiscardImageEditingData(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement, DocumentModel.Wordprocessing.OnOffKind? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.DiscardImageEditingData>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EnumValueConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.Word.DiscardImageEditingData, DocumentFormat.OpenXml.Office2010.Word.OnOffValues, DocumentModel.Wordprocessing.OnOffKind>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static Int32? GetDefaultImageDpi(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.DefaultImageDpi>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  public static void SetDefaultImageDpi(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.DefaultImageDpi>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new DocumentFormat.OpenXml.Office2010.Word.DefaultImageDpi{ Val = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Wordprocessing.OnOffKind? GetConflictMode(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.ConflictMode>();
      if (itemElement?.Val?.Value != null)
      {
        return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office2010.Word.OnOffValues, DocumentModel.Wordprocessing.OnOffKind>(itemElement.Val.Value);
      }
    }
    return null;
  }
  
  public static void SetConflictMode(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement, DocumentModel.Wordprocessing.OnOffKind? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.ConflictMode>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EnumValueConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.Word.ConflictMode, DocumentFormat.OpenXml.Office2010.Word.OnOffValues, DocumentModel.Wordprocessing.OnOffKind>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static Boolean? GetChartTrackingRefBased(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Word.ChartTrackingRefBased>();
      return itemElement != null;
    }
    return null;
  }
  
  public static void SetChartTrackingRefBased(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Word.ChartTrackingRefBased>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new DocumentFormat.OpenXml.Office2013.Word.ChartTrackingRefBased();
        openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static String? GetPersistentDocumentId(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2013.Word.PersistentDocumentId>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  public static void SetPersistentDocumentId(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement, String? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Word.PersistentDocumentId>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new DocumentFormat.OpenXml.Office2013.Word.PersistentDocumentId { Val = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Wordprocessing.Settings? CreateModelElement(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.Settings();
      value.WriteProtection = GetWriteProtection(openXmlElement);
      value.View = GetView(openXmlElement);
      value.Zoom = GetZoom(openXmlElement);
      value.RemovePersonalInformation = GetRemovePersonalInformation(openXmlElement);
      value.RemoveDateAndTime = GetRemoveDateAndTime(openXmlElement);
      value.DoNotDisplayPageBoundaries = GetDoNotDisplayPageBoundaries(openXmlElement);
      value.DisplayBackgroundShape = GetDisplayBackgroundShape(openXmlElement);
      value.PrintPostScriptOverText = GetPrintPostScriptOverText(openXmlElement);
      value.PrintFractionalCharacterWidth = GetPrintFractionalCharacterWidth(openXmlElement);
      value.PrintFormsData = GetPrintFormsData(openXmlElement);
      value.EmbedTrueTypeFonts = GetEmbedTrueTypeFonts(openXmlElement);
      value.EmbedSystemFonts = GetEmbedSystemFonts(openXmlElement);
      value.SaveSubsetFonts = GetSaveSubsetFonts(openXmlElement);
      value.SaveFormsData = GetSaveFormsData(openXmlElement);
      value.MirrorMargins = GetMirrorMargins(openXmlElement);
      value.AlignBorderAndEdges = GetAlignBorderAndEdges(openXmlElement);
      value.BordersDoNotSurroundHeader = GetBordersDoNotSurroundHeader(openXmlElement);
      value.BordersDoNotSurroundFooter = GetBordersDoNotSurroundFooter(openXmlElement);
      value.GutterAtTop = GetGutterAtTop(openXmlElement);
      value.HideSpellingErrors = GetHideSpellingErrors(openXmlElement);
      value.HideGrammaticalErrors = GetHideGrammaticalErrors(openXmlElement);
      value.ActiveWritingStyles = GetActiveWritingStyles(openXmlElement);
      value.ProofState = GetProofState(openXmlElement);
      value.FormsDesign = GetFormsDesign(openXmlElement);
      value.AttachedTemplate = GetAttachedTemplate(openXmlElement);
      value.LinkStyles = GetLinkStyles(openXmlElement);
      value.StylePaneFormatFilter = GetStylePaneFormatFilter(openXmlElement);
      value.StylePaneSortMethods = GetStylePaneSortMethods(openXmlElement);
      value.DocumentType = GetDocumentType(openXmlElement);
      value.MailMerge = GetMailMerge(openXmlElement);
      value.RevisionView = GetRevisionView(openXmlElement);
      value.TrackRevisions = GetTrackRevisions(openXmlElement);
      value.DoNotTrackMoves = GetDoNotTrackMoves(openXmlElement);
      value.DoNotTrackFormatting = GetDoNotTrackFormatting(openXmlElement);
      value.DocumentProtection = GetDocumentProtection(openXmlElement);
      value.AutoFormatOverride = GetAutoFormatOverride(openXmlElement);
      value.DefaultTabStop = GetDefaultTabStop(openXmlElement);
      value.AutoHyphenation = GetAutoHyphenation(openXmlElement);
      value.ConsecutiveHyphenLimit = GetConsecutiveHyphenLimit(openXmlElement);
      value.HyphenationZone = GetHyphenationZone(openXmlElement);
      value.DoNotHyphenateCaps = GetDoNotHyphenateCaps(openXmlElement);
      value.ShowEnvelope = GetShowEnvelope(openXmlElement);
      value.SummaryLength = GetSummaryLength(openXmlElement);
      value.ClickAndTypeStyle = GetClickAndTypeStyle(openXmlElement);
      value.DefaultTableStyle = GetDefaultTableStyle(openXmlElement);
      value.EvenAndOddHeaders = GetEvenAndOddHeaders(openXmlElement);
      value.BookFoldReversePrinting = GetBookFoldReversePrinting(openXmlElement);
      value.BookFoldPrinting = GetBookFoldPrinting(openXmlElement);
      value.BookFoldPrintingSheets = GetBookFoldPrintingSheets(openXmlElement);
      value.DrawingGridHorizontalSpacing = GetDrawingGridHorizontalSpacing(openXmlElement);
      value.DrawingGridVerticalSpacing = GetDrawingGridVerticalSpacing(openXmlElement);
      value.DisplayHorizontalDrawingGrid = GetDisplayHorizontalDrawingGrid(openXmlElement);
      value.DisplayVerticalDrawingGrid = GetDisplayVerticalDrawingGrid(openXmlElement);
      value.DoNotUseMarginsForDrawingGridOrigin = GetDoNotUseMarginsForDrawingGridOrigin(openXmlElement);
      value.DrawingGridHorizontalOrigin = GetDrawingGridHorizontalOrigin(openXmlElement);
      value.DrawingGridVerticalOrigin = GetDrawingGridVerticalOrigin(openXmlElement);
      value.DoNotShadeFormData = GetDoNotShadeFormData(openXmlElement);
      value.NoPunctuationKerning = GetNoPunctuationKerning(openXmlElement);
      value.CharacterSpacingControl = GetCharacterSpacingControl(openXmlElement);
      value.PrintTwoOnOne = GetPrintTwoOnOne(openXmlElement);
      value.StrictFirstAndLastChars = GetStrictFirstAndLastChars(openXmlElement);
      value.NoLineBreaksAfterKinsoku = GetNoLineBreaksAfterKinsoku(openXmlElement);
      value.NoLineBreaksBeforeKinsoku = GetNoLineBreaksBeforeKinsoku(openXmlElement);
      value.SavePreviewPicture = GetSavePreviewPicture(openXmlElement);
      value.DoNotValidateAgainstSchema = GetDoNotValidateAgainstSchema(openXmlElement);
      value.SaveInvalidXml = GetSaveInvalidXml(openXmlElement);
      value.IgnoreMixedContent = GetIgnoreMixedContent(openXmlElement);
      value.AlwaysShowPlaceholderText = GetAlwaysShowPlaceholderText(openXmlElement);
      value.DoNotDemarcateInvalidXml = GetDoNotDemarcateInvalidXml(openXmlElement);
      value.SaveXmlDataOnly = GetSaveXmlDataOnly(openXmlElement);
      value.UseXsltWhenSaving = GetUseXsltWhenSaving(openXmlElement);
      value.SaveThroughXslt = GetSaveThroughXslt(openXmlElement);
      value.ShowXmlTags = GetShowXmlTags(openXmlElement);
      value.AlwaysMergeEmptyNamespace = GetAlwaysMergeEmptyNamespace(openXmlElement);
      value.UpdateFieldsOnOpen = GetUpdateFieldsOnOpen(openXmlElement);
      value.HeaderShapeDefaults = GetHeaderShapeDefaults(openXmlElement);
      value.FootnoteDocumentWideProperties = GetFootnoteDocumentWideProperties(openXmlElement);
      value.EndnoteDocumentWideProperties = GetEndnoteDocumentWideProperties(openXmlElement);
      value.Compatibility = GetCompatibility(openXmlElement);
      value.DocumentVariables = GetDocumentVariables(openXmlElement);
      value.Rsids = GetRsids(openXmlElement);
      value.MathProperties = GetMathProperties(openXmlElement);
      value.UICompatibleWith97To2003 = GetUICompatibleWith97To2003(openXmlElement);
      value.AttachedSchemas = GetAttachedSchemas(openXmlElement);
      value.ThemeFontLanguages = GetThemeFontLanguages(openXmlElement);
      value.ColorSchemeMapping = GetColorSchemeMapping(openXmlElement);
      value.DoNotIncludeSubdocsInStats = GetDoNotIncludeSubdocsInStats(openXmlElement);
      value.DoNotAutoCompressPictures = GetDoNotAutoCompressPictures(openXmlElement);
      value.ForceUpgrade = GetForceUpgrade(openXmlElement);
      value.Captions = GetCaptions(openXmlElement);
      value.ReadModeInkLockDown = GetReadModeInkLockDown(openXmlElement);
      value.SchemaLibrary = GetSchemaLibrary(openXmlElement);
      value.ShapeDefaults = GetShapeDefaults(openXmlElement);
      value.DecimalSymbol = GetDecimalSymbol(openXmlElement);
      value.ListSeparator = GetListSeparator(openXmlElement);
      value.DocumentId = GetDocumentId(openXmlElement);
      value.DiscardImageEditingData = GetDiscardImageEditingData(openXmlElement);
      value.DefaultImageDpi = GetDefaultImageDpi(openXmlElement);
      value.ConflictMode = GetConflictMode(openXmlElement);
      value.ChartTrackingRefBased = GetChartTrackingRefBased(openXmlElement);
      value.PersistentDocumentId = GetPersistentDocumentId(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.Settings? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Wordprocessing.Settings, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetWriteProtection(openXmlElement, value?.WriteProtection);
      SetView(openXmlElement, value?.View);
      SetZoom(openXmlElement, value?.Zoom);
      SetRemovePersonalInformation(openXmlElement, value?.RemovePersonalInformation);
      SetRemoveDateAndTime(openXmlElement, value?.RemoveDateAndTime);
      SetDoNotDisplayPageBoundaries(openXmlElement, value?.DoNotDisplayPageBoundaries);
      SetDisplayBackgroundShape(openXmlElement, value?.DisplayBackgroundShape);
      SetPrintPostScriptOverText(openXmlElement, value?.PrintPostScriptOverText);
      SetPrintFractionalCharacterWidth(openXmlElement, value?.PrintFractionalCharacterWidth);
      SetPrintFormsData(openXmlElement, value?.PrintFormsData);
      SetEmbedTrueTypeFonts(openXmlElement, value?.EmbedTrueTypeFonts);
      SetEmbedSystemFonts(openXmlElement, value?.EmbedSystemFonts);
      SetSaveSubsetFonts(openXmlElement, value?.SaveSubsetFonts);
      SetSaveFormsData(openXmlElement, value?.SaveFormsData);
      SetMirrorMargins(openXmlElement, value?.MirrorMargins);
      SetAlignBorderAndEdges(openXmlElement, value?.AlignBorderAndEdges);
      SetBordersDoNotSurroundHeader(openXmlElement, value?.BordersDoNotSurroundHeader);
      SetBordersDoNotSurroundFooter(openXmlElement, value?.BordersDoNotSurroundFooter);
      SetGutterAtTop(openXmlElement, value?.GutterAtTop);
      SetHideSpellingErrors(openXmlElement, value?.HideSpellingErrors);
      SetHideGrammaticalErrors(openXmlElement, value?.HideGrammaticalErrors);
      return openXmlElement;
    }
    return default;
  }
}
