using DocumentFormat.OpenXml.Wordprocessing;
using DocumentModel;
using DMW = DocumentModel.Wordprocessing;

namespace DocxDocument.Reader.Test
{
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
      var modelDefinedStyles = document.Styles.DefinedStyles;
      int modelDefinedStylesCount = modelDefinedStyles?.Count() ?? 0;
      var origDefinedStyles = reader.WordprocessingDocument.MainDocumentPart?.StyleDefinitionsPart?.Styles;
      int origDefinedStylesCount = origDefinedStyles?.Elements<Style>().Count() ?? 0;
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
      WriteLine($"  Document Paragraph Styles: found {modelParaStylesCount}, defined {definedParaStylesCount}, custom {customParaStylesCount}");

      var modelCharStyles = document.Styles.CharacterStyles;
      var modelCharStylesCount = modelCharStyles.Count();
      var definedCharStylesCount = modelCharStyles.Count(item => item.IsDefined);
      var customCharStylesCount = modelCharStyles.Count(item => item.IsCustom);
      WriteLine($"  Document Character Styles: found {modelCharStylesCount}, defined {definedCharStylesCount}, custom {customCharStylesCount}");

      var modelTableStyles = document.Styles.TableStyles;
      var modelTableStylesCount = modelTableStyles.Count();
      var definedTableStylesCount = modelTableStyles.Count(item => item.IsDefined);
      var customTableStylesCount = modelTableStyles.Count(item => item.IsCustom);
      WriteLine($"  Document Table Styles: found {modelTableStylesCount}, defined {definedTableStylesCount}, custom {customTableStylesCount}");

      var modelNumStyles = document.Styles.NumberingStyles;
      var modelNumStylesCount = modelNumStyles.Count();
      var definedNumStylesCount = modelNumStyles.Count(item => item.IsDefined);
      var customNumStylesCount = modelNumStyles.Count(item => item.IsCustom);
      WriteLine($"  Document Numbering Styles: found {modelNumStylesCount}, defined {definedNumStylesCount}, custom {customNumStylesCount}");

      var totalStylesCount = modelParaStylesCount + modelCharStylesCount + modelTableStylesCount + modelNumStylesCount;
      Assert.That(totalStylesCount, Is.EqualTo(modelAllStylesCount), "Invalid total styles count");

      return document.Styles;
    }

    //[Test]
    //public void TestPropertiesXmlSerialization()
    //{
    //  var extraTypes = Assembly.Load("DocumentModel").GetTypes()
    //    .Where(item=>item.IsPublic && !item.IsGenericType);

    //  var filename = Path.Combine(TestPath, "CustomProperties.docx");
    //  var oldProperties = ReadStyles(filename, true);
    //  var textWriter = new StringWriter();
    //  var serializer = new QXmlSerializer(typeof(DocumentProperties), extraTypes.ToArray(),
    //    new SerializationOptions{ AcceptAllProperties = true, });
    //  serializer.Serialize(textWriter, oldProperties);
    //  textWriter.Flush();
    //  string str = textWriter.ToString();
    //  Debug.WriteLine(str);
    //  Debug.WriteLine("");
    //  TestContext.Out.WriteLine(str);
    //  TestContext.Out.WriteLine();

    //  var textReader = new StringReader(str);
    //  var newProperties = (DocumentProperties?)serializer.Deserialize(textReader);
    //  Assert.IsNotNull(newProperties, $"Deserialized properties are null");
    //  var oldPropertiesCount = oldProperties.Count();
    //  var newPropertiesCount = newProperties.Count();
    //  Assert.That(newPropertiesCount, Is.EqualTo(oldPropertiesCount), $"Deserialized properties count different for original");
    //  var newPropArray = newProperties.ToArray();
    //  var oldPropArray = newProperties.ToArray();
    //  for (int i=0; i<oldPropertiesCount; i++)
    //    Assert.That(newPropArray[i], Is.EqualTo(oldPropArray[i]), $"Deserialized property \"{newPropArray[i].Name}\" different for original");
    //}

  }
}