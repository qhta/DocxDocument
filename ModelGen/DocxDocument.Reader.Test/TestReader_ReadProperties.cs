using System.Collections;
using System.IO.Packaging;
using System.Reflection;
using System.Xml.Serialization;

using DocumentFormat.OpenXml.Packaging;
using DocumentModel.Properties;
using Microsoft.VisualStudio.TestPlatform.ObjectModel.Client;

namespace DocxDocument.Reader.Test
{
  public class TestReader_ReadProperties
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
    private string[] statisticPropElementsNames = new string[] { "TotalTime", "Characters", "CharactersWithSpaces", 
      "HiddenSlides", "Lines", "MMClips", "Notes", "Pages", "Paragraphs", "Slides", "TotalTime", "Words" };
    private string[] extraPropElementsNames = new string[] { "w14:docId", "w15:docId", "w14:conflictMode" };
    private string[] notSettingsElementsNames = new string[] { "w14:docId", "w15:docId", "w14:conflictMode", "w:rsids" };

    [Test]
    public void TestNormalTemplate()
    {
      var filename = Path.Combine(TestPath, "Normal.dotm");
      TestReadProperties(filename, true);
    }

    [Test]
    public void TestDocumentProperties()
    {
      var filename = Path.Combine(TestPath, "DocumentProperties.docx");
      TestReadProperties(filename, true);
    }

    [Test]
    public void TestCustomProperties()
    {
      var filename = Path.Combine(TestPath, "CustomProperties.docx");
      TestReadProperties(filename, true);
    }

