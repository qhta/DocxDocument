using System.Reflection;

using DocumentFormat.OpenXml.Wordprocessing;

using DocumentModel;
using DocumentModel.OpenXml;
using DocumentModel.OpenXml.Wordprocessing;

using Qhta.Xml.Serialization;

namespace DocxDocument.ReadWrite.Test;

/// <summary>
/// Test class for document style definition part.
/// </summary>
/// <seealso cref="DocxDocument.ReadWrite.Test.TestBase" />
public class TestStyles : TestBase
{

  /// <summary>
  /// Tests the normal template styles.
  /// </summary>
  [Test]
  public void TestReadNormalTemplateStyles()
  {
    var filename = Path.Combine(TestPath, "Normal.dotm");
    TestReadStyles(filename, true);
  }

  /// <summary>
  /// Tests the style definitions read from "DocumentProperties.docx".
  /// </summary>
  [Test]
  public void TestReadDocumentStyles()
  {
    var filename = Path.Combine(TestPath, "DocumentProperties.docx");
    TestReadStyles(filename, true);
  }

  /// <summary>
  /// Tests the style definitions read from "CustomProperties.docx".
  /// </summary>
  [Test]
  public void TestReadCustomStyles()
  {
    var filename = Path.Combine(TestPath, "CustomProperties.docx");
    TestReadStyles(filename, true);
  }

  /// <summary>
  /// Tests the style definitions read from all docx files in folder specified by test path.
  /// </summary>
  [Test]
  public void TestReadStyles()
  {
    foreach (var filename in Directory.EnumerateFiles(TestPath, "*.docx"))
      TestReadStyles(filename);
  }

  /// <summary>
  /// Tests the style definitions read from the specified docx file.
  /// </summary>
  /// <param name="filename">The filename of the document to read.</param>
  /// <param name="showDetails">Specifies whether the detailed information on test should be shown on test failure.</param>
  public virtual void TestReadStyles(string filename, bool showDetails = false)
  {
    filename = Path.Combine(TestPath, filename);
    WriteLine($"Testing read styles of: {filename}");
    var reader = new DocxReader(filename);
    var document = reader.ReadDocument(Parts.StyleDefinitions);
    Assert.IsNotNull(document, "No document read");
    Assert.IsNotNull(document.Styles, "No document styles read");
    var modelStyles = document.Styles;
    var modelDefinedStyles = document.Styles.DefinedStyles;
    int modelDefinedStylesCount = modelDefinedStyles?.Count ?? 0;
    var origDefinedStyles = reader.WordprocessingDocument.MainDocumentPart?.StyleDefinitionsPart?.Styles;
    int origDefinedStylesCount = origDefinedStyles?.Elements<DXW.Style>().Count() ?? 0;
    WriteLine($"  Document Defined Styles: found {modelDefinedStylesCount}, expected {origDefinedStylesCount}");
    var diffs = new DiffList();
    if (!StylesConverter.CompareModelElement(origDefinedStyles, modelStyles, diffs, "Styles"))
      Assert.Fail(diffs.FirstOrDefault()?.ToString());
    Assert.That(modelDefinedStylesCount, Is.EqualTo(origDefinedStylesCount), "Invalid defined styles count");

    var modelLatentStyles = document.Styles.LatentStyles;
    int modelLatentStylesCount = modelLatentStyles?.Count ?? 0;
    var origLatentStyles = reader.WordprocessingDocument.MainDocumentPart?.StyleDefinitionsPart?.Styles?.LatentStyles;
    int origLatentStylesCount = origLatentStyles?.Elements<LatentStyleExceptionInfo>().Count() ?? 0;
    WriteLine($"  Document Lantent Styles: found {modelLatentStylesCount}, expected {origLatentStylesCount}");
    diffs = new DiffList();
    if (!LatentStylesConverter.CompareModelElement(origLatentStyles, modelLatentStyles, diffs, null))
      Assert.Fail(diffs.FirstOrDefault()?.ToString());
    Assert.That(modelLatentStylesCount, Is.EqualTo(origLatentStylesCount), "Invalid latent styles count");

    var modelAllStyles = document.Styles.AllStyles;
    var modelAllStylesCount = modelAllStyles.Count();
    WriteLine($"  Document All Styles: found {modelAllStylesCount}");

    var modelParaStyles = document.Styles.ParagraphStyles;
    var modelParaStylesCount = modelParaStyles.Count();
    var definedParaStylesCount = modelParaStyles.Count(item => item.IsDefined);
    var customParaStylesCount = modelParaStyles.Count(item => item.IsCustom == true);
    var validParaStylesCount = modelParaStyles.Count(item => item.IsValid);
    WriteLine($"  Document Paragraph Styles: found {modelParaStylesCount}, defined {definedParaStylesCount}, custom {customParaStylesCount}, valid {validParaStylesCount}");

    var modelCharStyles = document.Styles.CharacterStyles;
    var modelCharStylesCount = modelCharStyles.Count();
    var definedCharStylesCount = modelCharStyles.Count(item => item.IsDefined);
    var customCharStylesCount = modelCharStyles.Count(item => item.IsCustom == true);
    var validCharStylesCount = modelCharStyles.Count(item => item.IsValid);
    WriteLine($"  Document Character Styles: found {modelCharStylesCount}, defined {definedCharStylesCount}, custom {customCharStylesCount}, valid {validCharStylesCount}");

    var modelTableStyles = document.Styles.TableStyles;
    var modelTableStylesCount = modelTableStyles.Count();
    var definedTableStylesCount = modelTableStyles.Count(item => item.IsDefined);
    var customTableStylesCount = modelTableStyles.Count(item => item.IsCustom == true);
    var validTableStylesCount = modelTableStyles.Count(item => item.IsValid);
    WriteLine($"  Document Table Styles: found {modelTableStylesCount}, defined {definedTableStylesCount}, custom {customTableStylesCount}, valid {validTableStylesCount}");

    var modelNumStyles = document.Styles.NumberingStyles;
    var modelNumStylesCount = modelNumStyles.Count();
    var definedNumStylesCount = modelNumStyles.Count(item => item.IsDefined);
    var customNumStylesCount = modelNumStyles.Count(item => item.IsCustom == true);
    var validNumStylesCount = modelNumStyles.Count(item => item.IsValid);
    WriteLine($"  Document Numbering Styles: found {modelNumStylesCount}, defined {definedNumStylesCount}, custom {customNumStylesCount}, valid {validNumStylesCount}");

    var totalStylesCount = modelParaStylesCount + modelCharStylesCount + modelTableStylesCount + modelNumStylesCount;
    var totalValidStylesCount = validParaStylesCount + validCharStylesCount + validTableStylesCount + validNumStylesCount;
    var totalDefinedStylesCount = definedParaStylesCount + definedCharStylesCount + definedTableStylesCount + definedNumStylesCount;

    var totalStyleIds = document.Styles.StyleIndex.Count;
    WriteLine($"  Document Style Ids: found {totalStyleIds}, expected {totalDefinedStylesCount}");

    Assert.That(totalStylesCount, Is.GreaterThanOrEqualTo(modelAllStylesCount), "Invalid total styles count");
    Assert.That(totalValidStylesCount, Is.GreaterThanOrEqualTo(totalDefinedStylesCount), "Invalid defined styles found");
    Assert.That(totalStyleIds, Is.GreaterThanOrEqualTo(totalDefinedStylesCount), "Invalid style Ids count");

    CheckReadDocDefaults(document.Styles.DocDefaults, reader.WordprocessingDocument.MainDocumentPart?.StyleDefinitionsPart?.Styles?.DocDefaults);
    TestLatentStyleDefaults(document.Styles.LatentStyles, reader.WordprocessingDocument.MainDocumentPart?.StyleDefinitionsPart?.Styles?.LatentStyles);
  }

