using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using System.Text.Json;
using DocumentModel.Wordprocessing;

namespace DocumentModel.InOpenXml.Test
{
  /// <summary>
  /// Comprehensive serialization test for DocumentModel.Wordprocessing.DocumentSettings.
  /// </summary>
  public static class DocumentSettingsSerializationTest
  {
    public static bool Run()
    {
      Console.WriteLine("=== DocumentSettings Serialization Test ===\n");
      if (!TestXmlSerialization()) return false;
      if (!TestJsonSerialization()) return false;
      if (!TestEdgeCases()) return false;
      Console.WriteLine("All DocumentSettings serialization tests passed.\n");
      return true;
    }

    static bool TestXmlSerialization()
    {
      Console.WriteLine("--- XML Serialization ---");
      var testData = CreateSampleDocumentSettings();
      string xmlString;
      try
      {
        var xmlSerializer = new XmlSerializer(typeof(DocumentSettings));
        using (var stringWriter = new StringWriter())
        using (var xmlWriter = XmlWriter.Create(stringWriter, new XmlWriterSettings { Indent = true }))
        {
          xmlSerializer.Serialize(xmlWriter, testData);
          xmlString = stringWriter.ToString();
        }
        Console.WriteLine("Serialized XML:\n" + xmlString.Substring(0, System.Math.Min(1000, xmlString.Length)));
        if (xmlString.Length > 1000) Console.WriteLine("...");

        DocumentSettings? deserialized;
        using (var stringReader = new StringReader(xmlString))
        {
          deserialized = (DocumentSettings?)xmlSerializer.Deserialize(stringReader);
        }
        if (deserialized == null)
        {
          Console.WriteLine("✗ XML Deserialization returned null");
          return false;
        }
        if (!CompareDocumentSettings(testData, deserialized))
        {
          Console.WriteLine("✗ XML Serialization/Deserialization test FAILED - data mismatch");
          return false;
        }
        Console.WriteLine("✓ XML Serialization/Deserialization test passed\n");
        return true;
      }
      catch (Exception ex)
      {
        Console.WriteLine($"✗ XML Serialization test FAILED: {ex.Message}\n{ex.GetInternalMessages()}");
        return false;
      }
    }

    static bool TestJsonSerialization()
    {
      Console.WriteLine("--- JSON Serialization ---");
      var testData = CreateSampleDocumentSettings();
      try
      {
        var jsonOptions = new JsonSerializerOptions { WriteIndented = true };
        string jsonString = JsonSerializer.Serialize(testData, jsonOptions);
        Console.WriteLine("Serialized JSON:\n" + jsonString.Substring(0, System.Math.Min(1000, jsonString.Length)));
        if (jsonString.Length > 1000) Console.WriteLine("...");

        var deserialized = JsonSerializer.Deserialize<DocumentSettings>(jsonString, jsonOptions);
        if (deserialized == null)
        {
          Console.WriteLine("✗ JSON Deserialization returned null");
          return false;
        }
        if (!CompareDocumentSettings(testData, deserialized))
        {
          Console.WriteLine("✗ JSON Serialization/Deserialization test FAILED - data mismatch");
          return false;
        }
        Console.WriteLine("✓ JSON Serialization/Deserialization test passed\n");
        return true;
      }
      catch (Exception ex)
      {
        Console.WriteLine($"✗ JSON Serialization test FAILED: {ex.Message}\n{ex.GetInternalMessages()}");
        return false;
      }
    }

    static bool TestEdgeCases()
    {
      Console.WriteLine("--- Edge Cases ---");
      try
      {
        var empty = new DocumentSettings();
        string xml = SerializeToXml(empty);
        var xmlDeserialized = DeserializeFromXml(xml);
        if (xmlDeserialized == null)
        {
          Console.WriteLine("✗ Edge case: XML deserialization of empty object failed");
          return false;
        }
        string json = SerializeToJson(empty);
        var jsonDeserialized = DeserializeFromJson(json);
        if (jsonDeserialized == null)
        {
          Console.WriteLine("✗ Edge case: JSON deserialization of empty object failed");
          return false;
        }
        Console.WriteLine("✓ Edge case tests passed\n");
        return true;
      }
      catch (Exception ex)
      {
        Console.WriteLine($"✗ Edge case test FAILED: {ex.Message}\n{ex.GetInternalMessages()}");
        return false;
      }
    }

