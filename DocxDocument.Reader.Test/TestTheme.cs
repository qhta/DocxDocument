using System.Reflection;

using Qhta.Xml.Serialization;

namespace DocxDocument.Reader.Test;

public class TestTheme : TestBase
{

  [Test]
  public void TestNormalTemplateTheme()
  {
    var filename = Path.Combine(TestPath, "Normal.dotm");
    ReadTheme(filename, true);
  }

  [Test]
  public void TestDocumentTheme()
  {
    var filename = Path.Combine(TestPath, "DocumentProperties.docx");
    ReadTheme(filename, true);
  }

  [Test]
  public void TestCustomTheme()
  {
    var filename = Path.Combine(TestPath, "CustomProperties.docx");
    ReadTheme(filename, true);
  }

  [Test]
  public void TestSampleDocsTheme()
  {
    foreach (var filename in Directory.EnumerateFiles(TestPath, "*.docx"))
      ReadTheme(filename);
  }

  public virtual DMDraws.Theme ReadTheme(string filename, bool showDetails = false)
  {
    WriteLine(filename);
    var reader = new DocxReader(filename);
    var document = reader.ReadDocument(Parts.Theme);
    Assert.IsNotNull(document, "No document read");
    Assert.IsNotNull(document.Theme, "No document Theme read");
    //var modelTheme = document.Theme;
    //var modelThemeColors = document.Theme.ThemeElements?.ColorScheme?.ThemeColors;
    //int modelThemeColorsCount = modelThemeColors?.Count() ?? 0;
    //var modelThemeColors = reader.WordprocessingDocument.MainDocumentPart?.StyleDefinitionsPart?.Theme;
    //int origDefinedThemeCount = origDefinedTheme?.Elements<Style>().Count() ?? 0;
    //var diffs = new DiffList();
    //if (!ThemeConverter.CompareModelElement(origDefinedTheme, modelTheme, diffs, null))
    //  Assert.Fail(diffs.FirstOrDefault()?.ToString());

    //WriteLine($"  Document Defined Theme: found {modelDefinedThemeCount}, expected {origDefinedThemeCount}");
    //var modelLatentTheme = document.Theme.LatentTheme;
    //int modelLatentThemeCount = modelLatentTheme?.Count ?? 0;
    //var origLatentTheme = reader.WordprocessingDocument.MainDocumentPart?.StyleDefinitionsPart?.Theme?.LatentTheme;
    //int origLatentThemeCount = origLatentTheme?.Elements<LatentStyleExceptionInfo>().Count() ?? 0;
    //WriteLine($"  Document Lantent Theme: found {modelLatentThemeCount}, expected {origLatentThemeCount}");

    //Assert.That(modelDefinedThemeCount, Is.EqualTo(origDefinedThemeCount), "Invalid defined Theme count");
    //Assert.That(modelLatentThemeCount, Is.EqualTo(origLatentThemeCount), "Invalid latent Theme count");

    //var modelAllTheme = document.Theme.AllTheme;
    //var modelAllThemeCount = modelAllTheme.Count();
    //WriteLine($"  Document All Theme: found {modelAllThemeCount}");

    //var modelParaTheme = document.Theme.ParagraphTheme;
    //var modelParaThemeCount = modelParaTheme.Count();
    //var definedParaThemeCount = modelParaTheme.Count(item => item.IsDefined);
    //var customParaThemeCount = modelParaTheme.Count(item => item.IsCustom);
    //var validParaThemeCount = modelParaTheme.Count(item => item.IsValid);
    //WriteLine($"  Document Paragraph Theme: found {modelParaThemeCount}, defined {definedParaThemeCount}, custom {customParaThemeCount}, valid {validParaThemeCount}");
    //if (validParaThemeCount != definedParaThemeCount)
    //{
    //  WriteLine($"    Invalid Paragraph Theme:");
    //  int i = 0;
    //  foreach (var style in modelParaTheme.Where(item => item.IsDefined && !item.IsValid))
    //  {
    //    WriteLine($"      {++i}. {style.Name}");
    //  }
    //}

    //var modelCharTheme = document.Theme.CharacterTheme;
    //var modelCharThemeCount = modelCharTheme.Count();
    //var definedCharThemeCount = modelCharTheme.Count(item => item.IsDefined);
    //var customCharThemeCount = modelCharTheme.Count(item => item.IsCustom);
    //var validCharThemeCount = modelCharTheme.Count(item => item.IsValid);
    //WriteLine($"  Document Character Theme: found {modelCharThemeCount}, defined {definedCharThemeCount}, custom {customCharThemeCount}, valid {validCharThemeCount}");
    //if (validCharThemeCount != definedCharThemeCount)
    //{
    //  WriteLine($"    Invalid Character Theme:");
    //  int i = 0;
    //  foreach (var style in modelCharTheme.Where(item => item.IsDefined && !item.IsValid))
    //  {
    //    WriteLine($"      {++i}. {style.Name} {style.StyleRunProperties} IsCustom={style.IsCustom} BasedOn={style.BasedOn} ");
    //  }
    //}

    //var modelTableTheme = document.Theme.TableTheme;
    //var modelTableThemeCount = modelTableTheme.Count();
    //var definedTableThemeCount = modelTableTheme.Count(item => item.IsDefined);
    //var customTableThemeCount = modelTableTheme.Count(item => item.IsCustom);
    //var validTableThemeCount = modelTableTheme.Count(item => item.IsValid);
    //WriteLine($"  Document Table Theme: found {modelTableThemeCount}, defined {definedTableThemeCount}, custom {customTableThemeCount}, valid {validTableThemeCount}");
    //if (validTableThemeCount != definedTableThemeCount)
    //{
    //  WriteLine($"    Invalid Table Theme:");
    //  int i = 0;
    //  foreach (var style in modelTableTheme.Where(item => item.IsDefined && !item.IsValid))
    //  {
    //    WriteLine($"      {++i}. {style.Name}");
    //  }
    //}

    //var modelNumTheme = document.Theme.NumberingTheme;
    //var modelNumThemeCount = modelNumTheme.Count();
    //var definedNumThemeCount = modelNumTheme.Count(item => item.IsDefined);
    //var customNumThemeCount = modelNumTheme.Count(item => item.IsCustom);
    //var validNumThemeCount = modelNumTheme.Count(item => item.IsValid);
    //WriteLine($"  Document Numbering Theme: found {modelNumThemeCount}, defined {definedNumThemeCount}, custom {customNumThemeCount}, valid {validNumThemeCount}");
    //if (validNumThemeCount < definedNumThemeCount)
    //{
    //  WriteLine($"    Invalid Number Theme:");
    //  int i = 0;
    //  foreach (var style in modelNumTheme.Where(item => item.IsDefined && !item.IsValid))
    //  {
    //    WriteLine($"      {++i}. {style.Name}");
    //  }
    //}

    //var totalThemeCount = modelParaThemeCount + modelCharThemeCount + modelTableThemeCount + modelNumThemeCount;
    //var totalValidThemeCount = validParaThemeCount + validCharThemeCount + validTableThemeCount + validNumThemeCount;
    //var totalDefinedThemeCount = definedParaThemeCount + definedCharThemeCount + definedTableThemeCount + definedNumThemeCount;

    //var totalStyleIds = document.Theme.StyleIndex.Count;
    //WriteLine($"  Document Style Ids: found {totalStyleIds}, expected {totalDefinedThemeCount}");
    //if (totalStyleIds != totalDefinedThemeCount)
    //{
    //  WriteLine($"    Theme with no Id:");
    //  int i = 0;
    //  foreach (var style in modelAllTheme.Where(item => item.IsDefined && item.StyleId == null))
    //  {
    //    WriteLine($"      {++i}. {style.Name}");
    //  }
    //}

    //Assert.That(totalThemeCount, Is.EqualTo(modelAllThemeCount), "Invalid total Theme count");
    //Assert.That(totalValidThemeCount, Is.GreaterThanOrEqualTo(totalDefinedThemeCount), "Invalid defined Theme found");
    //Assert.That(totalStyleIds, Is.EqualTo(totalDefinedThemeCount), "Invalid style Ids count");

    //TestDocDefaults(document.Theme.DocDefaults, reader.WordprocessingDocument.MainDocumentPart?.StyleDefinitionsPart?.Theme?.DocDefaults);

    return document.Theme;
  }

