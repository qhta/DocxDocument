namespace DocumentModel;

/// <summary>
/// Provides helper methods for creating and manipulating Wordprocessing documents using OpenXml.
/// </summary>
public static class WordprocessingHelper
{
  /// <summary>
  /// Creates a new Wordprocessing document at the specified file path.
  /// </summary>
  /// <param name="filename">The file path for the new document.</param>
  /// <returns>A new <c>WordprocessingDocument</c> instance.</returns>
  public static DXPP.WordprocessingDocument CreateWordDocument(string filename)
  {
    // Create a document by supplying the filename. 
    var wordDocument = DXPP.WordprocessingDocument.Create(filename, DX.WordprocessingDocumentType.Document);
    {
      // Add the MainDocumentPart, root Document and the Body.
      var mainPart = wordDocument.AddMainDocumentPart();
      var document = mainPart.Document = new DXW.Document();
      var body = document.AppendChild(new DXW.Body());
    }
    return wordDocument;
  }

  /// <summary>
  /// Opens an existing Wordprocessing document at the specified file path.
  /// </summary>
  /// <param name="filename">The file path of the document to open.</param>
  /// <param name="editable">Specifies whether the document should be opened in editable mode.</param>
  /// <returns>An instance of the <c>WordprocessingDocument</c> class.</returns>
  public static DXPP.WordprocessingDocument OpenWordDocument(string filename, bool editable =true)
  {
    // Create a document by supplying the filename. 
    var wordDocument = DXPP.WordprocessingDocument.Open(filename, editable);
    {
      // Add the MainDocumentPart, root Document and the Body.
      var mainPart = wordDocument.MainDocumentPart ?? wordDocument.AddMainDocumentPart();
      var document = mainPart.Document ?? (mainPart.Document = new DXW.Document());
      var body = document.Body ?? (document.Body = document.AppendChild(new DXW.Body()));
    }
    return wordDocument;
  }

  /// <summary>
  /// Creates a new document from a template file, copying the template and initializing the document structure.
  /// </summary>
  /// <param name="templateFilename">The template file to copy from.</param>
  /// <param name="documentFilename">The output file path for the new document.</param>
  public static void CreateFromTemplate(string templateFilename, string documentFilename)
  {
    // WordprocessingDocument.Create will overwrite an existing file. 
    // If we are using Open we have to delete the file first 
    // if we want to copy that behavior.
    if (File.Exists(documentFilename))
    {
      File.Delete(documentFilename);
    }

    // Copy the template to the output file name.
    File.Copy(templateFilename, documentFilename);

    // Now open the copied file
    using (var wordDocument = DXPP.WordprocessingDocument.Open(documentFilename, true))
    {
      // We need to change the file type from template to document.
      wordDocument.ChangeDocumentType(DX.WordprocessingDocumentType.Document);

      // MainDocumentPart, root Document and Body already exist just access them
      var mainPart = wordDocument.MainDocumentPart ?? wordDocument.AddMainDocumentPart();
      var document = mainPart.Document ?? (mainPart.Document = new DXW.Document());
      var body = document.Body ?? (document.Body = document.AppendChild(new DXW.Body()));

      document.Save();
    }
  }

  /// <summary>
  /// Ensures that the Wordprocessing document is initialized with required parts and properties.
  /// </summary>
  /// <param name="wordDocument">The WordprocessingDocument to initialize.</param>
  public static void EnsureDocumentIsInitialized(this DXPP.WordprocessingDocument wordDocument)
  {
    var mainPart = wordDocument.MainDocumentPart ?? wordDocument.AddMainDocumentPart();
    var document = mainPart.Document ?? (mainPart.Document = new DXW.Document());
    var properties = mainPart.OpenXmlPackage.PackageProperties;
    var contentProperties = wordDocument.ExtendedFilePropertiesPart ?? wordDocument.AddExtendedFilePropertiesPart();
    var body = document.Body ?? (document.Body = document.AppendChild(new DXW.Body()));
  }

#pragma warning disable OOXML0001
  /// <summary>
  /// Retrieves the package properties for the specified Wordprocessing document.
  /// </summary>
  /// <param name="wordDocument">The WordprocessingDocument instance.</param>
  /// <returns>The package properties interface.</returns>
  public static DXPP.IPackageProperties GetPackageProperties(this DXPP.WordprocessingDocument wordDocument)
#pragma warning restore OOXML0001
  {
    var mainPart = wordDocument.MainDocumentPart ?? wordDocument.AddMainDocumentPart();
    var document = mainPart.Document ?? (mainPart.Document = new DXW.Document());
    var properties = mainPart.OpenXmlPackage.PackageProperties;
    return properties;
  }

  /// <summary>
  /// Retrieves the extended file properties part for the specified Wordprocessing document, creating it if necessary.
  /// </summary>
  /// <param name="wordDocument">The WordprocessingDocument instance.</param>
  /// <returns>The extended file properties part.</returns>
  public static DXEP.Properties GetExtendedFileProperties(this DXPP.WordprocessingDocument wordDocument)
  {
    var mainPart = wordDocument.MainDocumentPart ?? wordDocument.AddMainDocumentPart();
    var document = mainPart.Document ?? (mainPart.Document = new DXW.Document());
    DXPP.ExtendedFilePropertiesPart part = wordDocument.ExtendedFilePropertiesPart ?? wordDocument.AddExtendedFilePropertiesPart();
    var properties = part.Properties ?? (part.Properties = new DXEP.Properties());
    return properties;
  }

  /// <summary>
  /// Retrieves the custom file properties part for the specified Wordprocessing document, creating it if necessary.
  /// </summary>
  /// <param name="wordDocument">The WordprocessingDocument instance.</param>
  /// <returns>The custom file properties part.</returns>
  public static DXCP.Properties GetCustomFileProperties(this DXPP.WordprocessingDocument wordDocument)
  {
    var mainPart = wordDocument.MainDocumentPart ?? wordDocument.AddMainDocumentPart();
    var document = mainPart.Document ?? (mainPart.Document = new DXW.Document());
    DXPP.CustomFilePropertiesPart part = wordDocument.CustomFilePropertiesPart ?? wordDocument.AddCustomFilePropertiesPart();
    var properties = part.Properties ?? (part.Properties = new DXCP.Properties());
    return properties;
  }

  /// <summary>
  /// Retrieves the document settings part for the specified Wordprocessing document, creating it if necessary.
  /// </summary>
  /// <param name="wordDocument">The WordprocessingDocument instance.</param>
  /// <returns>The document settings part.</returns>
  public static DXW.Settings GetDocumentSettings(this DXPP.WordprocessingDocument wordDocument)
  {
    var mainPart = wordDocument.MainDocumentPart ?? wordDocument.AddMainDocumentPart();
    var document = mainPart.Document ?? (mainPart.Document = new DXW.Document());
    DXPP.DocumentSettingsPart part = mainPart.DocumentSettingsPart ?? mainPart.AddNewPart<DXPP.DocumentSettingsPart>();
    var settings = part.Settings ?? (part.Settings = new DXW.Settings());
    return settings;
  }
}