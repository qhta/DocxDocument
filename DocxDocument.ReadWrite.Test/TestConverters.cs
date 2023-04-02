using System.Reflection;
using System.Security.AccessControl;

using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Presentation;
using DocumentFormat.OpenXml.Wordprocessing;

using DocumentModel;
using DocumentModel.OpenXml;

using DocxDocument.Reader;

using Qhta.TypeUtils;

namespace DocxDocument.ReadWrite.Test;

/// <summary>
/// Test class for DocxDocument.OpenXml base converters.
/// </summary>
/// <seealso cref="DocxDocument.ReadWrite.Test.TestBase" />
public class TestConverters : TestBase
{
  /// <summary>
  /// Test of the enum value converter.
  /// </summary>
  [Test]
  public void TestEnumValueConverter()
  {
    var modelAssembly = Assembly.Load("DocumentModel");
    var sourceAssembly = Assembly.Load("DocumentFormat.OpenXml");
    var foundEnumTypes = new Dictionary<Type, Type?>();
    int foundKindTypesCount = 0;
    int missedKindTypesCount = 0;
    foreach (var type in sourceAssembly.GetTypes())
    {
      foreach (var prop in type.GetProperties())
      {
        var propType = prop.PropertyType;
        if (propType.Name.StartsWith("EnumValue"))
        {
          var argType = propType.GenericTypeArguments.FirstOrDefault();
          if (argType != null && argType.IsEnum)
            if (!foundEnumTypes.ContainsKey(argType))
            {
              var modelTypeName = argType.Name.Replace("Values", "Kind");
              var modelTypeNamespace = argType.Namespace ?? string.Empty;
              modelTypeNamespace = modelTypeNamespace.Replace("DocumentFormat.OpenXml", "DocumentModel");
              var modelTypeFullName = modelTypeNamespace + "." + modelTypeName;
              modelTypeFullName = modelTypeFullName.Replace(".Drawing.", ".Drawings.");
              var modelType = modelAssembly.GetType(modelTypeFullName);
              if (modelType == null)
              {
                foundEnumTypes.Add(argType, null);
                missedKindTypesCount++;
              }
              else
              {
                foundEnumTypes.Add(argType, modelType);
                foundKindTypesCount++;
                foreach (var origEnumVal in argType.GetEnumValues())
                {
                  var enumValueType = typeof(EnumValue<>).MakeGenericType(argType);
                  Assert.That(enumValueType, Is.Not.Null);
                  if (enumValueType != null)
                  {
                    var origEnumValue = enumValueType.GetConstructor(new[] { argType })?.Invoke(new[] { origEnumVal });
                    Assert.That(origEnumValue, Is.Not.Null);
                    if (origEnumValue != null)
                    {
                      var convertToModelMethod = typeof(EnumValueConverter).GetMethod(nameof(EnumValueConverter.GetValue));
                      Assert.That(convertToModelMethod, Is.Not.Null);
                      var convertFromModelMethod = typeof(EnumValueConverter).GetMethod(nameof(EnumValueConverter.CreateEnumValue));
                      Assert.That(convertFromModelMethod, Is.Not.Null);
                      if (convertToModelMethod != null && convertFromModelMethod != null)
                        if (convertToModelMethod.ContainsGenericParameters)
                        {
                          // var modelEnumValue = EnumValueConverter.CreateModelElement<argType, modelType>(origEnumVal);
                          var convertToModelGenericMethod = convertToModelMethod.MakeGenericMethod(argType, modelType);
                          var modelEnumValue = convertToModelGenericMethod.Invoke(null, new[] { origEnumValue });
                          Assert.That(modelEnumValue, Is.Not.Null);
                          if (modelEnumValue != null)
                          {
                            // var elementEnumValue = EnumValueConverter.CreateOpenXmlElement<argType, modelType>(origEnumVal);
                            var convertFromModelGenericMethod = convertFromModelMethod.MakeGenericMethod(argType, modelType);
                            var convEnumValue = convertFromModelGenericMethod.Invoke(null, new[] { modelEnumValue });
                            Assert.That(convEnumValue, Is.Not.Null);
                            if (convEnumValue != null)
                            {
                              Assert.That(convEnumValue.GetType, Is.EqualTo(origEnumValue.GetType()));
                              var convEnumVal = convEnumValue.GetType()?.GetProperty("Type")?.GetValue(convEnumValue);
                              Assert.That(convEnumVal, Is.Not.Null);
                              if (convEnumVal != null) Assert.That(convEnumVal, Is.EqualTo(origEnumVal));
                            }
                          }
                        }
                    }
                  }
                }
              }
            }
        }
      }
    }
    WriteLine($"Found enum kind types = {foundKindTypesCount}");
    WriteLine($"Missed enum kind types = {missedKindTypesCount}");
    var foundTypesList = foundEnumTypes.Where(item => item.Value != null).Select(item => $"{item.Key.FullName} --> {item.Value?.FullName}").OrderBy(item => item).ToList();
    var missedTypesList = foundEnumTypes.Where(item => item.Value == null).Select(item => $"{item.Key.FullName}").OrderBy(item => item).ToList();
    WriteLine(new string('-', 20));
    WriteLine($"Found:");
    foreach (var foundType in foundTypesList)
      WriteLine(foundType);
    WriteLine(new string('-', 20));
    WriteLine($"Missed:");
    foreach (var foundType in missedTypesList)
      WriteLine(foundType);
  }

