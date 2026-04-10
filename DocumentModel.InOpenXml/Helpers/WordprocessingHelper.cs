namespace DocumentModel;
/// <summary>
/// Provides helper methods for creating and manipulating Wordprocessing documents using OpenXml.
/// </summary>
[XmlRoot("WordprocessingHelper", Namespace = "DocumentModel")]
public static class WordprocessingHelper
{
 /// <summary>
 /// Creates a new Wordprocessing document at the specified file path.
 /// </summary>
 /// <param name = "filename">The file path for the new document.</param>
 /// <returns>A new <c>Document</c> instance.</returns>
 public static DXPP.WordprocessingDocument CreateWordDocument(string filename)
 {
  // Create a document by supplying the filename. 
  var wordDocument = DXPP.WordprocessingDocument.Create(filename, DX.WordprocessingDocumentType.Document);
  {
   // Add the MainDocumentPart, root Document and the Body.
   var mainPart = wordDocument.AddMainDocumentPart();
   var properties = mainPart.OpenXmlPackage.PackageProperties;
   var document = mainPart.Document = new DXW.Document();
   var body = document.AppendChild(new DXW.Body());
  }

  return wordDocument;
 }

 /// <summary>
 /// Opens an existing Wordprocessing document at the specified file path.
 /// </summary>
 /// <param name = "filename">The file path of the document to open.</param>
 /// <param name = "editable">Specifies whether the document should be opened in editable mode.</param>
 /// <returns>An instance of the <c>Document</c> class.</returns>
 public static DXPP.WordprocessingDocument OpenWordDocument(string filename, bool editable = true)
 {
  var wordDocument = DXPP.WordprocessingDocument.Open(filename, editable);
  InitWordprocessingDocument(wordDocument);
  return wordDocument;
 }

 /// <summary>
 /// Opens an existing Wordprocessing document at the specified file path.
 /// </summary>
 /// <param name = "stream">The stream of the document to open.</param>
 /// <param name = "editable">Specifies whether the document should be opened in editable mode.</param>
 /// <returns>An instance of the <c>Document</c> class.</returns>
 public static DXPP.WordprocessingDocument OpenWordDocument(Stream stream, bool editable = true)
 {
  var wordDocument = DXPP.WordprocessingDocument.Open(stream, editable);
  InitWordprocessingDocument(wordDocument);
  return wordDocument;
 }

 /// <summary>
 /// Initializes the specified WordprocessingDocument by ensuring that the main document part, root document, and body
 /// are present.
 /// </summary>
 /// <remarks>Call this method before adding content to a WordprocessingDocument to guarantee that the document
 /// structure is properly set up. If the main document part, document, or body does not exist, they will be
 /// created.</remarks>
 /// <param name = "wordDocument">The WordprocessingDocument to initialize. Cannot be null.</param>
 private static void InitWordprocessingDocument(DXPP.WordprocessingDocument wordDocument)
 {
  // Add the MainDocumentPart, root Document and the Body.
  var mainPart = wordDocument.MainDocumentPart ?? wordDocument.AddMainDocumentPart();
  var packageProperties = wordDocument.GetPackageProperties();
  var document = mainPart.Document ?? (mainPart.Document = new DXW.Document());
  var body = document.Body ?? (document.Body = document.AppendChild(new DXW.Body()));
 }

