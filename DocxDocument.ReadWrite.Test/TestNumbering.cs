using DocumentModel.Wordprocessing;

namespace DocxDocument.ReadWrite.Test;

/// <summary>
/// Test class for document numbering.
/// </summary>
/// <seealso cref="DocxDocument.ReadWrite.Test.TestBase" />
public class TestNumbering : TestBase
{

  /// <summary>
  /// Tests the numbering read from all docx files in folder specified by test path.
  /// </summary>
  [Test(ExpectedResult = true)]
  public bool TestReadNumbering()
  {
    foreach (var filename in GetTestFilenames(TestPath))
      if (!TestReadNumbering(filename, false, true, false))
        return false;
    return true;
  }

  /// <summary>
  /// Tests the numbering read from the specified docx file.
  /// </summary>
  /// <param name="filename">The filename of the document to read.</param>
  /// <param name="showDetails">Specifies whether the detailed information on test should be shown on test failure.</param>
  /// <param name="copyBack">Specifies whether test document should be copied back and modified with deserialized data</param>
  /// <param name="openWord">Specifies that new document should be opened in MS Word</param>
  public virtual bool TestReadNumbering(string filename, bool showDetails = false, bool copyBack = false, bool openWord = false)
  {
    if (String.IsNullOrEmpty(Path.GetDirectoryName(filename)))
      filename = Path.Combine(TestPath, filename);
    string newFilename = null!;
    var ok = true;
    DMW.Document document;
    #region test read
    WriteLine($"Testing read numbering of: {filename}");
    using (var reader = new DocxReader(filename))
    {
      document = reader.GetDocument(PartsMask.NumberingDefinitions);
      Assert.IsNotNull(document, "No document read");
      Assert.IsNotNull(document.Numbering, "No document numbering read");
      var modelNumbering = document.Numbering;
      var origNumbering = reader.WordprocessingDocument.MainDocumentPart?.NumberingDefinitionsPart?.Numbering;
      if (origNumbering != null)
      {
        var diffs = new DiffList();
        diffs.AddDiff += Diffs_AddDiff;
        ok = DMXW.NumberingConverter.CompareModelElement(origNumbering, modelNumbering, diffs, null, null);
        if (!ok && showDetails)
        {
          WriteLine("Read numbering differences found:");
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
      var oldNumbering = document.Numbering ?? new();
      Assert.IsNotNull(oldNumbering, "No document numbering read");
      if (oldNumbering == null)
        return false;
      var textWriter = new StringWriter();
      var extraTypes = Assembly.Load("DocumentModel").GetTypes()
        .Where(item => item.IsPublic && !item.IsGenericType).ToArray();
      var serializer = new QXmlSerializer(typeof(DMW.Numbering), extraTypes.ToArray(),
        new SerializationOptions { AcceptAllProperties = true });
      try
      {
        serializer.Serialize(textWriter, oldNumbering);
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
      var newNumbering = (Numbering?)serializer.Deserialize(textReader);
      Assert.IsNotNull(newNumbering, $"Deserialized numbering are null");
      var diffs = new DiffList();
      diffs.AddDiff += Diffs_AddDiff;
      ok = DeepComparer.IsEqual(oldNumbering, newNumbering, diffs);
      if (!ok && showDetails)
      {
        WriteLine("Read numbering differences found:");
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
          writer.SetNumbering(newNumbering);
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
