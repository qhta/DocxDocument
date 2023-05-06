
using DocumentFormat.OpenXml.Packaging;
using System.Xml;
using DocumentModel;
using Qhta.TypeUtils;
using NUnit.Framework.Internal;

namespace DocxDocument.ReadWrite.Test;

/// <summary>
/// Test of the document properties.
/// </summary>
/// <seealso cref="DocxDocument.ReadWrite.Test.TestBase" />
public class TestProperties : TestBase
{

  #region test helper data
  /// <summary>
  /// Names of the extended properties that are treated as statistic properties.
  /// </summary>
  protected string[] statisticPropElementsNames { get; set; } = new string[] { "TotalTime", "Characters", "CharactersWithSpaces",
      "HiddenSlides", "Lines", "MMClips", "Notes", "Pages", "Paragraphs", "Slides", "TotalTime", "Words" };

  /// <summary>
  /// Names of the xml elements that are used over Office version 2007.
  /// </summary>
  protected string[] extraPropElementsNames { get; set; } = new string[] { "w14:docId", "w15:docId", "w14:conflictMode" };

  /// <summary>
  /// Names of the xml elements that are stored in the document settings part, but belong to document properies.
  /// </summary>
  protected string[] settingsPropertiesElementsNames { get; set; } = new string[] { "w14:docId", "w15:docId", "w14:conflictMode", "w:rsids" };
  #endregion

  #region test properties read
  /// <summary>
  /// Tests the read normal template properties.
  /// </summary>
  [Test]
  public void TestReadNormalTemplateProperties()
  {
    var filename = Path.Combine(TestPath, "Normal.dotm");
    TestReadProperties(filename, true);
  }

  /// <summary>
  /// Tests the document properties read from all docx files in folder specified by test path.
  /// </summary>
  [Test]
  public void TestReadProperties()
  {
    foreach (var filename in Directory.EnumerateFiles(TestPath, "*.docx"))
      TestReadProperties(filename);
  }

  /// <summary>
  /// Tests the document properties read from the file
  /// </summary>
  /// <param name="filename">The filename.</param>
  /// <param name="showDetails">Specifies if test details should be shown.</param>
  /// <param name="openWord">Specifies that new document should be opened in MS Word</param>
  public virtual bool TestReadProperties(string filename, bool showDetails = false, bool openWord = false)
  {
    if (String.IsNullOrEmpty(Path.GetDirectoryName(filename)))
      filename = Path.Combine(TestPath, filename);
    string newFilename = null!;
    var ok = true;

    #region test read
    WriteLine($"Testing read properties of: {filename}");
    using (var reader = new DocxReader(filename))
    {
      var document = reader.GetDocument(PartsMask.AllDocumentProperties);
      Assert.IsNotNull(document, "No document read");
      Assert.IsNotNull(document.Properties, "No document properties read");
      Assert.That(document.Properties.Count(), Is.GreaterThan(0), "Document properties count is 0");
      WriteLine($"  AllDocumentProperties = {document.Properties.Count()}");

      if (!CheckReadCoreDocumentProperties(document, reader.WordprocessingDocument, showDetails))
        ok = false;
      if (!CheckReadExtendedDocumentProperties(document, reader.WordprocessingDocument, showDetails))
        ok = false;
      if (!CheckReadCustomDocumentProperties(document, reader.WordprocessingDocument, showDetails))
        ok = false;
      if (!CheckReadDocumentSettings(document, reader.WordprocessingDocument, showDetails))
        ok = false;
      if (!CheckReadWebSettings(document, reader.WordprocessingDocument, showDetails))
        ok = false;
      #endregion
      if (ok)
      {
        #region serialization
        var oldProperties = document.Properties;//TestReadProperties(filename, true);
        Assert.IsNotNull(oldProperties, "No document properties read");
        if (oldProperties == null)
          return false;
        var textWriter = new StringWriter();
        var extraTypes = Assembly.Load("DocumentModel").GetTypes()
          .Where(item => item.IsPublic && !item.IsGenericType).ToArray();
        var serializer = new QXmlSerializer(typeof(DocumentProperties), extraTypes.ToArray(),
          new SerializationOptions { AcceptAllProperties = true });
        try
        {
          serializer.Serialize(textWriter, oldProperties);
        }
        catch (Exception ex)
        {
          Console.WriteLine(ex.Message);
        }
        textWriter.Flush();
        string str = textWriter.ToString();
        if (showDetails)
        {
          WriteLine(str);
          WriteLine();
        }
        #endregion

        #region deserialization
        var textReader = new StringReader(str);
        var newProperties = (DocumentProperties?)serializer.Deserialize(textReader);
        Assert.IsNotNull(newProperties, $"Deserialized properties are null");
        var diffs = new DiffList();
        ok = DeepComparer.IsEqual(oldProperties, newProperties, diffs);
        if (!ok)
          foreach (var diff in diffs)
            WriteLine(diff.ToString());
        Assert.That(ok, $"Deserialized {diffs.AssertMessage}");
        #endregion
        if (ok)
        {
          #region copy back
          if (String.IsNullOrEmpty(Path.GetDirectoryName(filename)))
            filename = Path.Combine(TestPath, filename);
          newFilename = Path.Combine(Path.GetDirectoryName(filename) ?? "", Path.GetFileNameWithoutExtension(filename) + ".new" + Path.GetExtension(filename));
          File.Copy(filename, newFilename, true);
          using (var writer = DocxWriter.Open(newFilename))
          {
            writer.SetDocumentProperties(newProperties, PartsMask.AllDocumentProperties);
          }
          #endregion
        }
      }
    }
    if (ok && newFilename != null)
    {
      UnzipFile(filename);
      UnzipFile(newFilename);
      ok = TestDirectories(filename + ".unzip", newFilename + ".unzip", showDetails);
      if (ok && openWord)
      {
        var processStartInfo = new ProcessStartInfo("C:\\Program Files\\Microsoft Office\\root\\Office16\\WINWORD.EXE", "\"" + filename + "\"");
        Process.Start(processStartInfo);
      }
    }
    return ok;
  }
  #endregion