  /// <summary>
  /// Test of the hex-int value converter.
  /// Tests all docx files in the folder specified by test path.
  /// </summary>
  [Test]
  public void TestHexIntConverter()
  {
    foreach (var filename in Directory.EnumerateFiles(TestPath, "*.docx"))
      TestHexIntConverter(filename);
  }

  /// <summary>
  /// Test of the hex-int value converter based on the specified docx file.
  /// </summary>
  public void TestHexIntConverter(string filename, bool showDetails = false)
  {
    WriteLine(filename);
    var reader = new DocxReader(filename);
    TestHexIntConverterOfExtendendProperties(reader.WordprocessingDocument, showDetails);
    TestHexIntConverterOfNumberingDefinitions(reader.WordprocessingDocument, showDetails);
  }

  /// <summary>
  /// Tests the hex-int converter of extendend document properties (Rsids).
  /// </summary>
  /// <param name="wordprocessingDocument">The wordprocessing document.</param>
  /// <param name="showDetails">if set to <c>true</c> [show details].</param>
  public void TestHexIntConverterOfExtendendProperties(WordprocessingDocument wordprocessingDocument, bool showDetails = false)
  {
    //DocumentFormat.OpenXml.Wordprocessing.Style.Rsid
    //DocumentFormat.OpenXml.Wordprocessing.Rsids.RsidRoot
    var origRsIds = wordprocessingDocument.MainDocumentPart?.DocumentSettingsPart?.Settings.GetFirstChild<DXW.Rsids>();
    if (origRsIds != null)
    {
      if (showDetails)
        WriteLine("Rsids:");
      var origId = origRsIds.RsidRoot;
      if (showDetails)
        WriteLine($"  RsidRoot={origRsIds.RsidRoot?.Val?.Value}");
      var modelId = HexIntConverter.GetValue(origId);
      var backId = HexIntConverter.CreateOpenXmlElement<RsidRoot>(modelId);
      Assert.That(backId?.Val?.Value, Is.EqualTo(origId?.Val?.Value));

      foreach (var origId1 in origRsIds.Elements<Rsid>())
      {
        if (showDetails)
          WriteLine($"   Rsid={origId1?.Val?.Value}");
        var modelId1 = HexIntConverter.GetValue(origId1);
        var backId1 = HexIntConverter.CreateOpenXmlElement<Rsid>(modelId1);
        Assert.That(backId1?.Val?.Value, Is.EqualTo(origId1?.Val?.Value));
      }
    }
  }