  /// <summary>
  /// Helper method to check whether read latent styles defaults are same as origin ones.
  /// </summary>
  /// <param name="modelLatentStyles">The model latent styles defaults.</param>
  /// <param name="origLatentStyles">The original latent styles defaults.</param>
  private void TestLatentStyleDefaults(DMW.LatentStyles? modelLatentStyles, DXW.LatentStyles? origLatentStyles)
  {
    if (origLatentStyles != null)
    {
      Assert.IsNotNull(modelLatentStyles, "LatentStyles is null");
      Assert.That(modelLatentStyles.DefaultLockedState, Is.EqualTo(origLatentStyles?.DefaultLockedState), "Invalid DefaultLockedState");
      Assert.That(modelLatentStyles.DefaultPrimaryStyle, Is.EqualTo(origLatentStyles?.DefaultPrimaryStyle), "Invalid DefaultPrimaryStyle");
      Assert.That(modelLatentStyles.DefaultSemiHidden, Is.EqualTo(origLatentStyles?.DefaultSemiHidden), "Invalid DefaultSemiHidden");
      Assert.That(modelLatentStyles.DefaultUiPriority, Is.EqualTo(origLatentStyles?.DefaultUiPriority), "Invalid DefaultUiPriority");
      Assert.That(modelLatentStyles.DefaultUnhideWhenUsed, Is.EqualTo(origLatentStyles?.DefaultUnhideWhenUsed), "Invalid DefaultUiPriority");
      Assert.That(modelLatentStyles.TotalCount, Is.EqualTo(origLatentStyles?.Count), "Invalid TotalCount");
    }
  }

  /// <summary>
  /// Helper method to check whether read document defaults are same as origin ones.
  /// </summary>
  /// <param name="modelDocDefaults">The model document defaults.</param>
  /// <param name="origDocDefaults">The original document defaults.</param>
  private void CheckReadDocDefaults(DMW.DocDefaults? modelDocDefaults, DXW.DocDefaults? origDocDefaults)
  {
    if (origDocDefaults != null)
    {
      Assert.IsNotNull(modelDocDefaults, "DocDefaults is null");
      CheckParagraphPropertiesDefault(modelDocDefaults.ParagraphPropertiesDefault, origDocDefaults.ParagraphPropertiesDefault);
      CheckRunPropertiesDefault(modelDocDefaults.RunPropertiesDefault, origDocDefaults.RunPropertiesDefault);
    }
  }