  #region test properties generation
  /// <summary>
  /// Tests generation of properties
  /// </summary>
  /// <param name="filename">The filename.</param>
  /// <param name="showDetails">Specifies if test details should be shown.</param>
  /// <param name="openWord">Specifies that new document should be opened in MS Word</param>
  public virtual bool TestGenProperties(string filename, bool showDetails = false, bool openWord = false)
  {
    if (String.IsNullOrEmpty(Path.GetDirectoryName(filename)))
      filename = Path.Combine(TestPath, filename);
    var ok = true;

    WriteLine($"Testing generating properties of: {filename}");

    filename = Path.Combine(Path.GetDirectoryName(filename) ?? "", Path.GetFileNameWithoutExtension(filename) + ".gen" + Path.GetExtension(filename));
    CreateWordprocessingDocument(filename);

    var document = new DMW.Document();

    GenerateCoreDocumentProperties(document, showDetails);
    GenerateContentDocumentProperties(document, showDetails);

    var docProperties = document.Properties;
    if (docProperties != null)
    {
      using (var writer = DocxWriter.Open(filename))
      {
        writer.SetDocumentProperties(docProperties, PartsMask.AllDocumentProperties);
      }
    }
    UnzipFile(filename);
    if (openWord)
    {
      var processStartInfo = new ProcessStartInfo("C:\\Program Files\\Microsoft Office\\root\\Office16\\WINWORD.EXE", "\"" + filename + "\"");
      Process.Start(processStartInfo);
    }
    return ok;
  }
  #endregion



