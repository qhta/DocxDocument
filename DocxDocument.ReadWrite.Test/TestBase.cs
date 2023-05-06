using System.Collections;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Reflection;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

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
      Directory.Delete(unzipPath, true);
      foreach (var part in newPackage.GetParts())
      {
        var path = filename + ".unzip" + part.Uri.OriginalString.Replace("/", "\\");
        Directory.CreateDirectory(Path.GetDirectoryName(path)!);
        if (Path.GetExtension(path) is ".xml" or ".rels")
        {
          using (var xmlWriter = XmlWriter.Create(path, new XmlWriterSettings { Indent = true }))
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
    if (!CompareFiles(origDirectory, newDirectory, showDetails))
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
  protected bool CompareFiles(string origDirectory, string newDirectory, bool showDetails)
  {
    TraceTextWriter? traceWriter = null;
    if (showDetails)
    {
      traceWriter = new TraceTextWriter(true, true);
    }
    var xmlComparer = new XmlFileComparer(new FileCompareOptions(), traceWriter);
    return InternalCompareFiles(origDirectory, newDirectory, xmlComparer, showDetails);
  }

  /// <summary>
  ///  Compares files in directory structures.
  /// </summary>
  /// <param name="origDirectory">Original directory to compare.</param>
  /// <param name="newDirectory">New directory to compare.</param>
  /// <param name="xmlComparer">Comparer for XmlFiles</param>
  /// <param name="showDetails">Whether to show comparison details</param>
  /// <returns></returns>
  private bool InternalCompareFiles(string origDirectory, string newDirectory, XmlFileComparer xmlComparer, bool showDetails)
  {
    var ok = true;
    var origFiles = Directory.GetFiles(origDirectory).Select(item => Path.GetFileName(item)).ToList();
    var newFiles = Directory.GetFiles(newDirectory).Select(item => Path.GetFileName(item)).ToList();
    origFiles.Sort();
    newFiles.Sort();
    foreach (var origFile in origFiles)
    {
      var origFilePath = Path.Combine(origDirectory, origFile);
      var newFilePath = Path.Combine(newDirectory, origFile);
      if (showDetails)
        xmlComparer.Writer?.WriteLine($"Verifying {newFilePath.Substring(TestPath.Length + 1)}");

      if (!xmlComparer.CompareFiles(newFilePath, origFilePath))
      {
        ok = false;
        return false;
      }
    }
    var origDirs = Directory.GetDirectories(origDirectory).Select(item => Path.GetFileName(item)).ToList();
    var newDirs = Directory.GetDirectories(newDirectory).Select(item => Path.GetFileName(item)).ToList();
    origDirs.Sort();
    newDirs.Sort();
    foreach (var origDir in origDirs)
      if (!InternalCompareFiles(Path.Combine(origDirectory, origDir),
        Path.Combine(newDirectory, origDir), xmlComparer, showDetails))
      {
        ok = false;
        return false;
      }
    return ok;
  }

}