 /// <summary>
 /// Creates a new document from a template file, copying the template and initializing the document structure.
 /// </summary>
 /// <param name = "templateFilename">The template file to copy from.</param>
 /// <param name = "documentFilename">The output file path for the new document.</param>
 public static void CreateFromTemplate(string templateFilename, string documentFilename)
 {
  // Document.Create will overwrite an existing file. 
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
 /// <param name = "wordDocument">The Document to initialize.</param>
 public static void EnsureDocumentIsInitialized(this DXPP.WordprocessingDocument wordDocument)
 {
  var mainPart = wordDocument.MainDocumentPart ?? wordDocument.AddMainDocumentPart();
  var document = mainPart.Document ?? (mainPart.Document = new DXW.Document());
  var properties = mainPart.OpenXmlPackage.PackageProperties;
  var contentProperties = wordDocument.ExtendedFilePropertiesPart ?? wordDocument.AddExtendedFilePropertiesPart();
  var body = document.Body ?? (document.Body = document.AppendChild(new DXW.Body()));
 }

 /// <summary>
 /// Retrieves the main document part of the specified Document, creating it if it does not already
 /// exist.
 /// </summary>
 /// <remarks>If the main document part or its root Document element does not exist, they are created
 /// automatically. This ensures that the returned MainDocumentPart is always initialized and ready for use.</remarks>
 /// <param name = "wordDocument">The Document from which to retrieve or create the main document part. Cannot be null.</param>
 /// <returns>The MainDocumentPart associated with the specified Document. If the main document part does not
 /// exist, a new one is created and returned.</returns>
 public static DXPP.MainDocumentPart GetMainDocumentPart(this DXPP.WordprocessingDocument wordDocument)
 {
  var mainPart = wordDocument.MainDocumentPart ?? wordDocument.AddMainDocumentPart();
  var document = mainPart.Document ?? (mainPart.Document = new DXW.Document());
  return mainPart;
 }

#pragma warning disable OOXML0001
 /// <summary>
 /// Retrieves the package properties for the specified Wordprocessing document.
 /// </summary>
 /// <param name = "wordDocument">The Document instance.</param>
 /// <returns>The package properties class.</returns>
 public static DXPP.IPackageProperties GetPackageProperties(this DXPP.WordprocessingDocument wordDocument)
 {
  var mainPart = wordDocument.MainDocumentPart ?? wordDocument.AddMainDocumentPart();
  var document = mainPart.Document ?? (mainPart.Document = new DXW.Document());
  var properties = mainPart.OpenXmlPackage.PackageProperties;
  return properties;
 }

 /// <summary>
 /// Retrieves the core file properties for the specified Wordprocessing document.
 /// </summary>
 /// <param name = "wordDocument">The Document instance.</param>
 /// <returns>The core file properties class.</returns>
 public static DXPP.IPackageProperties GetCoreProperties(this DXPP.WordprocessingDocument wordDocument)
 {
  var coreFilePropertiesPart = wordDocument.CoreFilePropertiesPart ?? wordDocument.AddCoreFilePropertiesPart();
  var properties = coreFilePropertiesPart.RootElement as DXPP.IPackageProperties;
  if (properties == null)
  {
   using var stream = coreFilePropertiesPart.GetStream(FileMode.Create, FileAccess.Write);
   using var writer = new StreamWriter(stream, System.Text.Encoding.UTF8);
   writer.Write("<cp:coreProperties xmlns:cp=\"http://schemas.openxmlformats.org/package/2006/metadata/core-properties\" " + "xmlns:dc=\"http://purl.org/dc/elements/1.1/\" " + "xmlns:dcterms=\"http://purl.org/dc/terms/\" " + "xmlns:dcmitype=\"http://purl.org/dc/dcmitype/\" " + "xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\">" + "</cp:coreProperties>");
   coreFilePropertiesPart.UnloadRootElement();
   properties = coreFilePropertiesPart.CoreFileProperties;
  }

  return properties;
 }

 /// <summary>
 /// Retrieves the extended file properties for the specified Wordprocessing document, creating it if necessary.
 /// </summary>
 /// <param name = "wordDocument">The Document instance.</param>
 /// <returns>The extended file properties element.</returns>
 public static DXEP.Properties GetExtendedFileProperties(this DXPP.WordprocessingDocument wordDocument)
 {
  var mainPart = wordDocument.MainDocumentPart ?? wordDocument.AddMainDocumentPart();
  var document = mainPart.Document ?? (mainPart.Document = new DXW.Document());
  DXPP.ExtendedFilePropertiesPart part = wordDocument.ExtendedFilePropertiesPart ?? wordDocument.AddExtendedFilePropertiesPart();
  var properties = part.Properties ?? (part.Properties = new DXEP.Properties());
  return properties;
 }

 /// <summary>
 /// Retrieves the custom file properties for the specified Wordprocessing document, creating it if necessary.
 /// </summary>
 /// <param name = "wordDocument">The Document instance.</param>
 /// <returns>The custom file properties element.</returns>
 public static DXCP.Properties GetCustomFileProperties(this DXPP.WordprocessingDocument wordDocument)
 {
  var mainPart = wordDocument.MainDocumentPart ?? wordDocument.AddMainDocumentPart();
  var document = mainPart.Document ?? (mainPart.Document = new DXW.Document());
  DXPP.CustomFilePropertiesPart part = wordDocument.CustomFilePropertiesPart ?? wordDocument.AddCustomFilePropertiesPart();
  var properties = part.Properties ?? (part.Properties = new DXCP.Properties());
  return properties;
 }

 /// <summary>
 /// Retrieves the document settings for the specified Wordprocessing document, creating it if necessary.
 /// </summary>
 /// <param name = "wordDocument">The Document instance.</param>
 /// <returns>The document settings element.</returns>
 public static DXW.Settings GetDocumentSettings(this DXPP.WordprocessingDocument wordDocument)
 {
  var mainPart = wordDocument.MainDocumentPart ?? wordDocument.AddMainDocumentPart();
  var document = mainPart.Document ?? (mainPart.Document = new DXW.Document());
  DXPP.DocumentSettingsPart part = mainPart.DocumentSettingsPart ?? mainPart.AddNewPart<DXPP.DocumentSettingsPart>();
  var settings = part.Settings ?? (part.Settings = new DXW.Settings());
  return settings;
 }

 /// <summary>
 /// Retrieves the reference relationship with the specified relationship ID from the main document part of the given
 /// Document.
 /// </summary>
 /// <remarks>If the main document part does not exist, it is created before attempting to retrieve the
 /// relationship.</remarks>
 /// <param name = "wordDocument">The Document instance from which to retrieve the main document part relationship. Cannot be null.</param>
 /// <param name = "relationshipId">The unique identifier of the relationship to retrieve from the main document part. Cannot be null or empty.</param>
 /// <returns>A ReferenceRelationship object representing the relationship with the specified ID, or null if no such
 /// relationship exists.</returns>
 public static DXPP.ReferenceRelationship GetMainDocumentPartRelationship(this DXPP.WordprocessingDocument wordDocument, string relationshipId)
 {
  var mainPart = wordDocument.MainDocumentPart ?? wordDocument.AddMainDocumentPart();
  var relationship = mainPart.GetReferenceRelationship(relationshipId);
  return relationship;
 }

 /// <summary>
 /// Retrieves the external relationship with the specified relationship ID from the main document part of the given
 /// Document.
 /// </summary>
 /// <remarks>If the main document part does not exist, it is created before attempting to retrieve the
 /// external relationship.</remarks>
 /// <param name = "wordDocument">The Document instance from which to retrieve the main document part external relationship. Cannot be
 /// null.</param>
 /// <param name = "relationshipId">The unique identifier of the external relationship to retrieve. Cannot be null or empty.</param>
 /// <returns>The ExternalRelationship object associated with the specified relationship ID, or null if no such relationship
 /// exists.</returns>
 public static DXPP.ExternalRelationship GetMainDocumentPartExternalRelationship(this DXPP.WordprocessingDocument wordDocument, string relationshipId)
 {
  var mainPart = wordDocument.MainDocumentPart ?? wordDocument.AddMainDocumentPart();
  var relationship = mainPart.GetExternalRelationship(relationshipId);
  return relationship;
 }

 /// <summary>
 /// Creates an external relationship for the main document part of the specified Document using the
 /// given relationship ID and target URI.
 /// </summary>
 /// <remarks>If the Document does not already contain a main document part, one is created
 /// automatically before adding the external relationship.</remarks>
 /// <param name = "wordDocument">The Document to which the external relationship will be added. Cannot be null.</param>
 /// <param name = "relationshipId">The unique identifier for the external relationship to create. Must not be null or empty.</param>
 /// <param name = "uri">The target URI of the external resource to associate with the main document part. Must be a valid URI string.</param>
 /// <returns>An ExternalRelationship object representing the newly created external relationship for the main document part.</returns>
 public static DXPP.ExternalRelationship CreateMainDocumentPartExternalRelationship(this DXPP.WordprocessingDocument wordDocument, string relationshipId, string uri)
 {
  var mainPart = wordDocument.MainDocumentPart ?? wordDocument.AddMainDocumentPart();
  var relationship = mainPart.AddExternalRelationship(relationshipId, new Uri(uri));
  return relationship;
 }

 /// <summary>
 /// Gets the OpenXmlPart associated with the specified OpenXmlElement, if available.
 /// </summary>
 /// <param name = "element">The OpenXmlElement for which to retrieve the associated OpenXmlPart.</param>
 /// <returns>The OpenXmlPart that contains the specified element, or null if the element is not part of an OpenXmlPart.</returns>
 public static DXPP.OpenXmlPart? GetOpenXmlPart(this DX.OpenXmlElement element)
 {
  var root = element.GetRootElement();
  if (root is DX.OpenXmlPartRootElement rootElement)
  {
   return rootElement.OpenXmlPart;
  }

  return null;
 }

 /// <summary>
 /// Gets the root element of the OpenXmlElement, which is the topmost ancestor in the element hierarchy.
 /// </summary>
 /// <param name = "element"></param>
 /// <returns></returns>
 public static DX.OpenXmlElement GetRootElement(this DX.OpenXmlElement element)
 {
  var current = element;
  while (current.Parent != null)
  {
   current = current.Parent;
  }

  return current;
 }

 /// <summary>
 /// Gets the WordprocessingDocument that contains the specified OpenXmlElement.
 /// </summary>
 /// <param name = "element">The OpenXmlElement to search for.</param>
 /// <returns>The WordprocessingDocument that contains the specified OpenXmlElement, or null if not found.</returns>
 public static DXPP.WordprocessingDocument? GetWordprocessingDocument(this DX.OpenXmlElement element)
 {
  // Walk up to the root element
  DX.OpenXmlElement? current = element;
  while (current != null && !(current is DX.OpenXmlPartRootElement))
   current = current.Parent;
  if (current is DX.OpenXmlPartRootElement root && root.OpenXmlPart != null)
  {
   return root.OpenXmlPart.OpenXmlPackage as DXPP.WordprocessingDocument;
  }

  return null;
 }

 /// <summary>
 /// Retrieves the font table for the specified Wordprocessing document, creating it if necessary.
 /// </summary>
 /// <param name = "wordDocument">The Document instance.</param>
 /// <returns>The font table element.</returns>
 public static DXW.Fonts GetFontTable(this DXPP.WordprocessingDocument wordDocument)
 {
  var mainPart = wordDocument.MainDocumentPart ?? wordDocument.AddMainDocumentPart();
  var document = mainPart.Document ?? (mainPart.Document = new DXW.Document());
  DXPP.FontTablePart part = mainPart.FontTablePart ?? mainPart.AddNewPart<DXPP.FontTablePart>();
  var fonts = part.Fonts ?? (part.Fonts = new DXW.Fonts());
  return fonts;
 }

 /// <summary>
 /// Retrieves the theme for the specified Wordprocessing document, creating it if necessary.
 /// </summary>
 /// <param name = "wordDocument">The Document instance.</param>
 /// <returns>The theme element.</returns>
 public static DXD.Theme GetTheme(this DXPP.WordprocessingDocument wordDocument)
 {
  var mainPart = wordDocument.MainDocumentPart ?? wordDocument.AddMainDocumentPart();
  var document = mainPart.Document ?? (mainPart.Document = new DXW.Document());
  DXPP.ThemePart part = mainPart.ThemePart ?? mainPart.AddNewPart<DXPP.ThemePart>();
  var theme = part.Theme ?? (part.Theme = new DXD.Theme());
  return theme;
 }

 /// <summary>
 /// Retrieves the Styles element for the specified Wordprocessing document, creating it if necessary.
 /// </summary>
 /// <param name = "wordDocument">The Document instance.</param>
 /// <returns>The Styles element.</returns>
 public static DXW.Styles GetStyles(this DXPP.WordprocessingDocument wordDocument)
 {
  var mainPart = wordDocument.MainDocumentPart ?? wordDocument.AddMainDocumentPart();
  var document = mainPart.Document ?? (mainPart.Document = new DXW.Document());
  DXPP.StyleDefinitionsPart part = mainPart.StyleDefinitionsPart ?? mainPart.AddNewPart<DXPP.StyleDefinitionsPart>();
  var Styles = part.Styles ?? (part.Styles = new DXW.Styles());
  return Styles;
 }

 /// <summary>
 /// Retrieves the Numbering element for the specified Wordprocessing document, creating it if necessary.
 /// </summary>
 /// <param name = "wordDocument">The Document instance.</param>
 /// <returns>The Numbering element.</returns>
 public static DXW.Numbering GetNumbering(this DXPP.WordprocessingDocument wordDocument)
 {
  var mainPart = wordDocument.MainDocumentPart ?? wordDocument.AddMainDocumentPart();
  var document = mainPart.Document ?? (mainPart.Document = new DXW.Document());
  DXPP.NumberingDefinitionsPart part = mainPart.NumberingDefinitionsPart ?? mainPart.AddNewPart<DXPP.NumberingDefinitionsPart>();
  var Numbering = part.Numbering ?? (part.Numbering = new DXW.Numbering());
  return Numbering;
 }
}