  /// <summary>
  /// Tests the hex-int converter of document numbering definitions.
  /// </summary>
  /// <param name="wordprocessingDocument">The wordprocessing document.</param>
  /// <param name="showDetails">if set to <c>true</c> [show details].</param>
  public void TestHexIntConverterOfNumberingDefinitions(WordprocessingDocument wordprocessingDocument, bool showDetails = false)
  {
    //DocumentFormat.OpenXml.Wordprocessing.AbstractNum.Nsid
    //DocumentFormat.OpenXml.Wordprocessing.AbstractNum.TemplateCode
    var origNumDefs = wordprocessingDocument.MainDocumentPart?.NumberingDefinitionsPart?.Numbering?.Elements<AbstractNum>();
    if (origNumDefs != null)
    {
      if (showDetails)
        WriteLine("AbstractNums:");
      foreach (var item in origNumDefs)
      {
        if (showDetails)
          WriteLine($"   Nsid={item.Nsid?.Val?.Value}  TemplateCode={item.TemplateCode?.Val?.Value}");
        var origId1 = item.Nsid;
        var modelId1 = HexIntConverter.GetValue(origId1);
        var backId1 = HexIntConverter.CreateOpenXmlElement<Nsid>(modelId1);
        Assert.That(backId1?.Val?.Value, Is.EqualTo(origId1?.Val?.Value));
        var origId2 = item.TemplateCode;
        var modelId2 = HexIntConverter.GetValue(origId2);
        var backId2 = HexIntConverter.CreateOpenXmlElement<TemplateCode>(modelId2);
        Assert.That(backId2?.Val?.Value, Is.EqualTo(origId2?.Val?.Value));
      }
    }
  }

  /// <summary>
  /// Test of the hexadecimal binary converter.
  /// </summary>
  [Test]
  public void TestHexBinaryConverter()
  {
    TestHexBinaryConverter(false);
  }

  /// <summary>
  /// Test of the hexadecimal binary converter.
  /// Tests all docx files in the folder specified by test path.
  /// </summary>
  /// <param name="showDetails">Specifies if test details should be shown.</param>
  public void TestHexBinaryConverter(bool showDetails)
  {
    foreach (var filename in Directory.EnumerateFiles(TestPath, "*.docx"))
      TestHexBinaryConverter(filename, showDetails);
  }

  /// <summary>
  /// Helper method to find all the types that have properties of HexBinaryValue type.
  /// </summary>
  public void FindHexBinaryGetTypes()
  {
    var modelAssembly = Assembly.Load("DocumentModel");
    var sourceAssembly = Assembly.Load("DocumentFormat.OpenXml");
    foreach (var type in sourceAssembly.GetTypes())
    {
      foreach (var prop in type.GetProperties())
      {
        var propType = prop.PropertyType;
        if (propType.IsEqualOrSubclassOf(typeof(DocumentFormat.OpenXml.HexBinaryValue)))
        {
          WriteLine($"{type}.{prop.Name}");
        }
      }
    }
  }

