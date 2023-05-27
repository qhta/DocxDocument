using System.Collections;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

using DocumentFormat.OpenXml.Packaging;

using Qhta.TestHelper;

namespace DocxDocument.ReadWrite.Test;

/// <summary>
/// Base class for all test.
/// </summary>
public class TestBase
{
  /// <summary>
  /// Setups the test path. Can be overriden in descendant classes.
  /// </summary>
  [SetUp]
  public virtual void Setup()
  {
    var testPath = Assembly.GetExecutingAssembly().Location;
    testPath = testPath.Substring(0, testPath.IndexOf(@"\bin")) + @"\SampleDocs";
    //WriteLine(testPath);
    TestPath = testPath;
  }

  /// <summary>
  /// Gets or sets the test path that is used to read/write test data files.
  /// </summary>
  /// <value>
  /// The test path.
  /// </value>
  public string TestPath { get; set; } = string.Empty;

  /// <summary>
  /// Collects and returns the list of document files in the <paramref name="testPath"/>"/>.
  /// All *.docx, *.dotx and *.dotm files are collected.
  /// </summary>
  /// <returns>
  /// List of full filenames.
  /// </returns>
  protected List<string> GetTestFilenames(string testPath)
  {
    var result = Directory.EnumerateFiles(testPath, "*.docx").ToList();
    result.AddRange(Directory.EnumerateFiles(testPath, "*.dotm"));
    result.AddRange(Directory.EnumerateFiles(testPath, "*.dotx"));
    return result;
  }

  /// <summary>
  /// Writes the line to debug output window and test explorer output window.
  /// </summary>
  /// <param name="str">Line of text. Can be empty</param>
  protected void WriteLine(string? str = "")
  {
    Debug.WriteLine(str);
    TestContext.Out.WriteLine(str);
  }

