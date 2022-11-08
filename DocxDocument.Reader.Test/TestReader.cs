using System.Collections;
using System.Reflection;
using System.Xml.Serialization;

using DocxDocument.Model;

using Qhta.OpenXMLTools;

namespace DocxDocument.Reader.Test
{
  public class TestReader
  {
    [SetUp]
    public void Setup()
    {
      var testPath = Assembly.GetExecutingAssembly().Location;
      testPath = testPath.Substring(0, testPath.IndexOf(@"\bin")) + @"\SampleDocx";
      TestContext.Progress.WriteLine(testPath);
      TestPath = testPath;
    }

    public string TestPath { get; set; } = string.Empty;

    [Test]
    public void TestNormalTemplate()
    {
      var filename = Path.Combine(TestPath, "Normal.dotm");
      TestReadProperties(filename, true);
      TestReadSettings(filename, true);
    }

    [Test]
    public void TestReadProperties()
    {
      //int runCount = 0;
      foreach (var filename in Directory.EnumerateFiles(TestPath, "*.docx"))
        TestReadProperties(filename, Path.GetFileName(filename) == "CustomProperties.docx");
    }

    public void TestReadProperties(string filename, bool showDetails = false)
    {
      TestContext.Progress.WriteLine(filename);
      var reader = new DocxReader(filename);
      var document = reader.ReadDocument(Parts.AllDocumentProperties);
      Assert.IsNotNull(document, "No document read");
      Assert.IsNotNull(document.Properties, "No document properties read");
      Assert.That(document.Properties.Count, Is.GreaterThan(0), "Document properties count is 0");
      TestContext.Progress.WriteLine($"  AllDocumentProperties = {document.Properties.Count}");

      ICoreDocumentProperties coreDocumentProperties = document.Properties as ICoreDocumentProperties;
      var coreProperties = typeof(ICoreDocumentProperties).GetProperties();
      int corePropertiesCount = 0;
      foreach (var prop in coreProperties)
        if (prop.GetValue(coreDocumentProperties, null) != null)
          corePropertiesCount++;
      TestContext.Progress.WriteLine($"  CoreProperties = {corePropertiesCount}/{coreProperties.Count()}");
      if (showDetails)
      {
        foreach (var prop in coreProperties)
        {
          var value = document.Properties.Get(prop.Name);
          if (value != null)
            TestContext.Progress.WriteLine($"    {prop.Name} = {value}");
        }
      }

      IContentDocumentProperties contentDocumentProperties = document.Properties as IContentDocumentProperties;
      var contentProperties = typeof(IContentDocumentProperties).GetProperties();
      int contentPropertiesCount = 0;
      foreach (var prop in contentProperties)
        if (prop.GetValue(contentDocumentProperties, null) != null)
          contentPropertiesCount++;
      TestContext.Progress.WriteLine($"  ContentProperties = {contentPropertiesCount}/{contentProperties.Count()}");
      if (showDetails)
      {
        foreach (var prop in contentProperties)
        {
          var value = document.Properties.Get(prop.Name);
          if (value != null)
            TestContext.Progress.WriteLine($"    {prop.Name} = {value}");
        }
      }

      IStatisticDocumentProperties statisticsDocumentProperties = document.Properties as IStatisticDocumentProperties;
      var statisticProperties = typeof(IStatisticDocumentProperties).GetProperties();
      int statisticPropertiesCount = 0;
      foreach (var prop in statisticProperties)
        if (prop.GetValue(statisticsDocumentProperties, null) != null)
          statisticPropertiesCount++;
      TestContext.Progress.WriteLine($"  StatisticsProperties = {statisticPropertiesCount}/{statisticProperties.Count()}");
      if (showDetails)
      {
        foreach (var prop in statisticProperties)
        {
          var value = document.Properties.Get(prop.Name);
          if (value != null)
            TestContext.Progress.WriteLine($"    {prop.Name} = {value}");
        }
      }

      IExtraDocumentProperties extraDocumentProperties = document.Properties as IExtraDocumentProperties;
      var extraProperties = typeof(IExtraDocumentProperties).GetProperties();
      int extraPropertiesCount = 0;
      foreach (var prop in extraProperties)
        if (prop.GetValue(extraDocumentProperties, null) != null)
          extraPropertiesCount++;
      TestContext.Progress.WriteLine($"  ExtraProperties = {extraPropertiesCount}/{extraProperties.Count()}");
      if (showDetails)
      {
        foreach (var prop in extraProperties)
        {
          var value = document.Properties.Get(prop.Name);
          if (value != null)
            TestContext.Progress.WriteLine($"    {prop.Name} = {value}");
        }
      }

      ICustomProperties customDocumentProperties = document.Properties as ICustomProperties;
      int customPropertiesCount = customDocumentProperties.Count;
      var origCustomPropertiesCount = reader.WordprocessingDocument?.CustomFilePropertiesPart?.Properties.Count() ?? 0;
      TestContext.Progress.WriteLine($"  CustomProperties = {customPropertiesCount}/{origCustomPropertiesCount}");
      if (showDetails)
      {
        foreach (var prop in customDocumentProperties)
        {
          var value = document.Properties.Get(prop.Name);
          if (value != null)
            TestContext.Progress.WriteLine($"    {prop.Name} = {value}");
        }
      }

      var revisions = document.Properties.RsIds;
      var revisionsCount = revisions?.Count ?? 0;
      if (revisions?.RsidRoot is HexInt)
        revisionsCount++;
      var origRevisionsCount = reader.WordprocessingDocument?.MainDocumentPart?.DocumentSettingsPart?.Settings.GetRsids()?.Count() ?? 0;
      TestContext.Progress.WriteLine($"  Revisions = {revisionsCount}/{origRevisionsCount}");
      if (showDetails)
      {
        var value = revisions?.RsidRoot;
        if (value != null)
          TestContext.Progress.WriteLine($"    RsidRoot = {value}");
      }

      Assert.That(corePropertiesCount, Is.GreaterThanOrEqualTo(9));
      Assert.That(contentPropertiesCount, Is.GreaterThanOrEqualTo(8));
      Assert.That(statisticPropertiesCount, Is.EqualTo(7));
      Assert.That(customPropertiesCount, Is.EqualTo(origCustomPropertiesCount));
      Assert.That(extraPropertiesCount, Is.GreaterThanOrEqualTo(1));
      Assert.That(revisionsCount, Is.EqualTo(origRevisionsCount));
    }