  /// <summary>
  /// Test of the hexadecimal binary converter using a specified docx file.
  /// </summary>
  /// <param name="filename">The filename of docx to test.</param>
  /// <param name="showDetails">Specifies if test details should be shown.</param>
  public void TestHexBinaryConverter(string filename, bool showDetails = false)
  {
    //DocumentFormat.OpenXml.Presentation.Font.Panose
    //DocumentFormat.OpenXml.Office2019.Word.Cid.CommentId.ParaId
    //DocumentFormat.OpenXml.Office2019.Word.Cid.CommentId.DurableId
    //DocumentFormat.OpenXml.Office2021.Word.CommentsExt.CommentExtensible.DurableId
    //DocumentFormat.OpenXml.Office2010.Word.RgbColorModelHex.Val
    //DocumentFormat.OpenXml.Office2010.Word.DocumentId.Val
    //DocumentFormat.OpenXml.Office2010.Word.CheckedState.Val
    //DocumentFormat.OpenXml.Office2010.Word.UncheckedState.Val
    //DocumentFormat.OpenXml.Office2010.Word.CheckBoxSymbolType.Val
    //DocumentFormat.OpenXml.Office2010.Excel.SeriesColor.Rgb
    //DocumentFormat.OpenXml.Office2010.Excel.NegativeColor.Rgb
    //DocumentFormat.OpenXml.Office2010.Excel.AxisColor.Rgb
    //DocumentFormat.OpenXml.Office2010.Excel.MarkersColor.Rgb
    //DocumentFormat.OpenXml.Office2010.Excel.FirstMarkerColor.Rgb
    //DocumentFormat.OpenXml.Office2010.Excel.LastMarkerColor.Rgb
    //DocumentFormat.OpenXml.Office2010.Excel.HighMarkerColor.Rgb
    //DocumentFormat.OpenXml.Office2010.Excel.LowMarkerColor.Rgb
    //DocumentFormat.OpenXml.Office2010.Excel.Color.Rgb
    //DocumentFormat.OpenXml.Office2010.Excel.FillColor.Rgb
    //DocumentFormat.OpenXml.Office2010.Excel.BorderColor.Rgb
    //DocumentFormat.OpenXml.Office2010.Excel.NegativeFillColor.Rgb
    //DocumentFormat.OpenXml.Office2010.Excel.NegativeBorderColor.Rgb
    //DocumentFormat.OpenXml.Office2010.Excel.BarAxisColor.Rgb
    //DocumentFormat.OpenXml.Office2010.Excel.ColorType.Rgb
    //DocumentFormat.OpenXml.Office2010.Excel.ProtectedRange.Password
    //DocumentFormat.OpenXml.Wordprocessing.TableLook.Val
    //DocumentFormat.OpenXml.Wordprocessing.SymbolChar.Char
    //DocumentFormat.OpenXml.Wordprocessing.EmbeddedObject.AnchorId
    //DocumentFormat.OpenXml.Wordprocessing.Picture.AnchorId
    //DocumentFormat.OpenXml.Wordprocessing.Run.RsidRunProperties
    //DocumentFormat.OpenXml.Wordprocessing.Run.RsidRunDeletion
    //DocumentFormat.OpenXml.Wordprocessing.Run.RsidRunAddition
    //DocumentFormat.OpenXml.Wordprocessing.Paragraph.RsidParagraphMarkRevision
    //DocumentFormat.OpenXml.Wordprocessing.Paragraph.RsidParagraphAddition
    //DocumentFormat.OpenXml.Wordprocessing.Paragraph.RsidParagraphDeletion
    //DocumentFormat.OpenXml.Wordprocessing.Paragraph.RsidParagraphProperties
    //DocumentFormat.OpenXml.Wordprocessing.Paragraph.RsidRunAdditionDefault
    //DocumentFormat.OpenXml.Wordprocessing.Paragraph.ParagraphId
    //DocumentFormat.OpenXml.Wordprocessing.Paragraph.TextId
    //DocumentFormat.OpenXml.Wordprocessing.TableRow.RsidTableRowMarkRevision
    //DocumentFormat.OpenXml.Wordprocessing.TableRow.RsidTableRowAddition
    //DocumentFormat.OpenXml.Wordprocessing.TableRow.RsidTableRowDeletion
    //DocumentFormat.OpenXml.Wordprocessing.TableRow.RsidTableRowProperties
    //DocumentFormat.OpenXml.Wordprocessing.TableRow.ParagraphId
    //DocumentFormat.OpenXml.Wordprocessing.TableRow.TextId
    //DocumentFormat.OpenXml.Wordprocessing.PreviousSectionProperties.RsidRPr
    //DocumentFormat.OpenXml.Wordprocessing.PreviousSectionProperties.RsidDel
    //DocumentFormat.OpenXml.Wordprocessing.PreviousSectionProperties.RsidR
    //DocumentFormat.OpenXml.Wordprocessing.PreviousSectionProperties.RsidSect
    //DocumentFormat.OpenXml.Wordprocessing.SectionProperties.RsidRPr
    //DocumentFormat.OpenXml.Wordprocessing.SectionProperties.RsidDel
    //DocumentFormat.OpenXml.Wordprocessing.SectionProperties.RsidR
    //DocumentFormat.OpenXml.Wordprocessing.SectionProperties.RsidSect
    //DocumentFormat.OpenXml.Wordprocessing.RsidRoot.Val
    //DocumentFormat.OpenXml.Wordprocessing.Rsid.Val
    //DocumentFormat.OpenXml.Wordprocessing.Nsid.Val
    //DocumentFormat.OpenXml.Wordprocessing.TemplateCode.Val
    //DocumentFormat.OpenXml.Wordprocessing.LongHexNumberType.Val
    //DocumentFormat.OpenXml.Wordprocessing.Level.TemplateCode
    //DocumentFormat.OpenXml.Wordprocessing.WriteProtection.AlgorithmIdExtensibility
    //DocumentFormat.OpenXml.Wordprocessing.WriteProtection.CryptographicProviderTypeExtensibility
    //DocumentFormat.OpenXml.Wordprocessing.StylePaneFormatFilter.Val
    //DocumentFormat.OpenXml.Wordprocessing.DocumentProtection.AlgorithmIdExtensibility
    //DocumentFormat.OpenXml.Wordprocessing.DocumentProtection.CryptographicProviderTypeExtensibility
    //DocumentFormat.OpenXml.Wordprocessing.Panose1Number.Val
    //DocumentFormat.OpenXml.Wordprocessing.FontSignature.UnicodeSignature0
    //DocumentFormat.OpenXml.Wordprocessing.FontSignature.UnicodeSignature1
    //DocumentFormat.OpenXml.Wordprocessing.FontSignature.UnicodeSignature2
    //DocumentFormat.OpenXml.Wordprocessing.FontSignature.UnicodeSignature3
    //DocumentFormat.OpenXml.Wordprocessing.FontSignature.CodePageSignature0
    //DocumentFormat.OpenXml.Wordprocessing.FontSignature.CodePageSignature1
    //DocumentFormat.OpenXml.Spreadsheet.MissingItem.BackgroundColor
    //DocumentFormat.OpenXml.Spreadsheet.MissingItem.ForegroundColor
    //DocumentFormat.OpenXml.Spreadsheet.NumberItem.BackgroundColor
    //DocumentFormat.OpenXml.Spreadsheet.NumberItem.ForegroundColor
    //DocumentFormat.OpenXml.Spreadsheet.ErrorItem.BackgroundColor
    //DocumentFormat.OpenXml.Spreadsheet.ErrorItem.ForegroundColor
    //DocumentFormat.OpenXml.Spreadsheet.StringItem.BackgroundColor
    //DocumentFormat.OpenXml.Spreadsheet.StringItem.ForegroundColor
    //DocumentFormat.OpenXml.Spreadsheet.Color.Rgb
    //DocumentFormat.OpenXml.Spreadsheet.TabColor.Rgb
    //DocumentFormat.OpenXml.Spreadsheet.ForegroundColor.Rgb
    //DocumentFormat.OpenXml.Spreadsheet.BackgroundColor.Rgb
    //DocumentFormat.OpenXml.Spreadsheet.ColorType.Rgb
    //DocumentFormat.OpenXml.Spreadsheet.ProtectedRange.Password
    //DocumentFormat.OpenXml.Spreadsheet.MdxTuple.BackgroundColor
    //DocumentFormat.OpenXml.Spreadsheet.MdxTuple.ForegroundColor
    //DocumentFormat.OpenXml.Spreadsheet.RgbColor.Rgb
    //DocumentFormat.OpenXml.Spreadsheet.ChartSheetProtection.Password
    //DocumentFormat.OpenXml.Spreadsheet.SheetProtection.Password
    //DocumentFormat.OpenXml.Spreadsheet.FileSharing.ReservationPassword
    //DocumentFormat.OpenXml.Spreadsheet.WorkbookProtection.WorkbookPassword
    //DocumentFormat.OpenXml.Spreadsheet.WorkbookProtection.RevisionsPassword
    //DocumentFormat.OpenXml.Office.Word.FixedCommandKeyboardCustomization.CommandIndex
    //DocumentFormat.OpenXml.Office.Word.FixedCommandKeyboardCustomization.Argument
    //DocumentFormat.OpenXml.Office.Word.CharacterInsertion.Val
    //DocumentFormat.OpenXml.Office.Word.KeyMapEntry.CharacterMapPrimary
    //DocumentFormat.OpenXml.Office.Word.KeyMapEntry.CharacterMapSecondary
    //DocumentFormat.OpenXml.Office.Word.KeyMapEntry.KeyCodePrimary
    //DocumentFormat.OpenXml.Office.Word.KeyMapEntry.KeyCodeSecondary
    //DocumentFormat.OpenXml.Office.Word.AllocatedCommand.CommandIndexBasedOn
    //DocumentFormat.OpenXml.Office.Word.Mcd.BEncrypt
    //DocumentFormat.OpenXml.Office.Word.Mcd.Cmg
    //DocumentFormat.OpenXml.Office2016.Word.Symex.SymEx.Char
    //DocumentFormat.OpenXml.Drawing.RgbColorModelHex.Val
    //DocumentFormat.OpenXml.Drawing.SystemColor.LastColor
    //DocumentFormat.OpenXml.Drawing.BulletFont.Panose
    //DocumentFormat.OpenXml.Drawing.LatinFont.Panose
    //DocumentFormat.OpenXml.Drawing.EastAsianFont.Panose
    //DocumentFormat.OpenXml.Drawing.ComplexScriptFont.Panose
    //DocumentFormat.OpenXml.Drawing.SymbolFont.Panose
    //DocumentFormat.OpenXml.Drawing.TextFontType.Panose
    //DocumentFormat.OpenXml.Drawing.Wordprocessing.Inline.AnchorId
    //DocumentFormat.OpenXml.Drawing.Wordprocessing.Inline.EditId
    //DocumentFormat.OpenXml.Drawing.Wordprocessing.Anchor.EditId
    //DocumentFormat.OpenXml.Drawing.Wordprocessing.Anchor.AnchorId
    //DocumentFormat.OpenXml.Office2013.Excel.PivotValueCellExtra.BackgroundColor
    //DocumentFormat.OpenXml.Office2013.Excel.PivotValueCellExtra.ForegroundColor
    //DocumentFormat.OpenXml.Office2013.Word.CommentEx.ParaId
    //DocumentFormat.OpenXml.Office2013.Word.CommentEx.ParaIdParent
    WriteLine(filename);
    var reader = new DocxReader(filename);
    TestHexBinaryConverterInFontTable(reader.WordprocessingDocument, showDetails);
    TestHexBinaryConverterInParagraphs(reader.WordprocessingDocument, showDetails);
  }