    static DocumentSettings CreateSampleDocumentSettings()
    {
      var settings = new DocumentSettings
      {
        AlignBorderAndEdges = true,
        AlwaysMergeEmptyNamespace = true,
        AlwaysShowPlaceholderText = false,
        AutoFormatOverride = true,
        AutoHyphenation = false,
        BookFoldPrinting = true,
        BookFoldPrintingSheets = 8,
        BookFoldReversePrinting = false,
        BordersDoNotSurroundFooter = true,
        BordersDoNotSurroundHeader = false,
        CharacterSpacingControl = CharacterSpacingKind.CompressPunctuation,
        ChartTrackingRefBased = true,
        ClickAndTypeStyle = "Normal",
        ConflictMode = false,
        ConsecutiveHyphenLimit = 2,
        DecimalSymbol = ".",
        DefaultImageDpi = 300,
        DefaultTableStyle = "TableGrid",
        DefaultTabStop = 720,
        DiscardImageEditingData = true,
        DisplayBackgroundShape = false,
        DisplayHorizontalDrawingGrid = 5,
        DisplayVerticalDrawingGrid = 10,
        DoNotAutoCompressPictures = true,
        DoNotDemarcateInvalidXml = false,
        DoNotDisplayPageBoundaries = true,
        DoNotHyphenateCaps = false,
        DoNotIncludeSubdocsInStats = true,
        DoNotShadeFormData = false,
        DoNotTrackFormatting = true,
        DoNotTrackMoves = false,
        DoNotUseMarginsForDrawingGridOrigin = true,
        DoNotValidateAgainstSchema = false,
        EmbedSystemFonts = true,
        EmbedTrueTypeFonts = false,
        EvenAndOddHeaders = true,
        ForceUpgrade = false,
        FormsDesign = true,
        GutterAtTop = false,
        HideGrammaticalErrors = true,
        HideSpellingErrors = false,
        HyphenationZone = new Twips(360),
        IgnoreMixedContent = true,
        LinkStyles = false,
        ListSeparator = ";",
        MirrorMargins = true,
        NoPunctuationKerning = false,
        PrintFormsData = true,
        PrintFractionalCharacterWidth = false,
        PrintPostScriptOverText = true,
        PrintTwoOnOne = false,
        RemoveDateAndTime = true,
        RemovePersonalInformation = false,
        SaveFormsData = true,
        SaveInvalidXml = false,
        SavePreviewPicture = true,
        SaveSubsetFonts = false,
        SaveXmlDataOnly = true,
        ShowEnvelope = false,
        ShowXmlTags = true,
        StrictFirstAndLastChars = false,
        StylePaneSortMethods = "alpha",
        SummaryLength = new Percent(50),
        TrackRevisions = true,
        UICompatibleWith97To2003 = false,
        UpdateFieldsOnOpen = true,
        UseXsltWhenSaving = false,
        View = ViewKind.Print
      };
      return settings;
    }