  private void TestDocDefaults(DMW.DocDefaults? modelDocDefaults, DXW.DocDefaults? origDocDefaults)
  {
    if (origDocDefaults != null)
    {
      Assert.IsNotNull(modelDocDefaults, "DocDefaults is null");
      TestParagraphPropertiesDefault(modelDocDefaults.ParagraphPropertiesDefault, origDocDefaults.ParagraphPropertiesDefault);
      TestRunPropertiesDefault(modelDocDefaults.RunPropertiesDefault, origDocDefaults.RunPropertiesDefault);
    }
  }

  private void TestParagraphPropertiesDefault(DMW.ParagraphPropertiesDefault? modelParPropsDefaults,
    DXW.ParagraphPropertiesDefault? origParPropsDefaults)
  {
    if (origParPropsDefaults != null)
    {
      Assert.IsNotNull(modelParPropsDefaults, "ParagraphPropertiesDefault is null");
      var diffs = new DMX.DiffList();
      if (!DMXW.ParagraphPropertiesDefaultConverter.CompareModelElement(origParPropsDefaults, modelParPropsDefaults, diffs, null))
        Assert.Fail(diffs.FirstOrDefault()?.ToString());
    }
  }

  private void TestRunPropertiesDefault(DMW.RunPropertiesDefault? modelRunPropsDefaults,
    DXW.RunPropertiesDefault? origRunPropsDefaults)
  {
    if (origRunPropsDefaults != null)
    {
      Assert.IsNotNull(modelRunPropsDefaults, "RunPropertiesDefault is null");
      var diffs = new DMX.DiffList();
      if (!DMXW.RunPropertiesDefaultConverter.CompareModelElement(origRunPropsDefaults, modelRunPropsDefaults, diffs, null))
        Assert.Fail(diffs.FirstOrDefault()?.ToString());
    }
  }