  /// <summary>
  /// Test of the hexadecimal binary converter working in document font table.
  /// Tests Panose1Number and FondSignature components.
  /// </summary>
  /// <param name="wordprocessingDocument">The wordprocessing document to test.</param>
  /// <param name="showDetails">Specifies if test details should be shown.</param>
  public void TestHexBinaryConverterInFontTable(WordprocessingDocument wordprocessingDocument, bool showDetails = false)
  {
    //DocumentFormat.OpenXml.Wordprocessing.Panose1Number.Val
    //DocumentFormat.OpenXml.Wordprocessing.FontSignature.UnicodeSignature0
    //DocumentFormat.OpenXml.Wordprocessing.FontSignature.UnicodeSignature1
    //DocumentFormat.OpenXml.Wordprocessing.FontSignature.UnicodeSignature2
    //DocumentFormat.OpenXml.Wordprocessing.FontSignature.UnicodeSignature3
    //DocumentFormat.OpenXml.Wordprocessing.FontSignature.CodePageSignature0
    //DocumentFormat.OpenXml.Wordprocessing.FontSignature.CodePageSignature1
    var origFontDefs = wordprocessingDocument.MainDocumentPart?.FontTablePart?.Fonts?.Elements<DocumentFormat.OpenXml.Wordprocessing.Font>();
    if (origFontDefs != null)
    {
      if (showDetails)
        WriteLine("Fonts:");
      foreach (var item in origFontDefs)
      {
        if (item.FontSignature != null)
        {
          if (showDetails)
            WriteLine($"  usb0={item.FontSignature.UnicodeSignature0}" +
                      $"  usb1={item.FontSignature.UnicodeSignature1}" +
                      $"  usb2={item.FontSignature.UnicodeSignature2}" +
                      $"  usb3={item.FontSignature.UnicodeSignature3}" +
                      $"  csb0={item.FontSignature.CodePageSignature0}" +
                      $"  csb1={item.FontSignature.CodePageSignature1}" +
                      $"  Panose1={item.Panose1Number?.Val?.Value}");
          var origValue0 = item.FontSignature.UnicodeSignature0;
          var modelValue0 = HexBinaryConverter.GetValue(origValue0);
          var backValue0 = HexBinaryConverter.CreateValue<HexBinaryValue>(modelValue0);
          Assert.That(backValue0, Is.EqualTo(origValue0));
          var origValue1 = item.FontSignature.UnicodeSignature1;
          var modelValue1 = HexBinaryConverter.GetValue(origValue1);
          var backValue1 = HexBinaryConverter.CreateValue<HexBinaryValue>(modelValue1);
          Assert.That(backValue1, Is.EqualTo(origValue1));
          var origValue2 = item.FontSignature.UnicodeSignature2;
          var modelValue2 = HexBinaryConverter.GetValue(origValue2);
          var backValue2 = HexBinaryConverter.CreateValue<HexBinaryValue>(modelValue2);
          Assert.That(backValue2, Is.EqualTo(origValue2));
          var origValue3 = item.FontSignature.UnicodeSignature3;
          var modelValue3 = HexBinaryConverter.GetValue(origValue3);
          var backValue3 = HexBinaryConverter.CreateValue<HexBinaryValue>(modelValue3);
          Assert.That(backValue3, Is.EqualTo(origValue3));
          var origValue5 = item.FontSignature.CodePageSignature0;
          var modelValue5 = HexBinaryConverter.GetValue(origValue5);
          var backValue5 = HexBinaryConverter.CreateValue<HexBinaryValue>(modelValue5);
          Assert.That(backValue5, Is.EqualTo(origValue5));
          var origValue6 = item.FontSignature.CodePageSignature1;
          var modelValue6 = HexBinaryConverter.GetValue(origValue6);
          var backValue6 = HexBinaryConverter.CreateValue<HexBinaryValue>(modelValue6);
          Assert.That(backValue6, Is.EqualTo(origValue6));
        }
        var origValue7 = item.Panose1Number?.Val?.Value;
        var modelValue7 = HexBinaryConverter.GetValue(origValue7);
        var backValue7 = HexBinaryConverter.CreateOpenXmlElement<Panose1Number>(modelValue7);
        Assert.That(backValue7?.Val?.Value, Is.EqualTo(origValue7));
      }
    }
  }