  #region Core properties test methods
  /// <summary>
  /// Checks whether the core document properties read from the file are equal to origin ones.
  /// </summary>
  /// <param name="modelDocument">Model document read from docx file.</param>
  /// <param name="origDocument">The original document.</param>
  /// <param name="showDetails">Specifies if test details should be shown.</param>
  private bool CheckReadCoreDocumentProperties(DMW.Document modelDocument, WordprocessingDocument origDocument, bool showDetails)
  {
    CoreProperties? coreDocumentProperties = modelDocument.Properties?.CoreProperties;
    int origCorePropertiesCount = 0;
    int corePropertiesCount = 0;
    if (coreDocumentProperties != null)
    {
      var origFilePropertiesPart = origDocument.PackageProperties;
      var coreFilePropertiesPartProperties = typeof(PackageProperties).GetProperties();
      foreach (var prop in coreFilePropertiesPartProperties)
      {
        if (prop.GetValue(origFilePropertiesPart, new object[0]) != null)
          origCorePropertiesCount++;
      }
      var coreProperties = typeof(CoreProperties).GetProperties();
      if (showDetails)
      {
        WriteLine(
          $"  CoreProperties: defined {coreProperties.Count()} loaded {corePropertiesCount} expected {origCorePropertiesCount}");
        DumpCoreDocumentProperties(modelDocument);
      }
      foreach (var prop in coreProperties.Where(item => item.CanWrite))
        if (prop.GetValue(coreDocumentProperties, null) != null)
          corePropertiesCount++;
    }
    Assert.That(corePropertiesCount, Is.EqualTo(origCorePropertiesCount), "Invalid core properties count");
    return true;
  }

  private void DumpCoreDocumentProperties(DMW.Document modelDocument)
  {
    var coreProperties = typeof(CoreProperties).GetProperties();
    foreach (var prop in coreProperties.Where(item => item.CanWrite))
    {
      var documentProperty = modelDocument.Properties?.GetProperty(prop.Name);
      if (documentProperty != null)
        WriteLine($"    {documentProperty}");
    }
  }

  private void SetRandomProperties(object obj)
  {
    foreach (var prop in obj.GetType()
      .GetProperties(BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly)
      .Where(item => item.CanWrite))
    {
      var propType = prop.PropertyType;
      propType = propType.GetNotNullableType();
      if (prop.Name==nameof(ContentProperties.Template))
        prop.SetValue(obj, "Normal.dotm", null);
      else
      if (prop.Name==nameof(ContentProperties.DocumentSecurity))
      {
        //prop.SetValue(obj, "Normal.dotm", null);
      }
      else
      if (prop.Name==nameof(ContentProperties.Application))
        prop.SetValue(obj, "Microsoft Office Word", null);
      else
      if (prop.Name==nameof(ContentProperties.ApplicationVersion))
        prop.SetValue(obj, "16.0000", null);
      else
      if (propType == typeof(string))
        prop.SetValue(obj, prop.Name, null);
      else if (propType == typeof(int))
        prop.SetValue(obj, Random.Next(), null);
      else if (propType == typeof(Boolean))
        prop.SetValue(obj, Random.NextDouble()>=0.5, null);
      else if (propType == typeof(DateTime))
        prop.SetValue(obj, RandomDateTime(), null);
    }
  }

  /// <summary>
  /// Generate core document properties.
  /// </summary>
  /// <param name="modelDocument">New model document.</param>
  /// <param name="showDetails">Specifies whether to show generated properties</param>
  private void GenerateCoreDocumentProperties(DMW.Document modelDocument, bool showDetails)
  {
    var documentProperties = modelDocument.Properties;
    if (documentProperties == null)
      documentProperties = modelDocument.Properties = new DocumentProperties();
    var coreProperties = documentProperties.CoreProperties;
    if (coreProperties == null)
      coreProperties = documentProperties.CoreProperties = new CoreProperties();
    SetRandomProperties(coreProperties);
    if (showDetails)
    {
      WriteLine(
        $"  CoreProperties generated {coreProperties.Count()}");
      DumpCoreDocumentProperties(modelDocument);
    }
  }

  #endregion

