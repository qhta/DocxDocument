using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using System.Text.Json;
using DocumentModel.CustomXml;
using DocumentModel.Wordprocessing;

namespace DocumentModel.InOpenXml.Test
{
  /// <summary>
  /// Provides comprehensive serialization tests for <see cref="DocumentSettings"/>.
  /// </summary>
  public static class DocumentSettingsTest
  {
    /// <summary>
    /// Runs all serialization tests for the <see cref="DocumentSettings"/> class and reports the results to the console.
    /// </summary>
    /// <remarks>
    /// Executes XML and JSON serialization tests, as well as edge case tests, for the <see cref="DocumentSettings"/> class.
    /// Writes the progress and results to the standard output. Use this method to verify that <see cref="DocumentSettings"/> serialization behaves as expected.
    /// </remarks>
    /// <returns>True if all serialization tests pass; otherwise, false.</returns>
    public static bool Run()
    {
      Console.WriteLine("=== DocumentSettings Test ===\n");
      if (!TestXmlSerialization()) return false;
      if (!TestJsonSerialization()) return false;
      if (!TestEdgeCases()) return false;
      if (!TestStoreInDocument()) return false;
      Console.WriteLine("All DocumentSettings tests passed.\n");
      return true;
    }

    /// <summary>
    /// Tests XML serialization and deserialization for <see cref="DocumentSettings"/>.
    /// </summary>
    /// <returns>True if the round-trip succeeds; otherwise, false.</returns>
    static bool TestXmlSerialization()
    {
      Console.WriteLine("--- XML Serialization ---");
      var testData = CreateSampleDocumentSettings();
      var xmlSerializer = new XmlSerializer(typeof(DocumentSettings));
      string xmlString;
      using (var stringWriter = new StringWriter())
      using (var xmlWriter = XmlWriter.Create(stringWriter, new XmlWriterSettings { Indent = true }))
      {
        xmlSerializer.Serialize(xmlWriter, testData);
        xmlString = stringWriter.ToString();
      }
      Console.WriteLine("Serialized XML:\n" + xmlString);

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

      if (!TestHelper.CompareTestData(testData, deserialized, out var propName))
      {
        Console.WriteLine($"✗ XML Serialization/Deserialization test FAILED - data mismatch in property '{propName}'");
        return false;
      }
      Console.WriteLine("✓ XML Serialization/Deserialization test passed\n");
      return true;
    }

    /// <summary>
    /// Tests JSON serialization and deserialization for <see cref="DocumentSettings"/>.
    /// </summary>
    /// <returns>True if the round-trip succeeds; otherwise, false.</returns>
    static bool TestJsonSerialization()
    {
      Console.WriteLine("--- JSON Serialization ---");
      var testData = CreateSampleDocumentSettings();
      var jsonOptions = JsonConfig.Options;
      string jsonString = JsonSerializer.Serialize(testData, jsonOptions);
      Console.WriteLine("Serialized JSON:\n" + jsonString);

      var deserialized = JsonSerializer.Deserialize<DocumentSettings>(jsonString, jsonOptions);
      if (deserialized == null)
      {
        Console.WriteLine("✗ JSON Deserialization returned null");
        return false;
      }
      if (!TestHelper.CompareTestData(testData, deserialized, out var propName))
      {
        Console.WriteLine($"✗ JSON Serialization/Deserialization test FAILED - data mismatch in property '{propName}'");
        return false;
      }
      Console.WriteLine("✓ JSON Serialization/Deserialization test passed\n");
      return true;
    }

