using System.Collections;
using System.IO.Packaging;
using System.Reflection;
using System.Xml.Serialization;

using DocumentFormat.OpenXml.Packaging;
using DocumentModel.Properties;
using Microsoft.VisualStudio.TestPlatform.ObjectModel.Client;

namespace DocxDocument.Reader.Test
{
  public class TestSettings: TestBase
  {

    [Test]
    public void TestNormalTemplateSettings()
    {
      var filename = Path.Combine(TestPath, "Normal.dotm");
      ProcessSettings(filename, true);
    }

    [Test]
    public void TestDocumentSettings()
    {
      var filename = Path.Combine(TestPath, "DocumentProperties.docx");
      ProcessSettings(filename, true);
    }

    [Test]
    public void TestCustomSettings()
    {
      var filename = Path.Combine(TestPath, "CustomProperties.docx");
      ProcessSettings(filename, true);
    }

    [Test]
    public void TestSampleDocsSettings()
    {
      foreach (var filename in Directory.EnumerateFiles(TestPath, "*.docx"))
        ProcessSettings(filename);
    }

    public virtual DocumentModel.Wordprocessing.Document ProcessSettings(string filename, bool showDetails = false)
    {
      TestContext.Progress.WriteLine(filename);
      var reader = new DocxReader(filename);
      var document = reader.ReadDocument(Parts.AllDocumentSettings);
      Assert.IsNotNull(document, "No document read");
      Assert.IsNotNull(document.Settings, "No document properties read");
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

      Assert.That(corePropertiesCount, Is.EqualTo(origCorePropertiesCount), "Invalid core properties count");
      Assert.That(contentPropertiesCount, Is.EqualTo(origContentPropertiesCount), "Invalid content properties count");
      Assert.That(customPropertiesCount, Is.EqualTo(origCustomPropertiesCount), "Invalid custom properties count");
      return document;
    }



  }
}