    static bool CompareDocumentSettings(DocumentSettings a, DocumentSettings b)
    {
      // Compare a representative subset of properties for equality
      return a.AlignBorderAndEdges == b.AlignBorderAndEdges &&
             a.AlwaysMergeEmptyNamespace == b.AlwaysMergeEmptyNamespace &&
             a.AlwaysShowPlaceholderText == b.AlwaysShowPlaceholderText &&
             a.AutoFormatOverride == b.AutoFormatOverride &&
             a.AutoHyphenation == b.AutoHyphenation &&
             a.BookFoldPrinting == b.BookFoldPrinting &&
             a.BookFoldPrintingSheets == b.BookFoldPrintingSheets &&
             a.BookFoldReversePrinting == b.BookFoldReversePrinting &&
             a.BordersDoNotSurroundFooter == b.BordersDoNotSurroundFooter &&
             a.BordersDoNotSurroundHeader == b.BordersDoNotSurroundHeader &&
             a.CharacterSpacingControl == b.CharacterSpacingControl &&
             a.ChartTrackingRefBased == b.ChartTrackingRefBased &&
             a.ClickAndTypeStyle == b.ClickAndTypeStyle &&
             a.ConflictMode == b.ConflictMode &&
             a.ConsecutiveHyphenLimit == b.ConsecutiveHyphenLimit &&
             a.DecimalSymbol == b.DecimalSymbol &&
             a.DefaultImageDpi == b.DefaultImageDpi &&
             a.DefaultTableStyle == b.DefaultTableStyle &&
             a.DefaultTabStop == b.DefaultTabStop &&
             a.DiscardImageEditingData == b.DiscardImageEditingData &&
             a.DisplayBackgroundShape == b.DisplayBackgroundShape &&
             a.DisplayHorizontalDrawingGrid == b.DisplayHorizontalDrawingGrid &&
             a.DisplayVerticalDrawingGrid == b.DisplayVerticalDrawingGrid &&
             a.DoNotAutoCompressPictures == b.DoNotAutoCompressPictures &&
             a.DoNotDemarcateInvalidXml == b.DoNotDemarcateInvalidXml &&
             a.DoNotDisplayPageBoundaries == b.DoNotDisplayPageBoundaries &&
             a.DoNotHyphenateCaps == b.DoNotHyphenateCaps &&
             a.DoNotIncludeSubdocsInStats == b.DoNotIncludeSubdocsInStats &&
             a.DoNotShadeFormData == b.DoNotShadeFormData &&
             a.DoNotTrackFormatting == b.DoNotTrackFormatting &&
             a.DoNotTrackMoves == b.DoNotTrackMoves &&
             a.DoNotUseMarginsForDrawingGridOrigin == b.DoNotUseMarginsForDrawingGridOrigin &&
             a.DoNotValidateAgainstSchema == b.DoNotValidateAgainstSchema &&
             a.EmbedSystemFonts == b.EmbedSystemFonts &&
             a.EmbedTrueTypeFonts == b.EmbedTrueTypeFonts &&
             a.EvenAndOddHeaders == b.EvenAndOddHeaders &&
             a.ForceUpgrade == b.ForceUpgrade &&
             a.FormsDesign == b.FormsDesign &&
             a.GutterAtTop == b.GutterAtTop &&
             a.HideGrammaticalErrors == b.HideGrammaticalErrors &&
             a.HideSpellingErrors == b.HideSpellingErrors &&
             Equals(a.HyphenationZone, b.HyphenationZone) &&
             a.IgnoreMixedContent == b.IgnoreMixedContent &&
             a.LinkStyles == b.LinkStyles &&
             a.ListSeparator == b.ListSeparator &&
             a.MirrorMargins == b.MirrorMargins &&
             a.NoPunctuationKerning == b.NoPunctuationKerning &&
             a.PrintFormsData == b.PrintFormsData &&
             a.PrintFractionalCharacterWidth == b.PrintFractionalCharacterWidth &&
             a.PrintPostScriptOverText == b.PrintPostScriptOverText &&
             a.PrintTwoOnOne == b.PrintTwoOnOne &&
             a.RemoveDateAndTime == b.RemoveDateAndTime &&
             a.RemovePersonalInformation == b.RemovePersonalInformation &&
             a.SaveFormsData == b.SaveFormsData &&
             a.SaveInvalidXml == b.SaveInvalidXml &&
             a.SavePreviewPicture == b.SavePreviewPicture &&
             a.SaveSubsetFonts == b.SaveSubsetFonts &&
             a.SaveXmlDataOnly == b.SaveXmlDataOnly &&
             a.ShowEnvelope == b.ShowEnvelope &&
             a.ShowXmlTags == b.ShowXmlTags &&
             a.StrictFirstAndLastChars == b.StrictFirstAndLastChars &&
             a.StylePaneSortMethods == b.StylePaneSortMethods &&
             Equals(a.SummaryLength, b.SummaryLength) &&
             a.TrackRevisions == b.TrackRevisions &&
             a.UICompatibleWith97To2003 == b.UICompatibleWith97To2003 &&
             a.UpdateFieldsOnOpen == b.UpdateFieldsOnOpen &&
             a.UseXsltWhenSaving == b.UseXsltWhenSaving &&
             a.View == b.View;
    }

    static string SerializeToXml(DocumentSettings settings)
    {
      var xmlSerializer = new XmlSerializer(typeof(DocumentSettings));
      using (var stringWriter = new StringWriter())
      using (var xmlWriter = XmlWriter.Create(stringWriter, new XmlWriterSettings { Indent = true }))
      {
        xmlSerializer.Serialize(xmlWriter, settings);
        return stringWriter.ToString();
      }
    }

    static DocumentSettings? DeserializeFromXml(string xml)
    {
      var xmlSerializer = new XmlSerializer(typeof(DocumentSettings));
      using (var stringReader = new StringReader(xml))
      {
        return (DocumentSettings?)xmlSerializer.Deserialize(stringReader);
      }
    }

    static string SerializeToJson(DocumentSettings settings)
    {
      var jsonOptions = new JsonSerializerOptions { WriteIndented = true };
      return JsonSerializer.Serialize(settings, jsonOptions);
    }

    static DocumentSettings? DeserializeFromJson(string json)
    {
      var jsonOptions = new JsonSerializerOptions { WriteIndented = true };
      return JsonSerializer.Deserialize<DocumentSettings>(json, jsonOptions);
    }
  }
}