    /// <summary>
    /// Tests edge cases for serialization and deserialization of empty <see cref="DocumentSettings"/> objects.
    /// </summary>
    /// <returns>True if all edge case tests pass; otherwise, false.</returns>
    static bool TestEdgeCases()
    {
      Console.WriteLine("--- Edge Cases ---");
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

    static bool TestStoreInDocument()
    {
      Console.WriteLine("--- Store sample document settings in new document---");
      DocumentSettings testData = CreateSampleDocumentSettings(true);
      using (var document = Document.CreateDocument("temp.docx"))
      {
        document.DocumentSettings = testData;
      }

      DocumentSettings? storedData;
      using (var document = Document.OpenDocument("temp.docx"))
      {
        storedData = document.DocumentSettings;
      }

      var xmlSerializer = new XmlSerializer(typeof(DocumentSettings));
      string xmlString;
      using (var stringWriter = new StringWriter())
      using (var xmlWriter = XmlWriter.Create(stringWriter, new XmlWriterSettings { Indent = true }))
      {
        xmlSerializer.Serialize(xmlWriter, storedData);
        xmlString = stringWriter.ToString();
      }
      Console.WriteLine("document settings stored to new document and reloaded from it:\n" + xmlString);

      if (storedData == null)
      {
        Console.WriteLine("✗ XML Deserialization returned null");
        return false;
      }

      if (!TestHelper.CompareTestData(testData, storedData, out var propName))
      {
        Console.WriteLine($"✗ Store sample document settings test FAILED - data mismatch in property '{propName}'");
        return false;
      }

      Console.WriteLine("✓ Store sample document settings test passed\n");
      return true;
    }

    /// <summary>
    /// Creates a sample <see cref="DocumentSettings"/> instance for testing.
    /// </summary>
    /// <returns>A populated <see cref="DocumentSettings"/> object.</returns>
    static DocumentSettings CreateSampleDocumentSettings(bool createAllProperties = true)
    {
      if (!createAllProperties)
        return new DocumentSettings
        {
          AlignBorderAndEdges = true,
          BordersDoNotSurroundFooter = true,
          BordersDoNotSurroundHeader = false,
          DisplayBackgroundShape = false,
          DoNotDisplayPageBoundaries = true,
          EmbedSystemFonts = true,
          EmbedTrueTypeFonts = false,
          GutterAtTop = false,
          HideGrammaticalErrors = true,
          HideSpellingErrors = false,
          MirrorMargins = true,
          PrintFormsData = true,
          PrintPostScriptOverText = true,
          RemoveDateAndTime = true,
          RemovePersonalInformation = false,
          SaveFormsData = true,
          SaveSubsetFonts = false,
          View = ViewKind.Print,
          Zoom = 100, //PresetZoomKind.FullPage,
        };
      else
        return new DocumentSettings
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
          View = ViewKind.Print,
          Zoom = 100, // PresetZoomKind.FullPage,

          ActiveWritingStyles =
          [
            new ActiveWritingStyle
            {
              ApplicationName = "MyApp",
              CheckStyle = true,
              DllVersion = 1,
              VendorID = 1234,
              Language = "en-US",
              NaturalLanguageGrammarCheck = true
            },
            new ActiveWritingStyle
            {
              ApplicationName = "AnotherApp",
              CheckStyle = false,
              DllVersion = 2,
              VendorID = 5678,
              Language = "fr-FR",
              NaturalLanguageGrammarCheck = false
            }
          ],
          AttachedSchemas = new AttachedSchemas([
            new AttachedSchema
            {
              Uri = "http://example.com/schema1",
            },
            new AttachedSchema
            {
              Uri = "http://example.com/schema2",
            }
          ]),
          AttachedTemplate = new AttachedTemplate("http://example.com/template.dotx"),
          Captions = new Captions
          {
            CaptionDefinitions = new CaptionDefinitions([
              new CaptionDefinition
              {
                Name = "Figure",
                Position = CaptionPositionKind.Below
              },
              new CaptionDefinition
              {
                Name = "Table",
                Position = CaptionPositionKind.Above
              }
            ]),
            AutoCaptions = new AutoCaptions([
              new AutoCaption
              {
                Name = "Figure",
                Caption = "Fig.",
              },
              new AutoCaption
              {
                Name = "Table",
                Caption = "Tab.",
              }
            ])
          }
        };
    }

    /// <summary>
    /// Serializes a <see cref="DocumentSettings"/> instance to XML.
    /// </summary>
    /// <param name="settings">The <see cref="DocumentSettings"/> instance to serialize.</param>
    /// <returns>XML string representation.</returns>
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

    /// <summary>
    /// Deserializes a <see cref="DocumentSettings"/> instance from XML.
    /// </summary>
    /// <param name="xml">The XML string to deserialize.</param>
    /// <returns>The deserialized <see cref="DocumentSettings"/> instance.</returns>
    static DocumentSettings? DeserializeFromXml(string xml)
    {
      var xmlSerializer = new XmlSerializer(typeof(DocumentSettings));
      using (var stringReader = new StringReader(xml))
      {
        return (DocumentSettings?)xmlSerializer.Deserialize(stringReader);
      }
    }

    /// <summary>
    /// Serializes a <see cref="DocumentSettings"/> instance to JSON.
    /// </summary>
    /// <param name="settings">The <see cref="DocumentSettings"/> instance to serialize.</param>
    /// <returns>JSON string representation.</returns>
    static string SerializeToJson(DocumentSettings settings)
    {
      var jsonOptions = new JsonSerializerOptions { WriteIndented = true };
      return JsonSerializer.Serialize(settings, jsonOptions);
    }

    /// <summary>
    /// Deserializes a <see cref="DocumentSettings"/> instance from JSON.
    /// </summary>
    /// <param name="json">The JSON string to deserialize.</param>
    /// <returns>The deserialized <see cref="DocumentSettings"/> instance.</returns>
    static DocumentSettings? DeserializeFromJson(string json)
    {
      var jsonOptions = new JsonSerializerOptions { WriteIndented = true };
      return JsonSerializer.Deserialize<DocumentSettings>(json, jsonOptions);
    }
  }
}