  /// <summary>
  /// Dumps the object to text explorer progress window.
  /// </summary>
  /// <param name="heading">A heading line to write.</param>
  /// <param name="value">The object to dump.</param>
  /// <param name="indent">The indent of text.</param>
  protected void ShowObject(string heading, object? value, int indent = 0)
  {
    if (value is null)
      return;
    var type = value.GetType();
    var indentStr = new string(' ', (indent + 2) * 2);
    if (type.IsClass && type != typeof(string))
    {
      TestContext.Progress.WriteLine(indentStr + $"{heading}");
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
      TestContext.Progress.WriteLine(indentStr + $"{heading} = {value}");
  }

  /// <summary>
  /// Dumps the enumerable collection to test explorer output window.
  /// </summary>
  /// <param name="heading">A heading line to write.</param>
  /// <param name="value">Collection to dump.</param>
  /// <param name="itemType">Type of the collection item.</param>
  /// <param name="indent">The indent of text</param>
  protected void ShowEnumerable(string heading, IEnumerable? value, Type? itemType, int indent = 0)
  {
    if (value is null)
      return;
    var type = value.GetType();
    var arg = type.GetGenericArguments().FirstOrDefault();
    var indentStr = new string(' ', (indent + 2) * 2);
    TestContext.Progress.WriteLine(indentStr + $"{heading}");
    int itemCount = 0;
    foreach (var item in value)
      ShowObject($"[{itemCount++}] {item.GetType().Name}", item, indent + 1);
  }

  /// <summary>
  /// Dumps the enumerable collection to test explorer output window.
  /// </summary>
  /// <param name="value">Collection to dump.</param>
  /// <param name="itemType">Type of the collection item.</param>
  /// <param name="indent">The indent of text</param>
  protected void ShowEnumerable(IEnumerable? value, Type? itemType, int indent = 0)
  {
    if (value is null)
      return;
    var indentStr = new string(' ', (indent + 2) * 2);
    int itemCount = 0;
    foreach (var item in value)
      ShowObject($"[{itemCount++}] {item.GetType().Name}", item, indent + 1);
  }

  /// <summary>
  /// Unpacks file package to filename.unzip folder.
  /// </summary>
  /// <param name="filename">Full package filename to unpack.</param>
  protected void UnzipFile(string filename)
  {
    using (var newPackage = ZipPackage.Open(filename))
    {
      var unzipPath = filename + ".unzip";
      try
      {
        if (Directory.Exists(unzipPath))
          Directory.Delete(unzipPath, true);
      }
      catch
      {
        WriteLine($"Can't delete directory {unzipPath}. Some old files can remain.");
      }
      foreach (var part in newPackage.GetParts())
      {
        var path = filename + ".unzip" + part.Uri.OriginalString.Replace("/", "\\");
        Directory.CreateDirectory(Path.GetDirectoryName(path)!);
        if (Path.GetExtension(path) is ".xml" or ".rels")
        {
          using (var xmlWriter = XmlWriter.Create(path, new XmlWriterSettings
          { Indent = true, NamespaceHandling = NamespaceHandling.OmitDuplicates }))
          {
            var xmlDocument = XDocument.Load(part.GetStream());
            xmlDocument.Save(xmlWriter);
          }
        }
        else
        {
          using (var outStream = File.Create(path))
          {
            var inStream = part.GetStream();
            inStream.CopyTo(outStream);
          }
        }
      }
    }
  }


  /// <summary>
  /// Tests if two directory structures are the same.
  /// </summary>
  /// <param name="origDirectory">Original directory to compare.</param>
  /// <param name="newDirectory">New directory to compare.</param>
  /// <param name="showDetails">Whether to show comparison details</param>
  /// <returns></returns>
  protected bool TestDirectories(string origDirectory, string newDirectory, bool showDetails)
  {
    var ok = CompareDirectories(origDirectory, newDirectory, out var missingFiles, out var excessiveFiles);
    if (!ok)
    {
      if (missingFiles.Count > 0)
      {
        WriteLine("MissingFiles:");
        foreach (var file in missingFiles)
          WriteLine($"  {file}");
      }
      if (excessiveFiles.Count > 0)
      {
        WriteLine("ExcessiveFiles:");
        foreach (var file in excessiveFiles)
          WriteLine($"  {file}");
      }
      return false;
    }
    if (!CompareDirectories(origDirectory, newDirectory, showDetails))
      return false;
    return true;
  }

  /// <summary>
  ///  Compares two directory structures.
  /// </summary>
  /// <param name="origDirectory">Original directory to compare.</param>
  /// <param name="newDirectory">New directory to compare.</param>
  /// <param name="missingFiles">Files existing in original directory that do not exist in new directory.</param>
  /// <param name="excessiveFiles">Files existing in new directory that do not exist in original directory.</param>
  /// <returns></returns>
  protected bool CompareDirectories(string origDirectory, string newDirectory,
    out List<string> missingFiles, out List<string> excessiveFiles)
  {
    missingFiles = new List<string>();
    excessiveFiles = new List<string>();
    return InternalCompareDirectories(origDirectory, newDirectory, missingFiles, excessiveFiles);
  }

  /// <summary>
  ///  Recursive implementation of two directories comparing.
  /// </summary>
  /// <param name="origDirectory">Original directory to compare.</param>
  /// <param name="newDirectory">New directory to compare.</param>
  /// <param name="missingFiles">Files existing in original directory that do not exist in new directory.</param>
  /// <param name="excessiveFiles">Files existing in new directory that do not exist in original directory.</param>
  /// <returns></returns>
  private bool InternalCompareDirectories(string origDirectory, string newDirectory,
    List<string> missingFiles, List<string> excessiveFiles)
  {
    var ok = true;
    var origFiles = Directory.GetFiles(origDirectory).Select(item => Path.GetFileName(item)).ToList();
    var newFiles = Directory.GetFiles(newDirectory).Select(item => Path.GetFileName(item)).ToList();
    origFiles.Sort();
    newFiles.Sort();
    foreach (var origFile in origFiles)
      if (!newFiles.Contains(origFile))
      {
        missingFiles.Add(Path.Combine(newDirectory, origFile));
        ok = false;
      }
    foreach (var newFile in newFiles)
      if (!origFiles.Contains(newFile))
      {
        excessiveFiles.Add(Path.Combine(newDirectory, newFile));
        ok = false;
      }
    var origDirs = Directory.GetDirectories(origDirectory).Select(item => Path.GetFileName(item)).ToList();
    var newDirs = Directory.GetDirectories(newDirectory).Select(item => Path.GetFileName(item)).ToList();
    origDirs.Sort();
    newDirs.Sort();
    foreach (var origDir in origDirs)
      if (!newDirs.Contains(origDir))
      {
        missingFiles.Add(Path.Combine(newDirectory, origDir));
        ok = false;
      }
      else
        if (!InternalCompareDirectories(Path.Combine(origDirectory, origDir),
          Path.Combine(newDirectory, origDir), missingFiles, excessiveFiles))
        ok = false;
    foreach (var newDir in newDirs)
      if (!origDirs.Contains(newDir))
      {
        excessiveFiles.Add(Path.Combine(newDirectory, newDir));
        ok = false;
      }
    return ok;
  }

  /// <summary>
  ///  Compares files in directory structures.
  /// </summary>
  /// <param name="origDirectory">Original directory to compare.</param>
  /// <param name="newDirectory">New directory to compare.</param>
  /// <param name="showDetails">Whether to show comparison details</param>
  /// <returns></returns>
  protected bool CompareDirectories(string origDirectory, string newDirectory, bool showDetails)
  {
    var origFiles = Directory.GetFiles(origDirectory).Select(item => Path.GetFileName(item)).ToList();
    var newFiles = Directory.GetFiles(newDirectory).Select(item => Path.GetFileName(item)).ToList();
    origFiles.Sort();
    newFiles.Sort();
    foreach (var origFile in origFiles)
    {
      var origFilePath = Path.Combine(origDirectory, origFile);
      var newFilePath = Path.Combine(newDirectory, origFile);
      if (!CompareFiles(origFilePath, newFilePath, showDetails))
        return false;
    }
    var origDirs = Directory.GetDirectories(origDirectory).Select(item => Path.GetFileName(item)).ToList();
    var newDirs = Directory.GetDirectories(newDirectory).Select(item => Path.GetFileName(item)).ToList();
    origDirs.Sort();
    newDirs.Sort();
    foreach (var origDir in origDirs)
      if (!CompareDirectories(Path.Combine(origDirectory, origDir),
        Path.Combine(newDirectory, origDir), showDetails))
      {
        return false;
      }
    return true;
  }

  /// <summary>
  ///  Compares pair of files.
  /// </summary>
  /// <param name="origFilePath">Original file to compare.</param>
  /// <param name="newFilePath">New file to compare.</param>
  /// <param name="showDetails">Whether to show comparison details</param>
  /// <returns></returns>
  private bool CompareFiles(string origFilePath, string newFilePath, bool showDetails)
  {
    var ok = true;
    TraceTextWriter? traceWriter = null;
    traceWriter = new TraceTextWriter(true, true, true);
    var ext = Path.GetExtension(newFilePath);
    if (ext == ".xml" || ext == ".rels")
    {
      var xmlComparer = new XmlFileComparer(new FileCompareOptions(), traceWriter);
      var startOfFileMsg = $"Verifying {newFilePath.Substring(TestPath.Length + 1)}";
      if (showDetails) 
        traceWriter?.WriteLine(startOfFileMsg);
      else
        xmlComparer.Options.StartOfFile = startOfFileMsg;
      if (!xmlComparer.CompareFiles(newFilePath, origFilePath))
      {
        return false;
      }
    }
    return ok;
  }

  /// <summary>
  /// Random generator
  /// </summary>
  protected Random Rnd = new Random();

  private static int[] MonthDays = new[] { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
  /// <summary>
  /// Helper method to generate random date-time value.
  /// </summary>
  /// <returns></returns>
  protected DateTime RandomDateTime()
  {
    var year = Rnd.Next(2000, 2025);
    var month = Rnd.Next(1, 12);
    var day = Rnd.Next(1, MonthDays[month - 1]);
    var hour = Rnd.Next(0, 23);
    var min = Rnd.Next(0, 59);
    var sec = Rnd.Next(0, 59);
    var ms = Rnd.Next(0, 999);
    return new DateTime(year, month, day, hour, min, sec, ms);
  }

  /// <summary>
  /// Creates empty wordprocessing document
  /// </summary>
  /// <param name="filepath"></param>
  public static void CreateWordprocessingDocument(string filepath)
  {
    // Create a document by supplying the filepath. 
    using (WordprocessingDocument wordprocessingDocument =
        WordprocessingDocument.Create(filepath, DX.WordprocessingDocumentType.Document))
    {
      // Add a main document part. 
      MainDocumentPart mainPart = wordprocessingDocument.AddMainDocumentPart();

      // Create the document structure and add some text.
      mainPart.Document = new DXW.Document();
      var body = mainPart.Document.AppendChild(new DXW.Body());
      CoreFilePropertiesPart coreFilePropPart = wordprocessingDocument.AddCoreFilePropertiesPart();
      using (var writer = new XmlTextWriter(coreFilePropPart.GetStream(FileMode.Create), System.Text.Encoding.UTF8))
      {
        var dt = DateTime.Now;
        var dts = dt.ToString("yyyy-MM-ddThh:mm:00Z");
        writer.WriteRaw("<?xml version=\"1.0\" encoding=\"utf-8\" standalone=\"yes\"?>\r\n" +
          "<cp:coreProperties xmlns:cp=\"http://schemas.openxmlformats.org/package/2006/metadata/core-properties\"" +
          " xmlns:dc=\"http://purl.org/dc/elements/1.1/\" xmlns:dcterms=\"http://purl.org/dc/terms/\"" +
          " xmlns:dcmitype=\"http://purl.org/dc/dcmitype/\" xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\">\r\n" +
          $"  <dcterms:created xsi:type=\"dcterms:W3CDTF\">{dts}</dcterms:created>\r\n" +
          $"  <dcterms:modified xsi:type=\"dcterms:W3CDTF\">{dts}</dcterms:modified>\r\n" +

          "</cp:coreProperties>");
        writer.Flush();
      }
    }
  }


}