    [Test]
    public void TestReadSettings()
    {
      int runCount = 0;
      foreach (var filename in Directory.EnumerateFiles(TestPath, "*.docx"))
        TestReadSettings(filename, runCount++ == 0);
    }

    public void TestReadSettings(string filename, bool showDetails = false)
    {
      TestContext.Progress.WriteLine(filename);
      var reader = new DocxReader(filename);
      var document = reader.ReadDocument(Parts.AllDocumentSettings);
      Assert.IsNotNull(document, "No document read");
      Assert.IsNotNull(document.Settings, "No document settings read");
      Assert.That(document.Settings.Count, Is.GreaterThan(0), "Document settings count is 0");
      TestContext.Progress.WriteLine($" AllDocumentSettings = {document.Settings.Count}");

      IDocumentSettings documentSettings = document.Settings as IDocumentSettings;
      var documentSettingsProperties = typeof(IDocumentSettings).GetProperties();
      int documentSettingsPropertiesCount = 0;
      foreach (var prop in documentSettingsProperties)
        if (prop.GetValue(documentSettings, null) != null)
          documentSettingsPropertiesCount++;
      TestContext.Progress.WriteLine($"  DocumentSettings = {documentSettingsPropertiesCount}/{documentSettingsProperties.Count()}");

      if (showDetails)
      {
        foreach (var setting in document.Settings)
          ShowObject(setting.Key, setting.Value);
      }
    }

    private void ShowObject(string name, object? value, int indent = 0)
    {
      if (value is null)
        return;
      var type = value.GetType();
      var indentStr = new string(' ', (indent + 2) * 2);
      if (type.IsClass && type != typeof(string))
      {
        TestContext.Progress.WriteLine(indentStr + $"{name}");
        var typeProperties = type.GetProperties();
        foreach (var prop in typeProperties)
        {
          if (prop.GetIndexParameters().Length == 0)
          {
            if (prop.GetCustomAttribute<XmlIgnoreAttribute>() is null)
            {
              if (prop.PropertyType.Name == "IEnumerable`1")
              {
                var arg = prop.PropertyType.GetGenericArguments().FirstOrDefault();
                ShowEnumerable(prop.Name, prop.GetValue(value, null) as IEnumerable, arg, indent + 1);
              }
              else
                ShowObject(prop.Name, prop.GetValue(value, null), indent + 1);
            }
          }
        }
        var intfType = value.GetType().GetInterface("IEnumerable`1");
        if (intfType is not null)
        {
          var arg = intfType.GetGenericArguments().FirstOrDefault();
          ShowEnumerable(value as IEnumerable, arg, indent + 1);
        }
      }
      else
        TestContext.Progress.WriteLine(indentStr + $"{name} = {value}");
    }

    private void ShowEnumerable(string name, IEnumerable? value, Type? itemType, int indent = 0)
    {
      if (value is null)
        return;
      var type = value.GetType();
      var arg = type.GetGenericArguments().FirstOrDefault();
      var indentStr = new string(' ', (indent + 2) * 2);
      TestContext.Progress.WriteLine(indentStr + $"{name}");
      int itemCount = 0;
      foreach (var item in value)
        ShowObject($"[{itemCount++}]: ", item, indent + 1);
    }

    private void ShowEnumerable(IEnumerable? value, Type? itemType, int indent = 0)
    {
      if (value is null)
        return;
      var indentStr = new string(' ', (indent + 2) * 2);
      int itemCount = 0;
      foreach (var item in value)
        ShowObject($"[{itemCount++}]: ", item, indent + 1);
    }

  }
}