  #region Extended properties test methods
  /// <summary>
  /// Checks whether the extended document properties (content and statistic) read from the file are equal to origin ones.
  /// </summary>
  /// <param name="modelDocument">Model document read from docx fils.</param>
  /// <param name="origDocument">The original document.</param>
  /// <param name="showDetails">Specifies if test details should be shown.</param>
  private bool CheckReadExtendedDocumentProperties(DMW.Document modelDocument, WordprocessingDocument origDocument, bool showDetails)
  {
    ContentProperties? contentDocumentProperties = modelDocument.Properties?.ContentProperties;
    StatisticProperties? statisticDocumentProperties = modelDocument.Properties?.StatisticProperties;
    int contentPropertiesCount = 0;
    int statisticPropertiesCount = 0;
    int origExtendedPropertiesCount = 0;
    int origContentPropertiesCount = 0;
    int origStatisticPropertiesCount = 0;
    if (contentDocumentProperties != null)
    {
      origExtendedPropertiesCount = origDocument.ExtendedFilePropertiesPart?.Properties?.Elements().Count() ?? 0;
      origStatisticPropertiesCount = origDocument.ExtendedFilePropertiesPart?.Properties?.Elements()
        ?.Count(item => statisticPropElementsNames.Contains(item.LocalName)) ?? 0;
      origContentPropertiesCount = origExtendedPropertiesCount - origStatisticPropertiesCount;
      var contentProperties = typeof(ContentProperties).GetProperties();
      foreach (var prop in contentProperties.Where(item => item.CanWrite))
      {
        if (prop.GetValue(contentDocumentProperties, null) != null)
          contentPropertiesCount++;
      }
      var statisticProperties = typeof(StatisticProperties).GetProperties();
      foreach (var prop in statisticProperties.Where(item => item.CanWrite))
      {
        if (prop.GetValue(statisticDocumentProperties, null) != null)
          statisticPropertiesCount++;
      }
      if (showDetails)
      {
        WriteLine(
          $"  ContentProperties: defined {contentProperties.Count()} loaded {contentPropertiesCount} expected {origContentPropertiesCount}");
        DumpContentDocumentProperties(modelDocument);
        WriteLine(
          $"  StatisticProperties: defined {statisticProperties.Count()} loaded {statisticPropertiesCount} expected {origStatisticPropertiesCount}");
        DumpStatisticDocumentProperties(modelDocument);
      }

      if (showDetails)
      {
        foreach (var prop in contentProperties.Where(item => item.CanWrite))
        {
          var documentProperty = modelDocument.Properties?.GetProperty(prop.Name);
          if (documentProperty != null)
            WriteLine($"    {documentProperty}");
        }
      }
    }
    Assert.That(contentPropertiesCount, Is.EqualTo(origContentPropertiesCount), "Invalid content properties count");
    Assert.That(statisticPropertiesCount, Is.EqualTo(origStatisticPropertiesCount), "Invalid content properties count");
    return true;
  }

  private void DumpContentDocumentProperties(DMW.Document modelDocument)
  {
    var contentProperties = typeof(ContentProperties).GetProperties();
    foreach (var prop in contentProperties.Where(item => item.CanWrite))
    {
      var documentProperty = modelDocument.Properties?.GetProperty(prop.Name);
      if (documentProperty != null)
        WriteLine($"    {documentProperty}");
    }
  }

  private void DumpStatisticDocumentProperties(DMW.Document modelDocument)
  {
    var statisticProperties = typeof(StatisticProperties).GetProperties();
    foreach (var prop in statisticProperties.Where(item => item.CanWrite))
    {
      var documentProperty = modelDocument.Properties?.GetProperty(prop.Name);
      if (documentProperty != null)
        WriteLine($"    {documentProperty}");
    }
  }

  /// <summary>
  /// Generate extended document properties.
  /// </summary>
  /// <param name="modelDocument">New model document.</param>
  /// <param name="showDetails">Specifies whether to show generated properties</param>
  private void GenerateContentDocumentProperties(DMW.Document modelDocument, bool showDetails)
  {
    var documentProperties = modelDocument.Properties;
    if (documentProperties == null)
      documentProperties = modelDocument.Properties = new DocumentProperties();
    var contentProperties = documentProperties.ContentProperties;
    if (contentProperties == null)
      contentProperties = documentProperties.ContentProperties = new ContentProperties();
    SetRandomProperties(contentProperties);
    if (showDetails)
    {
      WriteLine(
        $"  ContentProperties generated {contentProperties.Count()}");
      DumpContentDocumentProperties(modelDocument);
    }
  }
  #endregion