  [Test]
  public void TestThemeXmlSerialization()
  {
    var extraTypes = Assembly.Load("DocumentModel").GetTypes()
      .Where(item => item.IsPublic && !item.IsGenericType).ToArray();

    var filename = Path.Combine(TestPath, "CustomProperties.docx");
    var reader = new DocxReader(filename);
    var document = reader.ReadDocument(Parts.Theme);
    DMDraws.Theme oldTheme = document.Theme ?? new DMDraws.Theme();//TestReadProperties(filename, true);
    Assert.IsNotNull(oldTheme, "No document theme read");
    if (oldTheme == null)
      return;
    var textWriter = new StringWriter();
    var serializer = new QXmlSerializer(typeof(DMDraws.Theme), extraTypes.ToArray(),
      new SerializationOptions { AcceptAllProperties = true });
    serializer.Serialize(textWriter, oldTheme);
    textWriter.Flush();
    string str = textWriter.ToString();
    WriteLine(str);
    WriteLine();

    //var textReader = new StringReader(str);
    //var newProperties = (DocumentProperties?)serializer.Deserialize(textReader);
    //Assert.IsNotNull(newProperties, $"Deserialized properties are null");
    //var oldPropertiesCount = oldTheme.Count;
    //var newPropertiesCount = newProperties.Count();
    //var newPropArray = newProperties.ToArray();
    //var oldPropArray = oldTheme.ToArray();
    //for (int i = 0; i < Math.Min(oldPropertiesCount, newPropertiesCount); i++)
    //{
    //  if (newPropArray[i].Name == "HeadingPairs")
    //    Debug.Assert(true);
    //  Assert.That(newPropArray[i], Is.EqualTo(oldPropArray[i]), $"Deserialized property \"{newPropArray[i].Name}\" different for original");
    //}
    //Assert.That(newPropertiesCount, Is.EqualTo(oldPropertiesCount), $"Deserialized properties count different for original");
  }

}
