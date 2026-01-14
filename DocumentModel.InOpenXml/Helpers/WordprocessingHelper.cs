namespace DocumentModel;

public static class WordprocessingHelper
{
  public static DXPP.WordprocessingDocument CreateWordDocument(string filename)
  {
    // Create a document by supplying the filename. 
    var wordDocument = DXPP.WordprocessingDocument.Create(filename, OpenXml.WordprocessingDocumentType.Document);
    {
      // Add the MainDocumentPart, root Document and the Body.
      var mainPart = wordDocument.AddMainDocumentPart();
      var document = mainPart.Document = new DXWP.Document();
      var body = document.AppendChild(new DXWP.Body());

    }
    return wordDocument;
  }

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
      wordDocument.ChangeDocumentType(OpenXml.WordprocessingDocumentType.Document);

      // MainDocumentPart, root Document and Body already exist just access them
      var mainPart = wordDocument.MainDocumentPart ?? wordDocument.AddMainDocumentPart();
      var document = mainPart.Document ?? (mainPart.Document = new DXWP.Document());
      var body = document.Body ?? (document.Body = document.AppendChild(new DXWP.Body()));

      document.Save();
    }
  }

  public static void EnsureDocumentIsInitialized(this DXPP.WordprocessingDocument wordDocument)
  {
    var mainPart = wordDocument.MainDocumentPart ?? wordDocument.AddMainDocumentPart();
    var document = mainPart.Document ?? (mainPart.Document = new DXWP.Document());
    var properties = mainPart.OpenXmlPackage.PackageProperties;
    var contentProperties = wordDocument.ExtendedFilePropertiesPart ?? wordDocument.AddExtendedFilePropertiesPart();
    var body = document.Body ?? (document.Body = document.AppendChild(new DXWP.Body()));
  }

#pragma warning disable OOXML0001
  public static DXPP.IPackageProperties GetPackageProperties(this DXPP.WordprocessingDocument wordDocument)
#pragma warning restore OOXML0001
  {
    var mainPart = wordDocument.MainDocumentPart ?? wordDocument.AddMainDocumentPart();
    var document = mainPart.Document ?? (mainPart.Document = new DXWP.Document());
    var properties = mainPart.OpenXmlPackage.PackageProperties;
    return properties;
  }

  public static DXEP.Properties GetExtendedFileProperties(this DXPP.WordprocessingDocument wordDocument)
  {
    var mainPart = wordDocument.MainDocumentPart ?? wordDocument.AddMainDocumentPart();
    var document = mainPart.Document ?? (mainPart.Document = new DXWP.Document());
    DXPP.ExtendedFilePropertiesPart part = wordDocument.ExtendedFilePropertiesPart ?? wordDocument.AddExtendedFilePropertiesPart();
    var properties = part.Properties ?? (part.Properties = new DXEP.Properties());
    return properties;
  }

  public static DXCP.Properties GetCustomFileProperties(this DXPP.WordprocessingDocument wordDocument)
  {
    var mainPart = wordDocument.MainDocumentPart ?? wordDocument.AddMainDocumentPart();
    var document = mainPart.Document ?? (mainPart.Document = new DXWP.Document());
    DXPP.CustomFilePropertiesPart part = wordDocument.CustomFilePropertiesPart ?? wordDocument.AddCustomFilePropertiesPart();
    var properties = part.Properties ?? (part.Properties = new DXCP.Properties());
    return properties;
  }

  public static DXWP.Settings GetDocumentSettings(this DXPP.WordprocessingDocument wordDocument)
  {
    var mainPart = wordDocument.MainDocumentPart ?? wordDocument.AddMainDocumentPart();
    var document = mainPart.Document ?? (mainPart.Document = new DXWP.Document());
    DXPP.DocumentSettingsPart part = mainPart.DocumentSettingsPart ?? mainPart.AddNewPart<DXPP.DocumentSettingsPart>();
    var settings = part.Settings ?? (part.Settings = new DXWP.Settings());
    return settings;
  }
}