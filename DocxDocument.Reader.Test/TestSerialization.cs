using System.Collections;
using System.Reflection;
using System.Xml.Serialization;
using Qhta.Xml.Serialization;

using DocxDocument.Model;

using Qhta.OpenXMLTools;
using System.Xml;
using DocumentFormat.OpenXml.Drawing.Charts;

namespace DocxDocument.Reader.Test
{
  public class TestSerialization
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
      SerializeProperties(filename, true);
      //TestReadSettings(filename, true);
    }

    [Test]
    public void TestProperties()
    {
      //int runCount = 0;
      foreach (var filename in Directory.EnumerateFiles(TestPath, "*.docx"))
        SerializeProperties(filename, Path.GetFileName(filename) == "CustomProperties.docx");
    }

    public void SerializeProperties(string filename, bool showDetails = false)
    {
      TestContext.Progress.WriteLine(filename);
      var reader = new DocxReader(filename);
      var document = reader.ReadDocument(Parts.AllDocumentProperties);
      Assert.IsNotNull(document, "No document read");
      Assert.IsNotNull(document.Properties, "No document properties read");
      Assert.That(document.Properties.Count, Is.GreaterThan(0), "Document properties count is 0");
      var xmlSerializer = new QXmlSerializer(typeof(Document), new SerializationOptions{ });
      var textWriter = new StringWriter();
      var xmlWriter = XmlWriter.Create(textWriter, new XmlWriterSettings { Indent = true });
      xmlSerializer.Serialize(xmlWriter,document);
      TestContext.Out.Write(textWriter.ToString());
    }

    //[Test]
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
        foreach (var setting in document.Settings as IEnumerable<KeyValuePair<string, object?>>)
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
        //var intfType = value.GetType().GetInterface("IEnumerable`1");
        //if (intfType is not null)
        //{
        //  var arg = intfType.GetGenericArguments().FirstOrDefault();
        //  ShowEnumerable(value as IEnumerable, arg, indent + 1);
        //}
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