  #region Custom properties test methods
  /// <summary>
  /// Checks whether the custom document properties read from the file are equal to origin ones.
  /// </summary>
  /// <param name="modelDocument">Model document read from docx fils.</param>
  /// <param name="origDocument">The original document.</param>
  /// <param name="showDetails">Specifies if test details should be shown.</param>
  private bool CheckReadCustomDocumentProperties(DMW.Document modelDocument, WordprocessingDocument origDocument, bool showDetails)
  {
    CustomProperties? customDocumentProperties = modelDocument.Properties?.CustomProperties;
    int customPropertiesCount = 0;
    int origCustomPropertiesCount = 0;
    if (customDocumentProperties != null)
    {
      customPropertiesCount = customDocumentProperties.Count();
      origCustomPropertiesCount = origDocument?.CustomFilePropertiesPart?.Properties.Count() ?? 0;
      WriteLine($"  CustomProperties = {customPropertiesCount}/{origCustomPropertiesCount}");
      if (showDetails)
      {
        foreach (var prop in customDocumentProperties)
        {
          if (prop?.Name != null)
          {
            var documentProperty = modelDocument.Properties?.GetProperty(prop.Name);
            if (documentProperty != null)
              WriteLine($"    {documentProperty}");
          }
        }
      }
    }
    Assert.That(customPropertiesCount, Is.EqualTo(origCustomPropertiesCount), "Invalid custom properties count");
    return true;
  }
  #endregion

  #region Document settings test methods.
  /// <summary>
  /// Checks whether the document settings read from the file are equal to origin ones.
  /// </summary>
  /// <param name="modelDocument">Model document read from docx fils.</param>
  /// <param name="origDocument">The original document.</param>
  /// <param name="showDetails">Specifies if test details should be shown.</param>
  private bool CheckReadDocumentSettings(DMW.Document modelDocument, WordprocessingDocument origDocument, bool showDetails)
  {
    var documentSettings = modelDocument.Properties?.DocumentSettings;
    int origDocumentSettingsCount = 0;
    int documentSettingsCount = 0;
    if (documentSettings != null)
    {
      origDocumentSettingsCount = origDocument.MainDocumentPart?.DocumentSettingsPart?.Settings?.Elements().Count() ?? 0;
      var modelDocumentSettings = typeof(DocumentSettings).GetProperties();
      foreach (var prop in modelDocumentSettings.Where(item => item.CanWrite))
      {
        if (prop.GetValue(documentSettings, null) != null)
          documentSettingsCount++;
      }
      WriteLine(
        $"  DocumentSettings: defined {modelDocumentSettings.Count()} loaded {documentSettingsCount} expected {origDocumentSettingsCount}");
      if (showDetails)
      {
        foreach (var prop in modelDocumentSettings.Where(item => item.CanWrite))
        {
          var documentProperty = modelDocument.Properties?.GetProperty(prop.Name);
          if (documentProperty?.Value != null)
            WriteLine($"    {documentProperty}");
        }
      }
    }
    Assert.That(documentSettingsCount, Is.EqualTo(origDocumentSettingsCount), "Invalid document settings count");
    return true;
  }
  #endregion

  #region Web settings test methods
  /// <summary>
  /// Checks whether the web settings read from the file are equal to origin ones.
  /// </summary>
  /// <param name="modelDocument">Model document read from docx fils.</param>
  /// <param name="origDocument">The original document.</param>
  /// <param name="showDetails">Specifies if test details should be shown.</param>
  private bool CheckReadWebSettings(DMW.Document modelDocument, WordprocessingDocument origDocument, bool showDetails)
  {
    var webSettings = modelDocument.Properties?.WebSettings;
    int origWebSettingsCount = 0;
    int webSettingsCount = 0;
    if (webSettings != null)
    {
      origWebSettingsCount = origDocument.MainDocumentPart?.WebSettingsPart?.WebSettings?.Elements().Count() ?? 0;
      var modelWebSettings = typeof(DM.WebSettings).GetProperties();
      foreach (var prop in modelWebSettings.Where(item => item.CanWrite))
        if (prop.GetValue(webSettings, null) != null)
          webSettingsCount++;
      WriteLine(
        $"  WebSettings: defined {modelWebSettings.Count()} loaded {webSettingsCount} expected {origWebSettingsCount}");
      if (showDetails)
      {
        foreach (var prop in modelWebSettings.Where(item => item.CanWrite))
        {
          var documentProperty = modelDocument.Properties?.GetProperty(prop.Name);
          if (documentProperty?.Value != null)
            WriteLine($"    {documentProperty}");
        }
      }
    }
    Assert.That(webSettingsCount, Is.EqualTo(origWebSettingsCount), "Invalid web settings count");
    return true;
  }
  #endregion

}