  /// <summary>
  /// Helper method to check whether read document default paragraph properties are same as origin ones.
  /// </summary>
  /// <param name="modelParPropsDefaults">The model default paragraph properties.</param>
  /// <param name="origParPropsDefaults">The original default paragraph properties.</param>
  private void CheckParagraphPropertiesDefault(DMW.DefaultParagraphProperties? modelParPropsDefaults,
    DXW.ParagraphPropertiesDefault? origParPropsDefaults)
  {
    if (origParPropsDefaults != null)
    {
      Assert.IsNotNull(modelParPropsDefaults, "ParagraphPropertiesDefault is null");
      var diffs = new DiffList();
      if (!DefaultParagraphPropertiesConverter.CompareModelElement(origParPropsDefaults, modelParPropsDefaults, diffs, null))
        Assert.Fail(diffs.FirstOrDefault()?.ToString());
    }
  }

  /// <summary>
  /// Helper method to check whether read document default run text properties are same as origin ones.
  /// </summary>
  /// <param name="modelRunPropsDefaults">The model default run properties.</param>
  /// <param name="origRunPropsDefaults">The original default run properties.</param>
  private void CheckRunPropertiesDefault(DMW.DefaultRunProperties? modelRunPropsDefaults,
    DXW.RunPropertiesDefault? origRunPropsDefaults)
  {
    if (origRunPropsDefaults != null)
    {
      Assert.IsNotNull(modelRunPropsDefaults, "RunPropertiesDefault is null");
      var diffs = new DiffList();
      if (!DefaultRunPropertiesConverter.CompareModelElement(origRunPropsDefaults, modelRunPropsDefaults, diffs, null))
        Assert.Fail(diffs.FirstOrDefault()?.ToString());
    }
  }

  /// <summary>
  /// Tests styles Xml serialization by reading files,
  /// serialize and deserialize styles using string writer.
  /// </summary>
  [Test]
  public void TestReadStylesXmlSerialization()
  {
    foreach (var filename in Directory.EnumerateFiles(TestPath, "*.docx"))
      TestReadStylesXmlSerialization(filename);
  }

  /// <summary>
  /// Tests styles Xml serialization by reading file,
  /// serialize and deserialize numbering using string writer.
  /// </summary>
  public void TestReadStylesXmlSerialization(string filename, bool showDetails = false)
  {
    filename = Path.Combine(TestPath, filename);
    WriteLine($"Testing styles serialization of: {filename}");
    var extraTypes = Assembly.Load("DocumentModel").GetTypes()
      .Where(item => item.IsPublic && !item.IsGenericType).ToArray();
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
    if (showDetails)
    {
      WriteLine(str);
      WriteLine();
    }

    var textReader = new StringReader(str);
    var newStyles = (DMW.Styles?)serializer.Deserialize(textReader);
    Assert.IsNotNull(newStyles, $"Deserialized styles are null");

    var newStylesArray = newStyles.DefinedStyles.ToArray();
    var oldStylesArray = oldStyles.DefinedStyles.ToArray();
    var diffs = new DiffList();
    var ok = DeepComparer.IsEqual(oldStylesArray, newStylesArray, diffs, "Styles");
    if (!ok)
      foreach (var diff in diffs)
        WriteLine(diff.ToString());
    Assert.That(ok, $"Deserialized {diffs.AssertMessage}");
    CheckLatentStyleDefaults(newStyles.LatentStyles, oldStyles.LatentStyles);
  }

  private void CheckLatentStyleDefaults(DMW.LatentStyles? modelLatentStyles, DMW.LatentStyles? origLatentStyles)
  {
    if (origLatentStyles != null)
    {
      Assert.IsNotNull(modelLatentStyles, "LatentStyles is null");
      Assert.That(modelLatentStyles.DefaultLockedState, Is.EqualTo(origLatentStyles?.DefaultLockedState), "Invalid DefaultLockedState");
      Assert.That(modelLatentStyles.DefaultPrimaryStyle, Is.EqualTo(origLatentStyles?.DefaultPrimaryStyle), "Invalid DefaultPrimaryStyle");
      Assert.That(modelLatentStyles.DefaultSemiHidden, Is.EqualTo(origLatentStyles?.DefaultSemiHidden), "Invalid DefaultSemiHidden");
      Assert.That(modelLatentStyles.DefaultUiPriority, Is.EqualTo(origLatentStyles?.DefaultUiPriority), "Invalid DefaultUiPriority");
      Assert.That(modelLatentStyles.DefaultUnhideWhenUsed, Is.EqualTo(origLatentStyles?.DefaultUnhideWhenUsed), "Invalid DefaultUiPriority");
      Assert.That(modelLatentStyles.TotalCount, Is.EqualTo(origLatentStyles?.TotalCount), "Invalid TotalCount");
    }
  }
}
