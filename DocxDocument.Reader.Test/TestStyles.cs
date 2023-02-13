using System.Reflection;

using DocumentFormat.OpenXml.Wordprocessing;

using DocumentModel;
using DocumentModel.OpenXml;
using DocumentModel.OpenXml.Wordprocessing;

using Qhta.Xml.Serialization;

using DMW = DocumentModel.Wordprocessing;
using DXW = DocumentFormat.OpenXml.Wordprocessing;

namespace DocxDocument.Reader.Test;

public class TestStyles : TestBase
{

  [Test]
  public void TestNormalTemplateStyles()
  {
    var filename = Path.Combine(TestPath, "Normal.dotm");
    ReadStyles(filename, true);
  }

  [Test]
  public void TestDocumentStyles()
  {
    var filename = Path.Combine(TestPath, "DocumentProperties.docx");
    ReadStyles(filename, true);
  }

  [Test]
  public void TestCustomStyles()
  {
    var filename = Path.Combine(TestPath, "CustomProperties.docx");
    ReadStyles(filename, true);
  }

  [Test]
  public void TestSampleDocsStyles()
  {
    foreach (var filename in Directory.EnumerateFiles(TestPath, "*.docx"))
      ReadStyles(filename);
  }

  public virtual DMW.Styles ReadStyles(string filename, bool showDetails = false)
  {
    WriteLine(filename);
    var reader = new DocxReader(filename);
    var document = reader.ReadDocument(Parts.StyleDefinitions);
    Assert.IsNotNull(document, "No document read");
    Assert.IsNotNull(document.Styles, "No document styles read");
    var modelStyles = document.Styles;
    var modelDefinedStyles = document.Styles.DefinedStyles;
    int modelDefinedStylesCount = modelDefinedStyles?.Count() ?? 0;
    var origDefinedStyles = reader.WordprocessingDocument.MainDocumentPart?.StyleDefinitionsPart?.Styles;
    int origDefinedStylesCount = origDefinedStyles?.Elements<Style>().Count() ?? 0;
    var diffs = new DiffList();
    if (!StylesConverter.CompareModelElement(origDefinedStyles, modelStyles, diffs, null))
      Assert.Fail(diffs.FirstOrDefault()?.ToString());

    WriteLine($"  Document Defined Styles: found {modelDefinedStylesCount}, expected {origDefinedStylesCount}");
    var modelLatentStyles = document.Styles.LatentStyles;
    int modelLatentStylesCount = modelLatentStyles?.Count ?? 0;
    var origLatentStyles = reader.WordprocessingDocument.MainDocumentPart?.StyleDefinitionsPart?.Styles?.LatentStyles;
    int origLatentStylesCount = origLatentStyles?.Elements<LatentStyleExceptionInfo>().Count() ?? 0;
    WriteLine($"  Document Lantent Styles: found {modelLatentStylesCount}, expected {origLatentStylesCount}");

    Assert.That(modelDefinedStylesCount, Is.EqualTo(origDefinedStylesCount), "Invalid defined styles count");
    Assert.That(modelLatentStylesCount, Is.EqualTo(origLatentStylesCount), "Invalid latent styles count");

    var modelAllStyles = document.Styles.AllStyles;
    var modelAllStylesCount = modelAllStyles.Count();
    WriteLine($"  Document All Styles: found {modelAllStylesCount}");

    var modelParaStyles = document.Styles.ParagraphStyles;
    var modelParaStylesCount = modelParaStyles.Count();
    var definedParaStylesCount = modelParaStyles.Count(item => item.IsDefined);
    var customParaStylesCount = modelParaStyles.Count(item => item.IsCustom);
    var validParaStylesCount = modelParaStyles.Count(item => item.IsValid);
    WriteLine($"  Document Paragraph Styles: found {modelParaStylesCount}, defined {definedParaStylesCount}, custom {customParaStylesCount}, valid {validParaStylesCount}");
    if (validParaStylesCount != definedParaStylesCount)
    {
      WriteLine($"    Invalid Paragraph Styles:");
      int i = 0;
      foreach (var style in modelParaStyles.Where(item => item.IsDefined && !item.IsValid))
      {
        WriteLine($"      {++i}. {style.Name}");
      }
    }

    var modelCharStyles = document.Styles.CharacterStyles;
    var modelCharStylesCount = modelCharStyles.Count();
    var definedCharStylesCount = modelCharStyles.Count(item => item.IsDefined);
    var customCharStylesCount = modelCharStyles.Count(item => item.IsCustom);
    var validCharStylesCount = modelCharStyles.Count(item => item.IsValid);
    WriteLine($"  Document Character Styles: found {modelCharStylesCount}, defined {definedCharStylesCount}, custom {customCharStylesCount}, valid {validCharStylesCount}");
    if (validCharStylesCount != definedCharStylesCount)
    {
      WriteLine($"    Invalid Character Styles:");
      int i = 0;
      foreach (var style in modelCharStyles.Where(item => item.IsDefined && !item.IsValid))
      {
        WriteLine($"      {++i}. {style.Name} {style.StyleRunProperties} IsCustom={style.IsCustom} BasedOn={style.BasedOn} ");
      }
    }

    var modelTableStyles = document.Styles.TableStyles;
    var modelTableStylesCount = modelTableStyles.Count();
    var definedTableStylesCount = modelTableStyles.Count(item => item.IsDefined);
    var customTableStylesCount = modelTableStyles.Count(item => item.IsCustom);
    var validTableStylesCount = modelTableStyles.Count(item => item.IsValid);
    WriteLine($"  Document Table Styles: found {modelTableStylesCount}, defined {definedTableStylesCount}, custom {customTableStylesCount}, valid {validTableStylesCount}");
    if (validTableStylesCount != definedTableStylesCount)
    {
      WriteLine($"    Invalid Table Styles:");
      int i = 0;
      foreach (var style in modelTableStyles.Where(item => item.IsDefined && !item.IsValid))
      {
        WriteLine($"      {++i}. {style.Name}");
      }
    }

    var modelNumStyles = document.Styles.NumberingStyles;
    var modelNumStylesCount = modelNumStyles.Count();
    var definedNumStylesCount = modelNumStyles.Count(item => item.IsDefined);
    var customNumStylesCount = modelNumStyles.Count(item => item.IsCustom);
    var validNumStylesCount = modelNumStyles.Count(item => item.IsValid);
    WriteLine($"  Document Numbering Styles: found {modelNumStylesCount}, defined {definedNumStylesCount}, custom {customNumStylesCount}, valid {validNumStylesCount}");
    if (validNumStylesCount < definedNumStylesCount)
    {
      WriteLine($"    Invalid Number Styles:");
      int i = 0;
      foreach (var style in modelNumStyles.Where(item => item.IsDefined && !item.IsValid))
      {
        WriteLine($"      {++i}. {style.Name}");
      }
    }

    var totalStylesCount = modelParaStylesCount + modelCharStylesCount + modelTableStylesCount + modelNumStylesCount;
    var totalValidStylesCount = validParaStylesCount + validCharStylesCount + validTableStylesCount + validNumStylesCount;
    var totalDefinedStylesCount = definedParaStylesCount + definedCharStylesCount + definedTableStylesCount + definedNumStylesCount;

    var totalStyleIds = document.Styles.StyleIndex.Count;
    WriteLine($"  Document Style Ids: found {totalStyleIds}, expected {totalDefinedStylesCount}");
    if (totalStyleIds != totalDefinedStylesCount)
    {
      WriteLine($"    Styles with no Id:");
      int i = 0;
      foreach (var style in modelAllStyles.Where(item => item.IsDefined && item.StyleId == null))
      {
        WriteLine($"      {++i}. {style.Name}");
      }
    }

    Assert.That(totalStylesCount, Is.EqualTo(modelAllStylesCount), "Invalid total styles count");
    Assert.That(totalValidStylesCount, Is.GreaterThanOrEqualTo(totalDefinedStylesCount), "Invalid defined styles found");
    Assert.That(totalStyleIds, Is.EqualTo(totalDefinedStylesCount), "Invalid style Ids count");

    TestDocDefaults(document.Styles.DocDefaults, reader.WordprocessingDocument.MainDocumentPart?.StyleDefinitionsPart?.Styles?.DocDefaults);

    return document.Styles;
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
      var diffs = new DiffList();
      if (!ParagraphPropertiesDefaultConverter.CompareModelElement(origParPropsDefaults, modelParPropsDefaults, diffs, null))
        Assert.Fail(diffs.FirstOrDefault()?.ToString());
    }
  }

  private void TestRunPropertiesDefault(DMW.RunPropertiesDefault? modelRunPropsDefaults,
    DXW.RunPropertiesDefault? origRunPropsDefaults)
  {
    if (origRunPropsDefaults != null)
    {
      Assert.IsNotNull(modelRunPropsDefaults, "RunPropertiesDefault is null");
      var diffs = new DiffList();
      if (!RunPropertiesDefaultConverter.CompareModelElement(origRunPropsDefaults, modelRunPropsDefaults, diffs, null))
        Assert.Fail(diffs.FirstOrDefault()?.ToString());
    }
  }

      [Test]
    public void TestStylesXmlSerialization()
    {
      var extraTypes = Assembly.Load("DocumentModel").GetTypes()
        .Where(item => item.IsPublic && !item.IsGenericType).ToArray();

      var filename = Path.Combine(TestPath, "CustomProperties.docx");
      var reader = new DocxReader(filename);
      var document = reader.ReadDocument(Parts.StyleDefinitions);
      DMW.Styles oldStyles = document.Styles ?? new DMW.Styles();//TestReadProperties(filename, true);
      Assert.IsNotNull(oldStyles, "No document styles read");
      if (oldStyles == null)
        return;
      var textWriter = new StringWriter();
      var serializer = new QXmlSerializer(typeof(Styles), extraTypes.ToArray(),
        new SerializationOptions { AcceptAllProperties = true });
      serializer.Serialize(textWriter, oldStyles);
      textWriter.Flush();
      string str = textWriter.ToString();
      WriteLine(str);
      WriteLine();

      //var textReader = new StringReader(str);
      //var newProperties = (DocumentProperties?)serializer.Deserialize(textReader);
      //Assert.IsNotNull(newProperties, $"Deserialized properties are null");
      //var oldPropertiesCount = oldStyles.Count;
      //var newPropertiesCount = newProperties.Count();
      //var newPropArray = newProperties.ToArray();
      //var oldPropArray = oldStyles.ToArray();
      //for (int i = 0; i < Math.Min(oldPropertiesCount, newPropertiesCount); i++)
      //{
      //  if (newPropArray[i].Name == "HeadingPairs")
      //    Debug.Assert(true);
      //  Assert.That(newPropArray[i], Is.EqualTo(oldPropArray[i]), $"Deserialized property \"{newPropArray[i].Name}\" different for original");
      //}
      //Assert.That(newPropertiesCount, Is.EqualTo(oldPropertiesCount), $"Deserialized properties count different for original");
    }

}