  /// <summary>
  /// Test of the hexadecimal binary converter working in document paragraphs.
  /// Tests paragpraph Rsid*, ParagraphId and TextId properties.
  /// </summary>
  /// <param name="wordprocessingDocument">The wordprocessing document to test.</param>
  /// <param name="showDetails">Specifies if test details should be shown.</param>
  public void TestHexBinaryConverterInParagraphs(WordprocessingDocument wordprocessingDocument, bool showDetails = false)
  {
    //DocumentFormat.OpenXml.Wordprocessing.Paragraph.RsidParagraphMarkRevision
    //DocumentFormat.OpenXml.Wordprocessing.Paragraph.RsidParagraphAddition
    //DocumentFormat.OpenXml.Wordprocessing.Paragraph.RsidParagraphDeletion
    //DocumentFormat.OpenXml.Wordprocessing.Paragraph.RsidParagraphProperties
    //DocumentFormat.OpenXml.Wordprocessing.Paragraph.RsidRunAdditionDefault
    //DocumentFormat.OpenXml.Wordprocessing.Paragraph.ParagraphId
    //DocumentFormat.OpenXml.Wordprocessing.Paragraph.TextId
    var origParagraphs = wordprocessingDocument.MainDocumentPart?.Document?.Body?.Elements<DocumentFormat.OpenXml.Wordprocessing.Paragraph>();
    if (origParagraphs != null)
    {
      if (showDetails)
        WriteLine("Paragraphs:");
      foreach (var item in origParagraphs)
      {
        if (showDetails)
          WriteLine($"  paraId={item.ParagraphId}" +
                    $"  rsidR={item.RsidParagraphAddition}" +
                    $"  rsidRPr={item.RsidParagraphMarkRevision}" +
                    $"  rsidDel={item.RsidParagraphDeletion}" +
                    $"  rsidP={item.RsidParagraphProperties}" +
                    $"  rsidRDefault={item.RsidRunAdditionDefault}");
        var origValue0 = item.ParagraphId;
        var modelValue0 = HexBinaryConverter.GetValue(origValue0);
        var backValue0 = HexBinaryConverter.CreateValue<HexBinaryValue>(modelValue0);
        Assert.That(backValue0, Is.EqualTo(origValue0));
        var origValue1 = item.RsidParagraphAddition;
        var modelValue1 = HexBinaryConverter.GetValue(origValue1);
        var backValue1 = HexBinaryConverter.CreateValue<HexBinaryValue>(modelValue1);
        Assert.That(backValue1, Is.EqualTo(origValue1));
        var origValue2 = item.RsidParagraphMarkRevision;
        var modelValue2 = HexBinaryConverter.GetValue(origValue2);
        var backValue2 = HexBinaryConverter.CreateValue<HexBinaryValue>(modelValue2);
        Assert.That(backValue2, Is.EqualTo(origValue2));
        var origValue3 = item.RsidParagraphDeletion;
        var modelValue3 = HexBinaryConverter.GetValue(origValue3);
        var backValue3 = HexBinaryConverter.CreateValue<HexBinaryValue>(modelValue3);
        Assert.That(backValue3, Is.EqualTo(origValue3));
        var origValue5 = item.RsidParagraphProperties;
        var modelValue5 = HexBinaryConverter.GetValue(origValue5);
        var backValue5 = HexBinaryConverter.CreateValue<HexBinaryValue>(modelValue5);
        Assert.That(backValue5, Is.EqualTo(origValue5));
      }
    }
  }


}
