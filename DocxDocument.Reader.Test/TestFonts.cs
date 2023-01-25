using DocumentFormat.OpenXml.Wordprocessing;

using DocumentModel;
using DocumentModel.OpenXml;
using DocumentModel.OpenXml.Wordprocessing;
using DMW = DocumentModel.Wordprocessing;
using DXW = DocumentFormat.OpenXml.Wordprocessing;

namespace DocxDocument.Reader.Test;

public class TestFonts : TestBase
{

  [Test]
  public void TestNormalTemplateFonts()
  {
    var filename = Path.Combine(TestPath, "Normal.dotm");
    ReadFonts(filename, true);
  }

  [Test]
  public void TestDocumentFonts()
  {
    var filename = Path.Combine(TestPath, "DocumentProperties.docx");
    ReadFonts(filename, true);
  }

  [Test]
  public void TestCustomFonts()
  {
    var filename = Path.Combine(TestPath, "CustomProperties.docx");
    ReadFonts(filename, true);
  }

  [Test]
  public void TestSampleDocsFonts()
  {
    foreach (var filename in Directory.EnumerateFiles(TestPath, "*.docx"))
      ReadFonts(filename);
  }

  public virtual DMW.Fonts ReadFonts(string filename, bool showDetails = false)
  {
    WriteLine(filename);
    var reader = new DocxReader(filename);
    var document = reader.ReadDocument(Parts.StyleDefinitions);
    Assert.IsNotNull(document, "No document read");
    Assert.IsNotNull(document.Fonts, "No document fonts read");
    //var modelFonts = document.Fonts;
    //var modelDefinedFonts = document.Fonts.DefinedFonts;
    //int modelDefinedFontsCount = modelDefinedFonts?.Count() ?? 0;
    //var origDefinedFonts = reader.WordprocessingDocument.MainDocumentPart?.StyleDefinitionsPart?.Fonts;
    //int origDefinedFontsCount = origDefinedFonts?.Elements<Style>().Count() ?? 0;
    //var diffs = new DiffList();
    //var ok = FontsConverter.CompareModelElement(origDefinedFonts, modelFonts, diffs, null);
    //if (!ok)
    //  Assert.Fail(diffs.FirstOrDefault()?.ToString());

    //WriteLine($"  Document Defined Fonts: found {modelDefinedFontsCount}, expected {origDefinedFontsCount}");
    //var modelLatentFonts = document.Fonts.LatentFonts;
    //int modelLatentFontsCount = modelLatentFonts?.Count ?? 0;
    //var origLatentFonts = reader.WordprocessingDocument.MainDocumentPart?.StyleDefinitionsPart?.Fonts?.LatentFonts;
    //int origLatentFontsCount = origLatentFonts?.Elements<LatentStyleExceptionInfo>().Count() ?? 0;
    //WriteLine($"  Document Lantent Fonts: found {modelLatentFontsCount}, expected {origLatentFontsCount}");

    //Assert.That(modelDefinedFontsCount, Is.EqualTo(origDefinedFontsCount), "Invalid defined Fonts count");
    //Assert.That(modelLatentFontsCount, Is.EqualTo(origLatentFontsCount), "Invalid latent Fonts count");

    //var modelAllFonts = document.Fonts.AllFonts;
    //var modelAllFontsCount = modelAllFonts.Count();
    //WriteLine($"  Document All Fonts: found {modelAllFontsCount}");

    //var modelParaFonts = document.Fonts.ParagraphFonts;
    //var modelParaFontsCount = modelParaFonts.Count();
    //var definedParaFontsCount = modelParaFonts.Count(item => item.IsDefined);
    //var customParaFontsCount = modelParaFonts.Count(item => item.IsCustom);
    //var validParaFontsCount = modelParaFonts.Count(item => item.IsValid);
    //WriteLine($"  Document Paragraph Fonts: found {modelParaFontsCount}, defined {definedParaFontsCount}, custom {customParaFontsCount}, valid {validParaFontsCount}");
    //if (validParaFontsCount != definedParaFontsCount)
    //{
    //  WriteLine($"    Invalid Paragraph Fonts:");
    //  int i = 0;
    //  foreach (var style in modelParaFonts.Where(item => item.IsDefined && !item.IsValid))
    //  {
    //    WriteLine($"      {++i}. {style.Name}");
    //  }
    //}

    //var modelCharFonts = document.Fonts.CharacterFonts;
    //var modelCharFontsCount = modelCharFonts.Count();
    //var definedCharFontsCount = modelCharFonts.Count(item => item.IsDefined);
    //var customCharFontsCount = modelCharFonts.Count(item => item.IsCustom);
    //var validCharFontsCount = modelCharFonts.Count(item => item.IsValid);
    //WriteLine($"  Document Character Fonts: found {modelCharFontsCount}, defined {definedCharFontsCount}, custom {customCharFontsCount}, valid {validCharFontsCount}");
    //if (validCharFontsCount != definedCharFontsCount)
    //{
    //  WriteLine($"    Invalid Character Fonts:");
    //  int i = 0;
    //  foreach (var style in modelCharFonts.Where(item => item.IsDefined && !item.IsValid))
    //  {
    //    WriteLine($"      {++i}. {style.Name} {style.StyleRunProperties} IsCustom={style.IsCustom} BasedOn={style.BasedOn} ");
    //  }
    //}

    //var modelTableFonts = document.Fonts.TableFonts;
    //var modelTableFontsCount = modelTableFonts.Count();
    //var definedTableFontsCount = modelTableFonts.Count(item => item.IsDefined);
    //var customTableFontsCount = modelTableFonts.Count(item => item.IsCustom);
    //var validTableFontsCount = modelTableFonts.Count(item => item.IsValid);
    //WriteLine($"  Document Table Fonts: found {modelTableFontsCount}, defined {definedTableFontsCount}, custom {customTableFontsCount}, valid {validTableFontsCount}");
    //if (validTableFontsCount != definedTableFontsCount)
    //{
    //  WriteLine($"    Invalid Table Fonts:");
    //  int i = 0;
    //  foreach (var style in modelTableFonts.Where(item => item.IsDefined && !item.IsValid))
    //  {
    //    WriteLine($"      {++i}. {style.Name}");
    //  }
    //}

    //var modelNumFonts = document.Fonts.NumberingFonts;
    //var modelNumFontsCount = modelNumFonts.Count();
    //var definedNumFontsCount = modelNumFonts.Count(item => item.IsDefined);
    //var customNumFontsCount = modelNumFonts.Count(item => item.IsCustom);
    //var validNumFontsCount = modelNumFonts.Count(item => item.IsValid);
    //WriteLine($"  Document Numbering Fonts: found {modelNumFontsCount}, defined {definedNumFontsCount}, custom {customNumFontsCount}, valid {validNumFontsCount}");
    //if (validNumFontsCount < definedNumFontsCount)
    //{
    //  WriteLine($"    Invalid Number Fonts:");
    //  int i = 0;
    //  foreach (var style in modelNumFonts.Where(item => item.IsDefined && !item.IsValid))
    //  {
    //    WriteLine($"      {++i}. {style.Name}");
    //  }
    //}

    //var totalFontsCount = modelParaFontsCount + modelCharFontsCount + modelTableFontsCount + modelNumFontsCount;
    //var totalValidFontsCount = validParaFontsCount + validCharFontsCount + validTableFontsCount + validNumFontsCount;
    //var totalDefinedFontsCount = definedParaFontsCount + definedCharFontsCount + definedTableFontsCount + definedNumFontsCount;

    //var totalStyleIds = document.Fonts.StyleIndex.Count;
    //WriteLine($"  Document Style Ids: found {totalStyleIds}, expected {totalDefinedFontsCount}");
    //if (totalStyleIds != totalDefinedFontsCount)
    //{
    //  WriteLine($"    Fonts with no Id:");
    //  int i = 0;
    //  foreach (var style in modelAllFonts.Where(item => item.IsDefined && item.StyleId == null))
    //  {
    //    WriteLine($"      {++i}. {style.Name}");
    //  }
    //}

    //Assert.That(totalFontsCount, Is.EqualTo(modelAllFontsCount), "Invalid total Fonts count");
    //Assert.That(totalValidFontsCount, Is.GreaterThanOrEqualTo(totalDefinedFontsCount), "Invalid defined Fonts found");
    //Assert.That(totalStyleIds, Is.EqualTo(totalDefinedFontsCount), "Invalid style Ids count");

    //TestDocDefaults(document.Fonts.DocDefaults, reader.WordprocessingDocument.MainDocumentPart?.StyleDefinitionsPart?.Fonts?.DocDefaults);

    return document.Fonts;
  }

}