    [Test]
    public void TestReadProperties()
    {
      foreach (var filename in Directory.EnumerateFiles(TestPath, "*.docx"))
        TestReadProperties(filename);
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

      #region Core Document Properties
      CoreProperties? coreDocumentProperties = document.Properties.CoreProperties;
      int origCorePropertiesCount = 0;
      int corePropertiesCount = 0;
      if (coreDocumentProperties != null)
      {
        var coreFilePropertiesPart = reader.WordprocessingDocument.PackageProperties;
        var coreFilePropertiesPartProperties = typeof(PackageProperties).GetProperties();
        foreach (var prop in coreFilePropertiesPartProperties)
        {
          if (prop.GetValue(coreFilePropertiesPart, new object[0]) != null)
            origCorePropertiesCount++;
        }
        var coreProperties = typeof(CoreProperties).GetProperties();
        foreach (var prop in coreProperties.Where(item => item.CanWrite))
          if (prop.GetValue(coreDocumentProperties, null) != null)
            corePropertiesCount++;
        TestContext.Progress.WriteLine(
          $"  CoreProperties: defined {coreProperties.Count()} loaded {corePropertiesCount} expected {origCorePropertiesCount}");
        if (showDetails)
        {
          foreach (var prop in coreProperties.Where(item=>item.CanWrite))
          {
            var value = document.Properties.Get(prop.Name);
            if (value != null)
              TestContext.Progress.WriteLine($"    {prop.Name} = {value}");
          }
        }
      }

      #endregion

      #region ContentDocumentProperties
      ExtendedProperties? contentDocumentProperties = document.Properties.ExtendedProperties;
      int contentPropertiesCount = 0;
      int origContentPropertiesCount = 0;
      if (contentDocumentProperties != null)
      {
        var origExtraFilePropertiesCount = reader.WordprocessingDocument.ExtendedFilePropertiesPart?.Properties?.Count() ?? 0;
        var origStatisticPropertiesCount = reader.WordprocessingDocument.ExtendedFilePropertiesPart?.Properties?.Elements()
          ?.Count(item => statisticPropElementsNames.Contains(item.LocalName)) ?? 0;
        var contentProperties = typeof(ExtendedProperties).GetProperties();
        origContentPropertiesCount = origExtraFilePropertiesCount;// - origStatisticPropertiesCount;
        foreach (var prop in contentProperties.Where(item=>item.CanWrite))
        {
          if (prop.GetValue(contentDocumentProperties, null) != null)
            contentPropertiesCount++;
        }
        TestContext.Progress.WriteLine(
          $"  ContentProperties: defined {contentProperties.Count()} loaded {contentPropertiesCount} expected {origContentPropertiesCount}");
        if (showDetails)
        {
          foreach (var prop in contentProperties.Where(item => item.CanWrite))
          {
            var value = document.Properties.Get(prop.Name);
            if (value != null)
              TestContext.Progress.WriteLine($"    {prop.Name} = {value}");
          }
        }
      }

      #endregion

      //IStatisticDocumentProperties statisticsDocumentProperties = document.Properties as IStatisticDocumentProperties;
      //var statisticProperties = typeof(IStatisticDocumentProperties).GetProperties();
      //int statisticPropertiesCount = 0;
      //foreach (var prop in statisticProperties)
      //  if (prop.GetValue(statisticsDocumentProperties, null) != null)
      //    statisticPropertiesCount++;
      //TestContext.Progress.WriteLine($"  StatisticsProperties: defined {statisticProperties.Count()} loaded {statisticPropertiesCount} expected {origStatisticPropertiesCount}");
      //if (showDetails)
      //{
      //  foreach (var prop in statisticProperties)
      //  {
      //    var value = document.Properties.Get(prop.Name);
      //    if (value != null)
      //      TestContext.Progress.WriteLine($"    {prop.Name} = {value}");
      //  }
      //}

      //IExtraDocumentProperties extraDocumentProperties = document.Properties as IExtraDocumentProperties;
      //var origExtraPropertiesCount = reader.WordprocessingDocument.GetAllParts().OfType<DocumentSettingsPart>().FirstOrDefault()?.Settings?.Elements()
      //  ?.Count(item => extraPropElementsNames.Contains(item.Prefix + ":" + item.LocalName)) ?? 0;
      //var extraProperties = typeof(IExtraDocumentProperties).GetProperties();
      //int extraPropertiesCount = 0;
      //foreach (var prop in extraProperties)
      //{
      //  if (prop.GetValue(extraDocumentProperties, null) != null)
      //    extraPropertiesCount++;
      //}
      //TestContext.Progress.WriteLine($"  ExtraProperties: defined {extraProperties.Count()} loaded {extraPropertiesCount} expected {origExtraPropertiesCount}");
      //if (showDetails)
      //{
      //  foreach (var prop in extraProperties)
      //  {
      //    var value = document.Properties.Get(prop.Name);
      //    if (value != null)
      //      TestContext.Progress.WriteLine($"    {prop.Name} = {value}");
      //  }
      //}

      CustomProperties? customDocumentProperties = document.Properties.CustomProperties;
      int customPropertiesCount = 0;
      int origCustomPropertiesCount = 0;
      if (customDocumentProperties != null)
      {
        customPropertiesCount = customDocumentProperties.Count;
        origCustomPropertiesCount = reader.WordprocessingDocument?.CustomFilePropertiesPart?.Properties.Count() ?? 0;
        TestContext.Progress.WriteLine($"  CustomProperties = {customPropertiesCount}/{origCustomPropertiesCount}");
        if (showDetails)
        {
          foreach (var prop in customDocumentProperties)
          {
            if (prop?.Name != null)
            {
              var value = document.Properties.Get(prop.Name);
              if (value != null)
                TestContext.Progress.WriteLine($"    {prop.Name} = {value}");
            }
          }
        }

      }
      //var revisions = document.Properties.Revisions;
      //var revisionsCount = revisions?.Count ?? 0;
      //if (revisions?.RsidRoot is HexInt)
      //  revisionsCount++;
      //var origRevisionsCount = reader.WordprocessingDocument?.MainDocumentPart?.DocumentSettingsPart?.Settings.GetRsids()?.Count() ?? 0;
      //TestContext.Progress.WriteLine($"  Revisions = {revisionsCount}/{origRevisionsCount}");
      //if (showDetails)
      //{
      //  var value = revisions?.RsidRoot;
      //  if (value != null)
      //    TestContext.Progress.WriteLine($"    RsidRoot = {value}");
      //}

      Assert.That(corePropertiesCount, Is.EqualTo(origCorePropertiesCount), "Invalid core properties count");
      Assert.That(contentPropertiesCount, Is.EqualTo(origContentPropertiesCount), "Invalid content properties count");
      //Assert.That(statisticPropertiesCount, Is.EqualTo(origStatisticPropertiesCount), "Invalid statistic properties count");
      Assert.That(customPropertiesCount, Is.EqualTo(origCustomPropertiesCount), "Invalid custom properties count");
      //Assert.That(extraPropertiesCount, Is.EqualTo(origExtraPropertiesCount), "Invalid extra properties count");
      //Assert.That(revisionsCount, Is.EqualTo(origRevisionsCount), "Invalid revisions count");
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
        var propsListed = false;
        foreach (var prop in typeProperties)
        {
          if (prop.GetIndexParameters().Length == 0)
          {
            if (prop.GetCustomAttribute<XmlIgnoreAttribute>() is null)
            {
              if (prop.PropertyType.Name == "IEnumerable`1")
              {
                propsListed = true;
                var arg = prop.PropertyType.GetGenericArguments().FirstOrDefault();
                ShowEnumerable(prop.Name, prop.GetValue(value, null) as IEnumerable, arg, indent + 1);
              }
              else
              {
                propsListed = true;
                ShowObject(prop.Name, prop.GetValue(value, null), indent + 1);
              }
            }
          }
        }
        if (!propsListed)
        {
          var intfType = value.GetType().GetInterface("IEnumerable`1");
          if (intfType is not null)
          {
            var arg = intfType.GetGenericArguments().FirstOrDefault();
            ShowEnumerable(value as IEnumerable, arg, indent + 1);
          }
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
        ShowObject($"[{itemCount++}] {item.GetType().Name}", item, indent + 1);
    }

    private void ShowEnumerable(IEnumerable? value, Type? itemType, int indent = 0)
    {
      if (value is null)
        return;
      var indentStr = new string(' ', (indent + 2) * 2);
      int itemCount = 0;
      foreach (var item in value)
        ShowObject($"[{itemCount++}] {item.GetType().Name}", item, indent + 1);
    }

  }
}