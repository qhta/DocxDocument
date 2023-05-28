using DocumentModel.OpenXml.Drawings;

namespace DocxDocument.ReadWrite.Test;

/// <summary>
/// Test class for document theme part.
/// </summary>
/// <seealso cref="DocxDocument.ReadWrite.Test.TestBase" />
public class TestTheme : TestBase
{

  /// <summary>
  /// Tests the theme read from all docx files in folder specified by test path.
  /// </summary>
  [Test(ExpectedResult = true)]
  public bool TestReadTheme()
  {
    foreach (var filename in GetTestFilenames(TestPath))
      if (!TestReadTheme(filename, false, true, false))
        return false;
    return true;
  }

  /// <summary>
  /// Tests the theme read from the specified docx file.
  /// </summary>
  /// <param name="filename">The filename of the document to read.</param>
  /// <param name="showDetails">Specifies whether the detailed information on test should be shown on test failure.</param>
  /// <param name="copyBack">Specifies whether test document should be copied back and modified with deserialized data</param>
  /// <param name="openWord">Specifies that new document should be opened in MS Word</param>
  public virtual bool TestReadTheme(string filename, bool showDetails = false, bool copyBack = false, bool openWord = false)
  {
    if (String.IsNullOrEmpty(Path.GetDirectoryName(filename)))
      filename = Path.Combine(TestPath, filename);
    string newFilename = null!;
    var ok = true;
    DMW.Document document;
    #region test read
    WriteLine($"Testing read theme of: {filename}");
    using (var reader = new DocxReader(filename))
    {
      document = reader.GetDocument(PartsMask.Theme);
      Assert.IsNotNull(document, "No document read");
      Assert.IsNotNull(document.Theme, "No document theme read");
      var modelTheme = document.Theme;
      var origTheme = reader.WordprocessingDocument.MainDocumentPart?.ThemePart?.Theme;
      if (origTheme != null)
      {
        var diffs = new DiffList();
        diffs.AddDiff += Diffs_AddDiff;
        ok = DMXD.ThemeConverter.CompareModelElement(origTheme, modelTheme, diffs, null, null);
        if (!ok && showDetails)
        {
          WriteLine("Read theme differences found:");
          foreach (var diff in diffs)
            WriteLine(diff.ToString());
        }
        if (!ok)
          Assert.Fail(diffs.FirstOrDefault()?.ToString());
      }
    }
    #endregion
    if (ok)
    {
      #region serialization
      var oldTheme = document.Theme ?? new();
      Assert.IsNotNull(oldTheme, "No document theme read");
      if (oldTheme == null)
        return false;
      var textWriter = new StringWriter();
      var extraTypes = Assembly.Load("DocumentModel").GetTypes()
        .Where(item => item.IsPublic && !item.IsGenericType).ToArray();
      var serializer = new QXmlSerializer(typeof(DMD.Theme), extraTypes.ToArray(),
        new SerializationOptions { AcceptAllProperties = true });
      try
      {
        serializer.Serialize(textWriter, oldTheme);
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
      var newTheme = (DMD.Theme?)serializer.Deserialize(textReader);
      Assert.IsNotNull(newTheme, $"Deserialized theme are null");
      var diffs = new DiffList();
      diffs.AddDiff += Diffs_AddDiff;
      ok = DeepComparer.IsEqual(oldTheme, newTheme, diffs);
      if (!ok && showDetails)
      {
        WriteLine("Read theme differences found:");
        foreach (var diff in diffs)
          WriteLine(diff.ToString());
      }
      if (!ok)
        Assert.Fail(diffs.FirstOrDefault()?.ToString());
      #endregion
      if (ok && copyBack)
      {
        #region copy back
        if (String.IsNullOrEmpty(Path.GetDirectoryName(filename)))
          filename = Path.Combine(TestPath, filename);
        newFilename = Path.Combine(Path.Combine(Path.GetDirectoryName(filename) ?? "", "BackCopy"),
          Path.GetFileNameWithoutExtension(filename) + ".new" + Path.GetExtension(filename));
        File.Copy(filename, newFilename, true);
        using (var writer = DocxWriter.Open(newFilename))
        {
          writer.SetTheme(newTheme);
        }
        UnzipFile(filename);
        UnzipFile(newFilename);
        ok = TestDirectories(filename + ".unzip", newFilename + ".unzip", showDetails);
        #endregion

        if (ok && openWord)
        {
          #region openWord
          var processStartInfo = new ProcessStartInfo("C:\\Program Files\\Microsoft Office\\root\\Office16\\WINWORD.EXE", "\"" + newFilename + "\"");
          Process.Start(processStartInfo);
          #endregion
        }
      }
    }
    return ok;
  }

  private void Diffs_AddDiff(DiffList sender, Diff diff)
  {
    Assert.Fail(diff.ToString());
  }
}
